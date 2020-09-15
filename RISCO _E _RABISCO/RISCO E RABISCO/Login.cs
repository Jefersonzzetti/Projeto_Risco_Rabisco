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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administração") && (txtSenha.Text == "123"))
            {
                MenuADM meuadm = new MenuADM();
                this.Hide();
                meuadm.Show();
                

            }
            
            if ((txtUsuario.Text == "Funcionário") && (txtSenha.Text == "456"))
            {
                MenuFun menufun = new MenuFun();
                this.Hide();
                menufun.Show();
                
            }

            
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
