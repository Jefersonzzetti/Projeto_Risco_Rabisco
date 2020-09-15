using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RISCO_E_RABISCO
{
    public partial class Status : Form
    {
        public Status()
        {
           
            InitializeComponent();

           
        }

        private void Status_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private DataTable dtRisco = new DataTable();

        private void LoadDataIntoDataGridView()
        {
            dataGridView1.DataSource = GetRisco();


        }

        private DataTable GetRisco()
        {
            //DataTable dtRisco = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {


                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RISCOSTATUS", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtRisco.Load(reader);




                }
            }

            return dtRisco;
        }

    }

}
