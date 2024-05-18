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
            String sql = "Select * from contract";
            String sql1 = "Select * from product_contract";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql1, con);

            dsContract.Reset();
            dsProductContract.Reset();

            da.Fill(dsContract);
            da1.Fill(dsProductContract);

            dtContract = dsContract.Tables[0];
            dataGridViewContract.DataSource = dtContract;
            dataGridViewContract.Columns[0].HeaderText = "contract_id";
            dataGridViewContract.Columns[1].HeaderText = "producer_id";
            dataGridViewContract.Columns[2].HeaderText = "total sum";
            dataGridViewContract.Columns[3].HeaderText = "sign date";
            dataGridViewContract.Columns[4].HeaderText = "payment status";
            dataGridViewContract.Columns[5].HeaderText = "overdue payment status";
            dataGridViewContract.Columns[6].HeaderText = "payment";

            dtProductContract = dsProductContract.Tables[0];
            dataGridViewProductContract.DataSource = dtProductContract;
            dataGridViewProductContract.Columns[0].HeaderText = "product_contract_id";
            dataGridViewProductContract.Columns[1].HeaderText = "product_id";
            dataGridViewProductContract.Columns[2].HeaderText = "contract_id";
            dataGridViewProductContract.Columns[3].HeaderText = "product_count";
            dataGridViewProductContract.Columns[4].HeaderText = "local_total_sum";
         
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
                int producer_id = (int)dataGridViewContract.CurrentRow.Cells["producer_id"].Value;
                String payment_status = (String)dataGridViewContract.CurrentRow.Cells["payment_status"].Value;
                DateTime dateTime = (DateTime)dataGridViewContract.CurrentRow.Cells["sign_date"].Value;
                decimal payment = (Decimal)dataGridViewContract.CurrentRow.Cells["payment"].Value;

                Producement_ContractActions pAdd = new Producement_ContractActions(con, "edit", contract_id, producer_id, dateTime, payment, payment_status );
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
                int product_id = (int)dataGridViewProductContract.CurrentRow.Cells["product_id"].Value;
                int contract_id = (int)dataGridViewProductContract.CurrentRow.Cells["contract_id"].Value;
                int product_count = (int)dataGridViewProductContract.CurrentRow.Cells["product_count"].Value;


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
    }
}
