using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmLogin : Form
    {
        //variavel global
      
        //método construtor
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("etecia")&&senha.Equals("123456"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("Erroooooooooooooooooou! ", "Mensagem", MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }

 
        }
        //limpar nomes
        public void limparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Clear();
            txtUsuario.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
