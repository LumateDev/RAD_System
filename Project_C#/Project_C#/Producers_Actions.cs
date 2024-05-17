using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Producers_Actions : Form

    {
        public NpgsqlConnection con;
        public String action;
        public int producer_id;
        public String producer_name;
        public String producer_phone;



        public Producers_Actions(NpgsqlConnection con, String action, int producer_id, String producer_name, String producer_phone)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.producer_id = producer_id;
            this.producer_name = producer_name;
            this.producer_phone = producer_phone;
            buttonProducerAdd.Text = "Изменить";
            textBoxProducerName.Text = producer_name.ToString();
            textBoxProducerPhone.Text = producer_phone.ToString();


        }
        public Producers_Actions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;

        }

       
       

        private void buttonProducerAdd_Click(object sender, EventArgs e)
        {
            String producer_name = textBoxProducerName.Text;
            String producer_phone = textBoxProducerPhone.Text;

            if (action == "add")
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into producers(producer_name, producer_phone) VALUES (:producer_name, :producer_phone)", con);
                    command.Parameters.AddWithValue("producer_name", producer_name);
                    command.Parameters.AddWithValue("producer_phone", producer_phone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Поставщик " + producer_name + " успешно добавлен");
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


                    NpgsqlCommand command = new NpgsqlCommand("update producers set producer_name = :producer_name, producer_phone = :producer_phone Where producer_id = :producer_id", con);
                    command.Parameters.AddWithValue("producer_id", producer_id);
                    command.Parameters.AddWithValue("producer_name", producer_name);
                    command.Parameters.AddWithValue("producer_phone", producer_phone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Поставщик " + producer_name + " успешно изменён");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error edit");
                }

            }
            else { MessageBox.Show("Unable to operate on null"); }




        }

        private void buttonProducerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

