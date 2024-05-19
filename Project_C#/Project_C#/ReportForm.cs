using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace project_RAD
{
    public partial class ReportForm : Form
    {

        public NpgsqlConnection con;
        public string[] producerNames;

        public ReportForm(NpgsqlConnection con, string[] producerNames)
        {
            InitializeComponent();
            this.con = con;
            this.producerNames = producerNames;
            this.checkedListBoxProducers.Items.AddRange(producerNames);
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = dateTimePickerFrom.Value;
                DateTime dateTo = dateTimePickerTo.Value;
                List<string> producerNamesChecked = new List<string>();

                for (int i = 0; i < checkedListBoxProducers.CheckedItems.Count; i++)
                {
                    producerNamesChecked.Add(checkedListBoxProducers.CheckedItems[i].ToString());
                }

                if (producerNamesChecked.Count == 0)
                {
                    MessageBox.Show("Необходимо выбрать хотя бы одного производителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = "----------\n";
                result += "Отчёт за период с " + dateFrom.ToShortDateString() + " по " + dateTo.ToShortDateString() + "\n";
                result += "----------\n";

                foreach (string producerName in producerNamesChecked)
                {
                    bool dataFound = false;

                    string sql = @"
                        SELECT 
                            c.contract_id,
                            prod.producer_name,
                            c.sign_date,
                            string_agg(p.product_name || ' - Количество: ' || pc.product_count::text || ' - Сумма за количество: ' || pc.local_total_sum, ', ') AS product_details,
                            c.total_sum,
                            c.payment_status,
                            c.overdue_payment_status,
                            c.payment
                        FROM 
                            contract c
                        JOIN 
                            Producers prod ON c.producer_id = prod.producer_id
                        JOIN 
                            product_contract pc ON c.contract_id = pc.contract_id
                        JOIN 
                            products p ON pc.product_id = p.product_id
                        WHERE 
                            c.sign_date BETWEEN :reportFrom AND :reportTo 
                            AND prod.producer_name = :producer_name
                        GROUP BY 
                            c.contract_id, prod.producer_name, c.sign_date, c.total_sum, c.payment_status, c.overdue_payment_status, c.payment
                        ORDER BY 
                            prod.producer_name";

                    NpgsqlCommand command = new NpgsqlCommand(sql, con);
                    command.Parameters.AddWithValue("reportFrom", dateFrom);
                    command.Parameters.AddWithValue("reportTo", dateTo);
                    command.Parameters.AddWithValue("producer_name", producerName);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        dataFound = true;
                        int contract_id = reader.GetInt32(0);
                        string producer_name = reader.GetString(1);
                        DateTime sign_date = reader.GetDateTime(2);
                        string product_details = reader.GetString(3);
                        decimal total_sum = reader.GetDecimal(4);
                        string payment_status = reader.GetString(5);
                        string overdue_payment_status = reader.GetString(6);
                        decimal payment = reader.GetDecimal(7);

                        result += "Поставщик: " + producer_name + "\n";
                        result += "Дата подписания: " + sign_date.ToShortDateString() + "\n";
                        result += "Товары в контракте: " + product_details + "\n";
                        result += "Итоговая сумма: " + total_sum + "\n";
                        result += "Необходимая предоплата: " + overdue_payment_status + "\n";
                        result += "Внесённая сумма: " + payment + "\n";
                        result += "Статус платежа: " + payment_status + "\n";
                        decimal dolg = total_sum - payment;
                        if (dolg != 0) { result += "Задолженность: " + dolg + "\n"; }
                        result += "----------\n";
                    }
                    if (!dataFound)
                    {
                        result += "Поставщик: " + producerName + "\n";
                        result += "Нет данных о поставщике за данный период.\n";
                        result += "----------\n";
                    }
                    reader.Close();
                }

                richTextBox1.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = dateTimePickerFrom.Value;
                DateTime dateTo = dateTimePickerTo.Value;
                List<string> producerNamesChecked = new List<string>();

                for (int i = 0; i < checkedListBoxProducers.CheckedItems.Count; i++)
                {
                    producerNamesChecked.Add(checkedListBoxProducers.CheckedItems[i].ToString());
                }
                if (producerNamesChecked.Count == 0)
                {
                    MessageBox.Show("Необходимо выбрать хотя бы одного производителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save the report";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Создание экземпляра приложения Excel
                        Excel.Application excelApp = new Excel.Application();
                        excelApp.Visible = false;

                        // Создание новой рабочей книги
                        Excel.Workbook workbook = excelApp.Workbooks.Add();
                        Excel.Worksheet worksheet = workbook.Sheets[1];
                        worksheet.Name = "Report";

                        // Заголовки столбцов
                        worksheet.Cells[1, 1] = "Поставщик";
                        worksheet.Cells[1, 2] = "Дата подписания";
                        worksheet.Cells[1, 3] = "Товары в контракте";
                        worksheet.Cells[1, 4] = "Итоговая сумма";
                        worksheet.Cells[1, 5] = "Необходимая предоплата";
                        worksheet.Cells[1, 6] = "Внесённая сумма";
                        worksheet.Cells[1, 7] = "Статус платежа";
                        worksheet.Cells[1, 8] = "Задолженность";

                        int row = 2;

                        foreach (string producerName in producerNamesChecked)
                        {
                            string sql = @"
    SELECT 
        c.contract_id,
        prod.producer_name,
        c.sign_date,
        string_agg(p.product_name || ' - Количество: ' || pc.product_count::text || ' - Сумма за количество: ' || pc.local_total_sum, ', ') AS product_details,
        c.total_sum,
        c.payment_status,
        c.overdue_payment_status,
        c.payment
    FROM 
        contract c
    JOIN 
        Producers prod ON c.producer_id = prod.producer_id
    JOIN 
        product_contract pc ON c.contract_id = pc.contract_id
    JOIN 
        products p ON pc.product_id = p.product_id
    WHERE 
        c.sign_date BETWEEN :reportFrom AND :reportTo 
        AND prod.producer_name = :producer_name
    GROUP BY 
        c.contract_id, prod.producer_name, c.sign_date, c.total_sum, c.payment_status, c.overdue_payment_status, c.payment
    ORDER BY 
        prod.producer_name";

                            NpgsqlCommand command = new NpgsqlCommand(sql, con);
                            command.Parameters.AddWithValue("reportFrom", dateFrom);
                            command.Parameters.AddWithValue("reportTo", dateTo);
                            command.Parameters.AddWithValue("producer_name", producerName);
                            NpgsqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string producer_name = reader.GetString(1);
                                DateTime sign_date = reader.GetDateTime(2);
                                string product_details = reader.GetString(3);
                                decimal total_sum = reader.GetDecimal(4);
                                string payment_status = reader.GetString(5);
                                string overdue_payment_status = reader.GetString(6);
                                decimal payment = reader.GetDecimal(7);

                                decimal dolg = total_sum - payment;

                                worksheet.Cells[row, 1] = producer_name;
                                worksheet.Cells[row, 2] = sign_date.ToShortDateString();
                                worksheet.Cells[row, 3] = product_details;
                                worksheet.Cells[row, 4] = total_sum;
                                worksheet.Cells[row, 5] = overdue_payment_status;
                                worksheet.Cells[row, 6] = payment;
                                worksheet.Cells[row, 7] = payment_status;
                                worksheet.Cells[row, 8] = dolg != 0 ? (object)dolg : null;

                                row++;
                            }

                            reader.Close();
                        }

                        // Сохранение файла Excel
                        workbook.SaveAs(saveFileDialog.FileName);
                        workbook.Close();
                        excelApp.Quit();

                        // Освобождение ресурсов
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                        MessageBox.Show("Отчет успешно сохранен!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonCreateChart_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = dateTimePickerFrom.Value;
                DateTime dateTo = dateTimePickerTo.Value;
                List<string> producerNamesChecked = new List<string>();

                for (int i = 0; i < checkedListBoxProducers.CheckedItems.Count; i++)
                {
                    producerNamesChecked.Add(checkedListBoxProducers.CheckedItems[i].ToString());
                }

                if (producerNamesChecked.Count == 0)
                {
                    MessageBox.Show("Необходимо выбрать хотя бы одного производителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Tuple<DateTime, decimal>> graphData = new List<Tuple<DateTime, decimal>>();

                foreach (string producerName in producerNamesChecked)
                {
                    string sql = @"
                SELECT 
                    c.sign_date,
                    c.total_sum - c.payment AS outstanding_amount
                FROM 
                    contract c
                JOIN 
                    Producers prod ON c.producer_id = prod.producer_id
                WHERE 
                    c.sign_date BETWEEN :reportFrom AND :reportTo 
                    AND prod.producer_name = :producer_name
                ORDER BY 
                    c.sign_date";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("reportFrom", dateFrom);
                        command.Parameters.AddWithValue("reportTo", dateTo);
                        command.Parameters.AddWithValue("producer_name", producerName);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime signDate = reader.GetDateTime(0);
                                decimal outstandingAmount = reader.GetDecimal(1);
                                graphData.Add(new Tuple<DateTime, decimal>(signDate, outstandingAmount));
                            }
                        }
                    }
                }

                // Открытие формы с графиком
                GraphForm graphForm = new GraphForm(graphData);
                graphForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании графика: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxProducers.Items.Count; i++)
            {
                checkedListBoxProducers.SetItemChecked(i, true);
               
            }
        }
    }
}
