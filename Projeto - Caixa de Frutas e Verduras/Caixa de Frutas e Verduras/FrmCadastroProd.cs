using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_de_Frutas_e_Verduras
{
    public partial class FrmCadastroProd : Form
    {
        Produtos Produtos = new Produtos();
        List<Produtos> Alimentos = new List<Produtos>();

        public FrmCadastroProd()
        {
            InitializeComponent();
        }

        //Método Construtor

        public FrmCadastroProd(string usuario)
        {
            InitializeComponent();
            lblUsuarioLogado.Text = usuario;
        }
        public void ValorSubtotal()
        {
            decimal PrecoQuilo = 0;
            decimal Quantidade = 0;
            decimal Subtotal = 0;

            PrecoQuilo = Convert.ToDecimal(txtPreco.Text);
            Quantidade = Convert.ToDecimal(txtQuantidade.Text);

            Subtotal = PrecoQuilo * Quantidade;

            txtSubtotal.Text = Subtotal.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
            cmbTipo.SelectedIndex = 0;

            if (txtCod.Text == "1")
            {
                pctCaixa.Image = Properties.Resources.Alface;
                txtNome.Text = "Alface";
                txtPreco.Text = "2,85";
            }
            else if (txtCod.Text == "2")
            {
                pctCaixa.Image = Properties.Resources.Banana;
                txtNome.Text = "Banana";
                cmbTipo.SelectedIndex = 1;
                txtPreco.Text = "1,15";
            }
            else if (txtCod.Text == "3")
            {
                pctCaixa.Image = Properties.Resources.Batata;
                txtNome.Text = "Batata";
                txtPreco.Text = "3,99";
            }
            else if (txtCod.Text == "4")
            {
                pctCaixa.Image = Properties.Resources.Brócolis;
                txtNome.Text = "Brocóblis";
                txtPreco.Text = "3,20";
            }
            else if (txtCod.Text == "5")
            {
                pctCaixa.Image = Properties.Resources.Cebola;
                txtNome.Text = "Cebola";
                txtPreco.Text = "2,15";
            }
            else if (txtCod.Text == "6")
            {
                pctCaixa.Image = Properties.Resources.Cenoura;
                txtNome.Text = "Cenoura";
                txtPreco.Text = "2,11";

            }
            else if (txtCod.Text == "7")
            {
                pctCaixa.Image = Properties.Resources.Maçã;
                txtNome.Text = "Maça";
                cmbTipo.SelectedIndex = 1;
                txtPreco.Text = "5,56";
            }
            else if (txtCod.Text == "8")
            {
                pctCaixa.Image = Properties.Resources.Morango;
                txtNome.Text = "Morango";
                cmbTipo.SelectedIndex = 1;
                txtPreco.Text = "10,00";
            }
            else if (txtCod.Text == "9")
            {
                pctCaixa.Image = Properties.Resources.Pêra;
                txtNome.Text = "Pêra";
                cmbTipo.SelectedIndex = 1;
                txtPreco.Text = "5,50";
            }
            else if (txtCod.Text == "10")
            {
                pctCaixa.Image = Properties.Resources.Uva;
                txtNome.Text = "Uva";
                cmbTipo.SelectedIndex = 1;
                txtPreco.Text = "1,03";
            }
            else
            {
                pctCaixa.Image = Properties.Resources.Cesta;
                txtNome.Clear();
                txtPreco.Clear();
                cmbTipo.SelectedIndex = -1;
                btnCadastrar.Enabled = false;
            }

        }
        public void LimparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            cmbTipo.SelectedIndex = -1;
            txtPreco.Clear();
            txtQuantidade.Clear();
            dtpVencimento.Value = DateTime.Now;
            txtSubtotal.Clear();
            //txtTotal.Clear();
            txtCod.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void CadastrarNoArquivo()
        {
            // Salvando no arquivo Produtos.txt
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Sony\Desktop\RODRIGO TUDO\DESENVOLVIMENTO DE SISTEMAS\Programação de Aplicativos\Produtos.txt", true))
            {
                sw.WriteLine(Produtos.Codigo + ";" + Produtos.Produto + ";" + Produtos.Tipo + ";" + Produtos.Quantidade + ";" +
                Produtos.Preco + ";" + Produtos.Vencimento + ";" + Produtos.Subtotal + ";" + Produtos.Total);
                sw.Close();
            }
        }


        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Produtos.Codigo = Convert.ToInt32(txtCod.Text);
            Produtos.Produto = txtNome.Text;
            Produtos.Tipo = cmbTipo.Text;
            Produtos.Preco = Convert.ToDecimal(txtPreco.Text);
            Produtos.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
            Produtos.Vencimento = dtpVencimento.Value;
            Produtos.Subtotal = Convert.ToDecimal(txtSubtotal.Text);


            Alimentos.Add(Produtos);


            Decimal soma_temporaria = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtSubtotal.Text);
            txtTotal.Text = Convert.ToString(soma_temporaria);

            int i = dgvProdutos.Rows.Add();

            dgvProdutos.Rows[i].Cells[0].Value = txtCod.Text;
            dgvProdutos.Rows[i].Cells[1].Value = txtNome.Text;
            dgvProdutos.Rows[i].Cells[2].Value = cmbTipo.Text;
            dgvProdutos.Rows[i].Cells[3].Value = txtPreco.Text;
            dgvProdutos.Rows[i].Cells[4].Value = txtQuantidade.Text;
            dgvProdutos.Rows[i].Cells[5].Value = dtpVencimento.Text;
            dgvProdutos.Rows[i].Cells[6].Value = txtSubtotal.Text;
            dgvProdutos.Rows[i].Cells[7].Value = txtTotal.Text;






            txtCod.Clear();
            txtNome.Clear();
            cmbTipo.SelectedIndex = -1;
            txtPreco.Clear();
            txtQuantidade.Clear();
            dtpVencimento.Value = DateTime.Now;
            txtSubtotal.Clear();
          
          MessageBox.Show("Produto inserido com sucesso", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            CadastrarNoArquivo();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCadastroProd_Load(object sender, EventArgs e)
        {
            lblDataLogin.Text = Convert.ToString(DateTime.Now);
        }
        
        private void txtTotal_Enter(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            decimal PrecoQuilo = 0;
            decimal Quantidade = 0;
            decimal Subtotal = 0;

            if (txtPreco.Text.Length != 0)
            {
                PrecoQuilo = Convert.ToDecimal(txtPreco.Text);
            }
            
            if(txtQuantidade.Text.Length != 0)
            {
                Quantidade = Convert.ToDecimal(txtQuantidade.Text);
            }
            else 
            { 
                txtQuantidade.Text = "0";
            }
            

            Subtotal = PrecoQuilo * Quantidade;

            txtSubtotal.Text = Subtotal.ToString();
        }
    }
}
