using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using RISCO_E_RABISCO.Properties;

namespace RISCO_E_RABISCO
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private int editorId = 0;
        public int EditorId
        {
            get { return editorId; }
            set { editorId = value; }
        }
        private bool isUpdate  = false;
        public bool IsUpdate
        {
            get { return isUpdate; }
            set { isUpdate = value; }
        }



        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                try
                {
                    if (this.isUpdate)
                    {
                        UpdateRecord();
                    }
                    else
                    {
                        SaveRecord();
                        MessageBox.Show("record is saved successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        this.Close();
                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void UpdateRecord()
        {
            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            string cmdString = "UPDATE RISCOEDITOR SET Cliente = @Cliente, Data = @Data, Servico = @Servico, Entrada = @Entrada, Conclusao = @Conclusao,  Tipos = @Tipos, Largura = @Largura, Altura = @Altura, Valor = @Valor, Quantidade = @Quantidade, Total = @Total, Images = @Images WHERE  Id = @EditorId";

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@Data", txtData.Text);
                    cmd.Parameters.AddWithValue("@Servico", txtServico.Text);
                    cmd.Parameters.AddWithValue("@Entrada", txtEntrada.Text);
                    cmd.Parameters.AddWithValue("@Conclusao", txtConclusao.Text);
                    cmd.Parameters.AddWithValue("@Tipos", txtTipos.Text);
                    cmd.Parameters.AddWithValue("@Largura", txtLargura.Text);
                    cmd.Parameters.AddWithValue("@Altura", txtAltura.Text);
                    cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", txtQnt.Text);
                    cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@Images", SaveImage());
                    cmd.Parameters.AddWithValue("@EditorId", this.EditorId);
                   
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("record is saved successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private byte[] SaveImage()
        {
            MemoryStream ms = new MemoryStream();
            pictureImage.Image.Save(ms, pictureImage.Image.RawFormat);
            return ms.GetBuffer();
        }



        private void SaveRecord()
        {
            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            string cmdString = "INSERT INTO RISCOEDITOR(Cliente, Data, Servico, Entrada, Conclusao, Tipos, Largura, Altura, Valor, Quantidade, Total, Images) VALUES (@Cliente, @Data, @Servico, @Entrada, @Conclusao, @Tipos, @Largura, @Altura, @Valor, @Quantidade, @Total, @Images)";

            using (SqlConnection con = new SqlConnection(connString))
            {
                using(SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@Data", txtData.Text);
                    cmd.Parameters.AddWithValue("@Servico", txtServico.Text);
                    cmd.Parameters.AddWithValue("@Entrada", txtEntrada.Text);
                    cmd.Parameters.AddWithValue("@Conclusao", txtConclusao.Text);
                    cmd.Parameters.AddWithValue("@Tipos", txtTipos.Text);
                    cmd.Parameters.AddWithValue("@Largura", txtLargura.Text);
                    cmd.Parameters.AddWithValue("@Altura", txtAltura.Text);
                    cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", txtQnt.Text);
                    cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@Images", SaveImage());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("record is saved successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private bool SaveData()
        {
            if (txtCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Cliente is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente.Focus();
                return false;
            }
            if (txtTipos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tipos is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipos.Focus();
                return false;
            }
            if (txtLargura.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Largura is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLargura.Focus();
                return false;
            }
            if (txtAltura.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Altura is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
                return false;
            }
            if (txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Valor is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
                return false;
            }
            if (txtQnt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantidade is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQnt.Focus();
                return false;
            }
            if (txtTotal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Total is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Focus();
                return false;
            }

            return true;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if(this.IsUpdate)
            {
                DataTable dt = GetEditorInfoById();
                DataRow row = dt.Rows[0];

                txtCliente.Text = row["Cliente"].ToString();
                txtData.Text = row["Data"].ToString();
                txtServico.Text = row["Servico"].ToString();
                txtEntrada.Text = row["Entrada"].ToString();
                txtConclusao.Text = row["Conclusao"].ToString();
                txtTipos.Text = row["Tipos"].ToString();
                txtLargura.Text = row["Largura"].ToString();
                txtAltura.Text = row["Altura"].ToString();
                txtValor.Text = row["Valor"].ToString();
                txtQnt.Text = row["Quantidade"].ToString();
                txtTotal.Text = row["Total"].ToString();
                pictureImage.Image = (row["Images"] is DBNull) ? Resources.pictureImage : LoadImage ((byte[])row["Images"]);
            }
        }

        private Image LoadImage (byte[] Images)
        {
            MemoryStream ms = new MemoryStream(Images);
            return Image.FromStream(ms);
        }


        private DataTable GetEditorInfoById()
        {
            DataTable dtInfo = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            string cmdString = "SELECT Cliente, Data, Servico, Entrada, Conclusao, Tipos, Largura, Altura, Valor, Quantidade, Total, Images FROM RISCOEDITOR WHERE Id = @EditorId ";

            using(SqlConnection con = new SqlConnection(connString))
            {
                using(SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@EditorId", this.EditorId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader); 
                }
            }

            return dtInfo;
        }

        private void pictureImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // ofd.Title = "Select an editor image";
            ofd.Filter = "PNG File (*.png)|*.png |JPG File (*.jpg)|*.jpg";
            if( ofd.ShowDialog() == DialogResult.OK)
            {
                pictureImage.Image = new Bitmap(ofd.FileName);
            }
        }

        private void txtQnt_Click(object sender, EventArgs e)
        {
           
        }

        private void txtQnt_Validating(object sender, CancelEventArgs e)
        {
            if(txtQnt.Text != string.Empty)
            {
              txtTotal.Text = (float.Parse(txtValor.Text) * float.Parse(txtQnt.Text)).ToString();
            }
        }
    }
}
