using System;
using System.Data;
using Npgsql;
using project_RAD;


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
            this.StartPosition = FormStartPosition.CenterScreen;
            Products p = new Products(con);
            p.ShowDialog();
        }

        private void producersShowBtn_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Producers p = new Producers(con);
            p.ShowDialog();
        }

        private void buyShowBtn_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Producement p = new Producement(con);
            p.ShowDialog();
        }

        private void invoiceShowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}