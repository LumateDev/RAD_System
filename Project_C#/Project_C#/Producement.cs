using Npgsql;
using Project_C_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_RAD
{
    public partial class Producement : Form
    {
        public NpgsqlConnection con;
        DataTable dtContract = new DataTable();
        DataSet dsContract = new DataSet();
        DataTable dtProductContract = new DataTable();
        DataSet dsProductContract = new DataSet();


        public Producement(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            update();

        }



        private void update()
        {
            // Старые запросы
            String sql = "Select * from contract";
            String sql1 = "Select * from product_contract";


            // Новые запросы с JOIN для получения имен вместо идентификаторов
            /*String sql = @"
                SELECT 
                    c.contract_id, 
                    p.producer_name, 
                    c.total_sum, 
                    c.sign_date, 
                    c.payment_status, 
                    c.overdue_payment_status, 
                    c.payment 
                FROM 
                    contract c
                JOIN 
                    producers p ON c.producer_id = p.producer_id";

            String sql1 = @"
                SELECT 
                    pc.product_contract_id, 
                    pr.product_name, 
                    pc.contract_id, 
                    pc.product_count, 
                    pc.local_total_sum 
                FROM 
                    product_contract pc
                JOIN 
                    products pr ON pc.product_id = pr.product_id";*/


            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql1, con);

            dsContract.Reset();
            dsProductContract.Reset();

            da.Fill(dsContract);
            da1.Fill(dsProductContract);

            dtContract = dsContract.Tables[0];
            dataGridViewContract.DataSource = dtContract;
            dataGridViewContract.Columns[0].HeaderText = "Номер контракта";
            //dataGridViewContract.Columns[1].HeaderText = "Производитель"; // Изменение заголовка столбца
            dataGridViewContract.Columns[1].HeaderText = "producer_id"; // Старый заголовок
            dataGridViewContract.Columns[2].HeaderText = "Итоговая сумма";
            dataGridViewContract.Columns[3].HeaderText = "Дата заключения";
            dataGridViewContract.Columns[4].HeaderText = "Статус оплаты";
            dataGridViewContract.Columns[5].HeaderText = "Статус просроченности";
            dataGridViewContract.Columns[6].HeaderText = "Внесённая сумма";

            dtProductContract = dsProductContract.Tables[0];
            dataGridViewProductContract.DataSource = dtProductContract;
            dataGridViewProductContract.Columns[0].HeaderText = "Номер контракта-продукта";
            //dataGridViewProductContract.Columns[1].HeaderText = "Продукт"; // Изменение заголовка столбца
            dataGridViewProductContract.Columns[1].HeaderText = "product_id"; // Старый заголовок
            dataGridViewProductContract.Columns[2].HeaderText = "Номер контракта";
            dataGridViewProductContract.Columns[3].HeaderText = "Количество";
            dataGridViewProductContract.Columns[4].HeaderText = "Сумма";

            dataGridViewProductContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonConstractAdd_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Producement_ContractActions pAdd = new Producement_ContractActions(con, "add");

            pAdd.ShowDialog();
            update();
        }

        private void buttonContractEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int contract_id = (int)dataGridViewContract.CurrentRow.Cells["contract_id"].Value;
                //String producer_name = (String)dataGridViewContract.CurrentRow.Cells["producer_name"].Value; // Новая строка
                int producer_id = (int)dataGridViewContract.CurrentRow.Cells["producer_id"].Value; // Старая строка
                String payment_status = (String)dataGridViewContract.CurrentRow.Cells["payment_status"].Value;
                DateTime dateTime = (DateTime)dataGridViewContract.CurrentRow.Cells["sign_date"].Value;
                decimal payment = (Decimal)dataGridViewContract.CurrentRow.Cells["payment"].Value;

                
                // Найти producer_id по producer_name
                //int producer_id = GetProducerIdByName(producer_name);
                

                Producement_ContractActions pAdd = new Producement_ContractActions(con, "edit", contract_id, producer_id, dateTime, payment, payment_status);
                pAdd.ShowDialog();
                update();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonContractDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int contract_id = (int)dataGridViewContract.CurrentRow.Cells["contract_id"].Value;


                NpgsqlCommand command = new NpgsqlCommand("Delete from contract where contract_id = :contract_id", con);
                command.Parameters.AddWithValue("contract_id", contract_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Контракт успешно удалён");
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void buttonProductContractAdd_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Producement_ProductContractActions pAdd = new Producement_ProductContractActions(con, "add");

            pAdd.ShowDialog();
            update();
        }

        private void buttonProductContractEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int product_contract_id = (int)dataGridViewProductContract.CurrentRow.Cells["product_contract_id"].Value;
                //String product_name = (String)dataGridViewProductContract.CurrentRow.Cells["product_name"].Value; // Новая строка
                int product_id = (int)dataGridViewProductContract.CurrentRow.Cells["product_id"].Value; // Старая строка
                int contract_id = (int)dataGridViewProductContract.CurrentRow.Cells["contract_id"].Value;
                int product_count = (int)dataGridViewProductContract.CurrentRow.Cells["product_count"].Value;

                
                // Найти product_id по product_name
                //int product_id = GetProductIdByName(product_name);
                

                Producement_ProductContractActions pAdd = new Producement_ProductContractActions(con, "edit", contract_id, product_id, product_count, product_contract_id);
                pAdd.ShowDialog();
                update();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonProductContractDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int product_contract_id = (int)dataGridViewProductContract.CurrentRow.Cells["product_contract_id"].Value;


                NpgsqlCommand command = new NpgsqlCommand("Delete from product_contract where product_contract_id = :product_contract_id", con);
                command.Parameters.AddWithValue("product_contract_id", product_contract_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Контракт успешно удалён");
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private int GetProducerIdByName(string producer_name)
        {
            string sql = "SELECT producer_id FROM producers WHERE producer_name = @producer_name";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("producer_name", producer_name);
                return (int)command.ExecuteScalar();
            }
        }

        private int GetProductIdByName(string product_name)
        {
            string sql = "SELECT product_id FROM products WHERE product_name = @product_name";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("product_name", product_name);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
