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
    public partial class Futura : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Futura(NpgsqlConnection con)
        {

            InitializeComponent();
            this.con = con;
            this.StartPosition = FormStartPosition.CenterScreen;
            //update();

        }

        private void futuraInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /*
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
}*/
    }
}
