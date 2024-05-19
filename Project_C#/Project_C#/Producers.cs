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
    public partial class Producers : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Producers(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            update();

        }



        private void update()
        {
            String sql = "Select * from producers";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewProducers.DataSource = dt;
            dataGridViewProducers.Columns[0].HeaderText = "id";
            dataGridViewProducers.Columns[1].HeaderText = "Наименование поставщика";
            dataGridViewProducers.Columns[2].HeaderText = "Телефон";
            dataGridViewProducers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonAddProducer_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Producers_Actions pAdd = new Producers_Actions(con, "add");

            pAdd.ShowDialog();
            update();
        }

        private void buttonEditProducer_Click(object sender, EventArgs e)
        {
            try
            {
                int producer_id = (int)dataGridViewProducers.CurrentRow.Cells["producer_id"].Value;
                String producer_name = (String)dataGridViewProducers.CurrentRow.Cells["producer_name"].Value;
                String producer_phone =(String)dataGridViewProducers.CurrentRow.Cells["producer_phone"].Value;

                Producers_Actions pAdd = new Producers_Actions(con, "edit", producer_id, producer_name, producer_phone);
                pAdd.ShowDialog();
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void buttonDeleteProducer_Click(object sender, EventArgs e)
        {
            try
            {
                int producer_id = (int)dataGridViewProducers.CurrentRow.Cells["producer_id"].Value;


                NpgsqlCommand command = new NpgsqlCommand("Delete from producers where producer_id = :producer_id", con);
                command.Parameters.AddWithValue("producer_id", producer_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Поставщик успешно удалён");
                update();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
