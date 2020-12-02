using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Caixa_de_Frutas_e_Verduras
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Joaquim")
            {
                pctImagem.Image = Properties.Resources.Joaquim;
            }
            if (txtUsuario.Text == "Claudio")
            {
                pctImagem.Image = Properties.Resources.Claudio;
            }
            if (txtUsuario.Text == "Paulo")
            {
                pctImagem.Image = Properties.Resources.Paulo;
            }
            if (txtUsuario.Text == "Fernando")
            {
                pctImagem.Image = Properties.Resources.Fernando;
            }
            if (txtUsuario.Text == "Guilherme")
            {
                pctImagem.Image = Properties.Resources.Guilherme;
            }
        }

        private void pctImagem_Click(object sender, EventArgs e)
        {

        }
        public void LimparLogin()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparLogin();
        }
      
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;
            bool achou = false;
            using (StreamReader reader = new StreamReader(@"C:\Users\Sony\Desktop\RODRIGO TUDO\DESENVOLVIMENTO DE SISTEMAS\Programação de Aplicativos\Usuários.txt"))
            {
                do
                {
                    string linha = reader.ReadLine();
                    int x = linha.IndexOf(";");
                    usuario = linha.Substring(0, x);
                    int tamSenha = linha.Length - 1 - x;
                    senha = linha.Substring(x + 1, tamSenha);
                    if (txtUsuario.Text == usuario && txtSenha.Text == senha)
                    {
                        MessageBox.Show("Usuário logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmCadastroProd frmCadastroProd = new FrmCadastroProd(usuario);
                        frmCadastroProd.Show();
                        this.Hide();
                        achou = true;
                        break;
                    }                    
                } while (!reader.EndOfStream);

                if (achou == false)
                {
                    MessageBox.Show("Usuário ou senha incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
