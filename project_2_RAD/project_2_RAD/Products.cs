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

namespace project_2_RAD
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
            String sql = "Select * from product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.Columns[0].HeaderText = "Номер";
            dataGridViewProduct.Columns[1].HeaderText = "Наименование";
            dataGridViewProduct.Columns[2].HeaderText = "Ед. Измерения";
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
                int id = (int)dataGridViewProduct.CurrentRow.Cells["id"].Value;

                NpgsqlCommand command = new NpgsqlCommand("Delete from product where id = :id", con);
                command.Parameters.AddWithValue("id", id);
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
                int id = (int)dataGridViewProduct.CurrentRow.Cells["id"].Value;
                String name = (String)dataGridViewProduct.CurrentRow.Cells["name"].Value;
                String ed = (String)dataGridViewProduct.CurrentRow.Cells["ed"].Value;

                Products_Actions pAdd = new Products_Actions(con, "edit", id, name, ed);
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
