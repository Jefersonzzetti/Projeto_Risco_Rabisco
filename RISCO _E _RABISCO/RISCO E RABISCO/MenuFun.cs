using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISCO_E_RABISCO
{
    public partial class MenuFun : Form
    {
        public MenuFun()
        {
            InitializeComponent();
        }

        private void MenuFun_Load(object sender, EventArgs e)
        {

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
    }
}
