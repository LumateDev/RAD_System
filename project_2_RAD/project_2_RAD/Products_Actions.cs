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
    public partial class Products_Actions : Form

    {
        public NpgsqlConnection con;
        public String action;
        public int id;
        public String name;
        public String ed;

       

        public Products_Actions(NpgsqlConnection con, String action, int id, String name, String ed)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            this.id = id;
            this.name = name;
            this.ed = ed;   
            formButtonAdd.Text = "Изменить";
            nameTextBox.Text = name;
            countTextBox.Text = ed;
        }
        public Products_Actions(NpgsqlConnection con, String action)
        {
            this.con = con;
            InitializeComponent();
            this.action = action;
            
        }

        private void formButtonAdd_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String ed = countTextBox.Text;

            if(action == "add")
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into product(name, ed) VALUES (:name, :ed)", con);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("ed", ed);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар " + name + " успешно добавлен");
                    Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error add");
                }
            }
            else if (action == "edit"){
                try
                {

                   
                    NpgsqlCommand command = new NpgsqlCommand("update product set name = :name, ed = :ed Where id = :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("ed", ed);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар " + name + " успешно изменён");
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
    }
}
