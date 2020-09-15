using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISCO_E_RABISCO
{
    public partial class MenuADM : Form
    {
        public MenuADM()
        {
            InitializeComponent();
        }

        private void ImageProdutos_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.ShowDialog();

           
        }

       

        private void ImageProdução_Click(object sender, EventArgs e)
        {
            Produção pd = new Produção();
            pd.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Financeiros fc = new Financeiros();
            fc.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.ShowDialog();
            
        }

        private void MenuADM_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label3.Text = DateTime.Now.ToString("hh:mm:ss");
            this.label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
