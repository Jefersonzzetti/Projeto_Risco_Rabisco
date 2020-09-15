using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace RISCO_E_RABISCO
{
    public partial class Produção : Form
    {
        public Produção()
        {
            InitializeComponent();
        }

        private DataTable dtRisco = new DataTable();

        private void Produtos_Load(object sender, EventArgs e)
        {

            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            dataGridView.DataSource = GetRisco();


        }

        private DataTable GetRisco()
        {
            //DataTable dtRisco = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {


                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RISCOEDITOR", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtRisco.Load(reader);


                }
            }

            return dtRisco;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowUpdate = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int id = Convert.ToInt32(dataGridView.Rows[rowUpdate].Cells["Id"].Value);


            Editor editor = new Editor();
            editor.EditorId = id;
            editor.IsUpdate = true;
            editor.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this.dataGridView.Rows.Remove(this.dataGridView.SelectedRows[0]);


            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            string cmdString = "DELETE FROM RISCOEDITOR WHERE Id =" + dataGridView.Rows[selectedid].Cells[0].Value;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView.Rows.RemoveAt(selectedid);

                }
            }
        }

        int selectedid = 0;

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = e.RowIndex;
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            DataView dw = dtRisco.DefaultView;
            dw.RowFilter = "Servico LIKE '%" + txtServico.Text + "%'";
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            
            SaveRecord();
            LoadDataIntoDataGridView();
            Status st = new Status();
            st.Show();


        }

        private void SaveRecord()
        {
            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            string cmdString = "INSERT INTO RISCOSTATUS(Cliente, Entrada, Conclusao) VALUES (@Cliente, @Entrada, @Conclusao)";

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Cliente", selectedid);
                    cmd.Parameters.AddWithValue("@Entrada", selectedid);
                    cmd.Parameters.AddWithValue("@Conclusao", selectedid);
                    cmd.ExecuteNonQuery();
                }


            }
        }
    }
}
