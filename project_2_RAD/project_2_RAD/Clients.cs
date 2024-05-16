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
    public partial class Clients : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Clients(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            update();
        }


        private void update()
        {
            String sql = "Select * from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewClient.DataSource = dt;
            dataGridViewClient.Columns[0].HeaderText = "Id";
            dataGridViewClient.Columns[1].HeaderText = "Имя";
            dataGridViewClient.Columns[2].HeaderText = "Адресс";
            dataGridViewClient.Columns[3].HeaderText = "Телефон";
        }




        private void buttonClientAdd_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
          
            Clients_Actions cAdd = new Clients_Actions(con, "add");
            cAdd.ShowDialog();
            update();
        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClient.CurrentRow.Cells["id"].Value;

                NpgsqlCommand command = new NpgsqlCommand("Delete from client where id = :id", con);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно удалён");
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error delete client");
            }
        }

        private void buttonClientEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClient.CurrentRow.Cells["id"].Value;
                String name = (String)dataGridViewClient.CurrentRow.Cells["name"].Value;
                String adress = (String)dataGridViewClient.CurrentRow.Cells["adress"].Value;
                String phone = (String)dataGridViewClient.CurrentRow.Cells["phone"].Value;
                Clients_Actions cEdit = new Clients_Actions(con, "edit", id, name, adress, phone);
                
                cEdit.ShowDialog();
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

   
    }
}



