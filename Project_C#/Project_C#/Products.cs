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
    public partial class Products : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Products(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            update();

        }



        private void update()
        {
            String sql = "Select * from products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.Columns[0].HeaderText = "id";
            dataGridViewProduct.Columns[1].HeaderText = "Наименование";
            dataGridViewProduct.Columns[2].HeaderText = "Цена";
            //делаем ширину колонок подходящей под содержимое
            foreach (DataGridViewColumn column in dataGridViewProduct.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }




        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Products_Actions pAdd = new Products_Actions(con, "add");

            pAdd.ShowDialog();
            update();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int product_id = (int)dataGridViewProduct.CurrentRow.Cells["product_id"].Value;
                

                NpgsqlCommand command = new NpgsqlCommand("Delete from products where product_id = :product_id", con);
                command.Parameters.AddWithValue("product_id", product_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Товар успешно удалён");
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int product_id = (int)dataGridViewProduct.CurrentRow.Cells["product_id"].Value;
                String product_name = (String)dataGridViewProduct.CurrentRow.Cells["product_name"].Value;
                decimal product_price = Convert.ToDecimal(dataGridViewProduct.CurrentRow.Cells["product_price"].Value);

                Products_Actions pAdd = new Products_Actions(con, "edit", product_id, product_name, product_price);
                pAdd.ShowDialog();
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
