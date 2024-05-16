using System;
using System.Data;
using Npgsql;


namespace Project_C_
{
    public partial class App : Form

    {
        public NpgsqlConnection con;

        public App()
        {
            InitializeComponent();
            MyLoad();
        }
        public void MyLoad()
        {
            con = new NpgsqlConnection("Server=localhost; Port = 5432; UserID=postgres;Password = admin; Database=RadProject");
            con.Open();
        }

        private void productShowBtn_Click(object sender, EventArgs e)
        {

        }

        private void producersShowBtn_Click(object sender, EventArgs e)
        {

        }

        private void buyShowBtn_Click(object sender, EventArgs e)
        {

        }

        private void invoiceShowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}