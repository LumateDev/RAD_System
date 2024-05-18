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

namespace project_RAD
{
    public partial class Producement_ProductContractActions : Form


    {

        public NpgsqlConnection con;
        public String action;

        public int product_contract_id;
        public int contract_id;
        public int product_id;
        public int product_count;
        

        DataTable dtProducts = new DataTable();
        DataSet dsProducts = new DataSet();

        DataTable dtContracts = new DataTable();
        DataSet dsContracts = new DataSet();


        public Producement_ProductContractActions(NpgsqlConnection con, String action, int contract_id, int product_id, int product_count, int product_contract_id)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.contract_id = contract_id;
            this.product_id = product_id;
            this.product_count = product_count;
            this.product_contract_id = product_contract_id;

            buttonPA_Add.Text = "Изменить";
            textBoxProductCount.Text = product_count.ToString();

            loadProducts();
            loadContracts();
            
        }

        private void loadProducts()
        {
            String sql = "SELECT product_id, product_name from products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            dsProducts.Reset();
            da.Fill(dsProducts);

            dtProducts = dsProducts.Tables[0];
            comboBoxProduct.DataSource = dtProducts;
            comboBoxProduct.DisplayMember = "product_name";
            comboBoxProduct.ValueMember = "product_id";
        }

        private void loadContracts()
        {
            String sql = "SELECT contract_id from contract";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter (sql, con);
            dsContracts.Reset();
            da.Fill(dsContracts);

            dtContracts = dsContracts.Tables[0];
            comboBoxContractId.DataSource = dtContracts;
            comboBoxContractId.DisplayMember = "contract_id";
            comboBoxContractId.ValueMember = "contract_id";
        }

        public Producement_ProductContractActions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            loadProducts();
            loadContracts ();

        }

        private void buttonPA_Add_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                try
                {

                NpgsqlCommand npgsqlCommand = new NpgsqlCommand("insert into product_contract(product_id, contract_id, product_count) VALUES (:product_id, :contract_id, :product_count)", con);
                npgsqlCommand.Parameters.AddWithValue("product_id", comboBoxProduct.SelectedValue);
                npgsqlCommand.Parameters.AddWithValue("contract_id", comboBoxContractId.SelectedValue);
                npgsqlCommand.Parameters.AddWithValue("product_count", Convert.ToInt32(textBoxProductCount.Text));
               
                npgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("Контракт-договор успешно добавлен");
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


                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand("update product_contract set product_id = :product_id, contract_id = :contract_id, product_count = :product_count Where product_contract_id = :product_contract_id", con);
                npgsqlCommand.Parameters.AddWithValue("product_contract_id", product_contract_id);
                npgsqlCommand.Parameters.AddWithValue("product_id", comboBoxProduct.SelectedValue);
                npgsqlCommand.Parameters.AddWithValue("contract_id", comboBoxContractId.SelectedValue);
                npgsqlCommand.Parameters.AddWithValue("product_count", Convert.ToInt32(textBoxProductCount.Text));
                npgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("Контракт с поставщиком успешно изменён");
                Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error edit");
                }

            }
            else { MessageBox.Show("Unable to operate on null"); }
        }

        private void buttonPA_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
