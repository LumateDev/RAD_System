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
    public partial class Producement : Form
    {
        public NpgsqlConnection con;
        DataTable dtContract = new DataTable();
        DataSet dsContract = new DataSet();

        public Producement(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            update();

        }



        private void update()
        {
            String sql = "Select * from contract";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            dsContract.Reset();
            da.Fill(dsContract);
            dtContract = dsContract.Tables[0];
            dataGridViewContract.DataSource = dtContract;
            dataGridViewContract.Columns[0].HeaderText = "contract_id";
            dataGridViewContract.Columns[1].HeaderText = "producer_id";
            dataGridViewContract.Columns[2].HeaderText = "total sum";
            dataGridViewContract.Columns[3].HeaderText = "sign date";
            dataGridViewContract.Columns[4].HeaderText = "payment status";
            dataGridViewContract.Columns[5].HeaderText = "overdue payment status";
            dataGridViewContract.Columns[6].HeaderText = "payment";



            /*dataGridViewProducers.DataSource = dt;
            dataGridViewProducers.Columns[0].HeaderText = "id";
            dataGridViewProducers.Columns[1].HeaderText = "Наименование поставщика";
            dataGridViewProducers.Columns[2].HeaderText = "Телефон";*/
        }


    }
}
