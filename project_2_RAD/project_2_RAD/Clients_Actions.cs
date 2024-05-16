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
    public partial class Clients_Actions : Form

    {
        public NpgsqlConnection con;
        public String action;
        public int id;
        public String name;
        public String phone;
        public String adress;



        public Clients_Actions(NpgsqlConnection con, String action, int id, String name, String adress, String phone)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            formButtonAdd.Text = "Изменить";
            nameTextBox.Text = name;
            phoneTextBox.Text = phone;
            adressTextBox1.Text = adress;
        }

        public Clients_Actions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;

        }

        private void formButtonAdd_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String phone = phoneTextBox.Text;
            String adress = adressTextBox1.Text;

            if (action == "add")
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into client(name, adress, phone) VALUES (:name, :adress, :phone)", con);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("adress", adress);
                    command.Parameters.AddWithValue("phone", phone);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Клиент " + name + " успешно добавлен");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error add client");
                }
            }
            else if (action == "edit")
            {
                try
                {


                    NpgsqlCommand command = new NpgsqlCommand("update client set name = :name, adress = :adress, phone = :phone Where id = :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("adress", adress);
                    command.Parameters.AddWithValue("phone", phone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Клиент " + name + " успешно изменён");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error edit client");
                }

            }
            else { MessageBox.Show("Unable to operate on null"); }




        }

        private void butttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
