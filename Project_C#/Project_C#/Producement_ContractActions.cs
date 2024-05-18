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
using System.Windows.Forms.VisualStyles;

namespace project_RAD
{
    public partial class Producement_ContractActions : Form
    {
        public NpgsqlConnection con;
        public String action;
       
        public int contract_id;
        public String producer_name;
        public int producer_id;
        public DateTime contract_date;
        public decimal payment;

        DataTable dtProducers = new DataTable();
        DataSet dsProducersr = new DataSet();


        public Producement_ContractActions(NpgsqlConnection con, String action, int contract_id, int producer_id, DateTime contract_date, decimal contract_sum, String payment_status)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.contract_id = contract_id;
            this.producer_id = producer_id;
            this.contract_date = contract_date;
            this.payment = contract_sum;
            buttonContractAdd.Text = "Изменить";
            comboBoxPaymentStatus.Text = payment_status;

            loadProducers();
            
            
            dateTimePickerContract.Text = this.contract_date.ToString();
            textBoxPayment.Text = this.payment.ToString();
           

        }
        public Producement_ContractActions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            loadProducers();

        }
        private void loadProducers()
        {
            String sql = "SELECT producer_id,producer_name from producers";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            dsProducersr.Reset();
            da.Fill(dsProducersr);

            dtProducers = dsProducersr.Tables[0];
            comboBoxSelectProducer.DataSource = dtProducers;
            comboBoxSelectProducer.DisplayMember = "producer_name";
            comboBoxSelectProducer.ValueMember = "producer_id";
        }

        private void buttonContractAdd_Click(object sender, EventArgs e)
        {
     
            if (action == "add")
            {
                try
                {
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand("insert into contract(producer_id, total_sum, sign_date,payment_status,payment) VALUES (:producer_id, :total_sum, :sign_date, :payment_status, :payment)", con);
                    npgsqlCommand.Parameters.AddWithValue("producer_id", comboBoxSelectProducer.SelectedValue);
                    npgsqlCommand.Parameters.AddWithValue("total_sum", 0);
                    npgsqlCommand.Parameters.AddWithValue("sign_date", dateTimePickerContract.Value.Date);
                    npgsqlCommand.Parameters.AddWithValue("payment_status", comboBoxPaymentStatus.SelectedItem);
                    npgsqlCommand.Parameters.AddWithValue("payment", Convert.ToDecimal(textBoxPayment.Text));
                    npgsqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Контракт  c " + producer_name+ " успешно добавлен");
                    Close();

            }
                catch (Exception)
                {

                MessageBox.Show("Что то с добавлением");
            }
        }
            else if (action == "edit")
            {
                try
                {


                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update contract set" +
                        " producer_id = :producer_id," +
                        " sign_date = :sign_date,payment_status = :payment_status, payment = :payment" +
                        "  Where contract_id = :contract_id", con);
                    npgsqlCommand.Parameters.AddWithValue("contract_id", contract_id);
                    npgsqlCommand.Parameters.AddWithValue("producer_id", comboBoxSelectProducer.SelectedValue);
                    npgsqlCommand.Parameters.AddWithValue("sign_date", dateTimePickerContract.Value.Date);
                    npgsqlCommand.Parameters.AddWithValue("payment_status", comboBoxPaymentStatus.SelectedItem);
                    npgsqlCommand.Parameters.AddWithValue("payment", Convert.ToDecimal(textBoxPayment.Text));
                    
                    npgsqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Контракт с поставщиком:  " + producer_name + " успешно изменён");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error edit");
                }

            }
            else { MessageBox.Show("Unable to operate on null"); }
        }

        private void buttonContractCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
