using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoClientes
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection();
        //string strConexao = @"Data Source=DESKTOP-3RMRMBD\SQLEXPRESS;Initial Catalog=EstacionamentoClientes;Integrated Security=True";
        // metodo limpa login
        public void LimpaLogin()
        {
            txtUsuarioLogin.Clear();
            txtSenha.Clear();
            txtUsuarioLogin.Focus();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = false;

            AcessoBanco acessobanco = new AcessoBanco();

            
            result = acessobanco.Login(txtUsuarioLogin.Text, txtSenha.Text);

            if (result)
            {
                FrmCadastroClientes frmclietes = new FrmCadastroClientes();
                this.Hide();
                frmclietes.AtualizarNomenaTela(txtUsuarioLogin.Text);
                frmclietes.Show();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha com erro", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaLogin();


            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            LimpaLogin();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
