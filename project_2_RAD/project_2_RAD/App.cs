using System;
using System.Data;
using Npgsql;

namespace project_2_RAD
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
            con = new NpgsqlConnection("Server=localhost; Port = 5432; UserID=postgres;Password = admin; Database=RadLesson");
            con.Open();
        }

        //product show

        private void button_show(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Products p = new Products(con);
            p.ShowDialog();
        }

        private void buttonClientShow_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Clients c = new Clients(con);
            c.ShowDialog();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Futura f = new Futura(con);
            f.ShowDialog();
        }
    }
}