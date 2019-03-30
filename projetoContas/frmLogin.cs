using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoContas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "adm" && txtSenha.Text == "123")
            {
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválida!");
                txtUsuario.Focus();
            }
        }
    }
}
