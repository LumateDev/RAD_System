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
    public partial class Products_Actions : Form

    {
        public NpgsqlConnection con;
        public String action;
        public int product_id;
        public String product_name;
        public decimal product_price;



        public Products_Actions(NpgsqlConnection con, String action, int product_id, String product_name, decimal product_price)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.product_id = product_id;
            this.product_name = product_name;
            this.product_price = product_price;
            formButtonAdd.Text = "Изменить";
            nameTextBox.Text = product_name;
            priceTextBox.Text = product_price.ToString();
        }
        public Products_Actions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;

        }

        private void formButtonAdd_Click(object sender, EventArgs e)
        {
            String product_name = nameTextBox.Text;
            decimal product_price = Convert.ToDecimal(priceTextBox.Text);

            if (action == "add")
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into products(product_name, product_price) VALUES (:product_name, :product_price)", con);
                    command.Parameters.AddWithValue("product_name", product_name);
                    command.Parameters.AddWithValue("product_price", product_price);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар " + product_name + " успешно добавлен");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error add");
                }
            }
            else if (action == "edit")
            {
                try
                {


                    NpgsqlCommand command = new NpgsqlCommand("update products set product_name = :product_name, product_price = :product_price Where product_id = :product_id", con);
                    command.Parameters.AddWithValue("product_id", product_id);
                    command.Parameters.AddWithValue("product_name", product_name);
                    command.Parameters.AddWithValue("product_price", product_price);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар " + product_name + " успешно изменён");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error edit");
                }

            }
            else { MessageBox.Show("Unable to operate on null"); }




        }

        private void butttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
