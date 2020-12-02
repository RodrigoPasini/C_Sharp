
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoClientes
{
    public partial class FrmCadastroClientes : Form
    {
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }
    
        public FrmCadastroClientes(string usuario)
        {
            InitializeComponent();
            lbUsuarioLogado.Text = usuario;
        }
            public void LimparCamposClientes()
        {
            txtNomeCompleto.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtCNH.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtUF.Clear();
            txtPesquisarCodigo.Clear();
            txtPesquisarNome.Clear();
            txtNomeCompleto.Focus();

        }
        public void CarregarTodosClientes()
        {
            AcessoBanco acessobanco = new AcessoBanco();
            dgvCarregarClientes.DataSource = acessobanco.CarregarTodosClientes();
            dgvCarregarClientes.Refresh();
        }

        public void AtualizarNomenaTela(string nome)
        {
            lbUsuarioLogado.Text = nome;
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            FrmVeiculos frmveiculos = new FrmVeiculos(lbUsuarioLogado.Text);
            this.Hide();
            frmveiculos.ShowDialog();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            bool result = false;
            //Intaciar a classe de acesso a dados
            AcessoBanco acessobanco = new AcessoBanco();
            //Intanciar o Obj Cliente
            Clientes cliente = new Clientes();
            cliente.NomeCompleto = txtNomeCompleto.Text;
            cliente.RG = txtRG.Text;
            cliente.CPF = txtCPF.Text;
            cliente.CNH = txtCNH.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Completento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UF = txtUF.Text;

            result = acessobanco.CadastrarCliente(cliente);

            if (result)
            {
                MessageBox.Show(" Cadastrado Realizado com sucesso!"
                , "Cadastro de Cliente"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                LimparCamposClientes();

            }
            else
            {
                MessageBox.Show("Erro! Tente Novamente."
                , "Erro ao cadastrar "
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error);
            }
            CarregarTodosClientes();
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            CarregarTodosClientes();
        }

        private void dgvCarregarClientes_SelectionChanged(object sender, EventArgs e)
        {
            int LinhaAtual = 0;
            // Captura o índice da linha atual selecionada
            LinhaAtual = dgvCarregarClientes.CurrentRow.Index;

            // Captura o valor(conteúdo) da posição (coluna e linha) passada do grid e coloca no formulario.
            txtID.Text = dgvCarregarClientes[0, LinhaAtual].Value.ToString();
            txtNomeCompleto.Text = dgvCarregarClientes[1, LinhaAtual].Value.ToString();
            txtRG.Text = dgvCarregarClientes[2, LinhaAtual].Value.ToString();
            txtCPF.Text = dgvCarregarClientes[3, LinhaAtual].Value.ToString();
            txtCNH.Text = dgvCarregarClientes[4, LinhaAtual].Value.ToString();
            txtTelefone.Text = dgvCarregarClientes[5, LinhaAtual].Value.ToString();
            txtEmail.Text = dgvCarregarClientes[6, LinhaAtual].Value.ToString();
            txtRua.Text = dgvCarregarClientes[7, LinhaAtual].Value.ToString();
            txtNumero.Text = dgvCarregarClientes[8, LinhaAtual].Value.ToString();
            txtComplemento.Text = dgvCarregarClientes[9, LinhaAtual].Value.ToString();
            txtBairro.Text = dgvCarregarClientes[10, LinhaAtual].Value.ToString();
            txtCidade.Text = dgvCarregarClientes[11, LinhaAtual].Value.ToString();
            txtUF.Text = dgvCarregarClientes[12, LinhaAtual].Value.ToString();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir ?" +
                    txtNomeCompleto.Text.ToUpper() + "?", "Exclusão de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                bool result = false;
                AcessoBanco acessobanco = new AcessoBanco();
                string NomeCompleto = txtNomeCompleto.Text;
                result = acessobanco.ExcluirClientes(NomeCompleto);
                if (result)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o Cliente");
                }
                CarregarTodosClientes();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                bool result = false;

                Clientes cliente = new Clientes();
                AcessoBanco acessobanco = new AcessoBanco();

                cliente.id = Convert.ToInt32(txtID.Text);
                cliente.NomeCompleto = txtNomeCompleto.Text;
                cliente.RG = txtRG.Text;
                cliente.CPF = txtCPF.Text;
                cliente.CNH = txtCNH.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Email = txtEmail.Text;
                cliente.Rua = txtRua.Text;
                cliente.Numero = Convert.ToInt32(txtNumero.Text);
                cliente.Completento = txtComplemento.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = txtUF.Text;

                result = acessobanco.AlterarClientes(cliente);
                if (result == true)
                {
                    MessageBox.Show("Alterado com sucesso", "Atualização",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar !!!!!!!!", "Atualização - erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                CarregarTodosClientes();
               
            }
        }


        private void btnPesqNome_Click(object sender, EventArgs e)
        {
            List<Clientes> cliente = new List<Clientes>();
            AcessoBanco acessobanco = new AcessoBanco();

            cliente = acessobanco.PesquisarClientePorNomeLike(txtPesquisarNome.Text);
            if (cliente.Count == 0)
            {
                MessageBox.Show("Não encontrada", "Pequisa por nome",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisarNome.Clear();
                txtPesquisarNome.Focus();
                dgvCarregarClientes.Columns.Clear();
            }
            else
            {
                dgvCarregarClientes.DataSource = cliente;
                dgvCarregarClientes.Refresh();
                
            }
            
                        
        }

        private void btnPesquisarCodigo_Click(object sender, EventArgs e)
        {
           
            
            /*int codigo = Convert.ToInt32(txtPesquisarCodigo.Text);

            Clientes cliente = new Clientes();
            AcessoBanco acessobanco = new AcessoBanco();

            cliente = acessobanco.PesquisarClientePorId(codigo);

            if (cliente.NomeCompleto == null && cliente.id == 0)
            {
                MessageBox.Show("Especialidade não encontrada", "Pequisa por código",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisarCodigo.Clear();
                txtPesquisarCodigo.Focus();
            }
            else
            {
                txtID.Text = cliente.id.ToString();
                txtNomeCompleto.Text = cliente.NomeCompleto;
                txtBairro.Text = cliente.Bairro;
                txtCidade.Text = cliente.Cidade;
                txtUF.Text = cliente.UF;
                txtCNH.Text = cliente.CNH;
                txtComplemento.Text = cliente.Completento;
                txtCPF.Text = cliente.CPF;
                txtEmail.Text = cliente.Email;
                txtTelefone.Text = cliente.Telefone;
                txtNumero.Text = cliente.Numero.ToString();
                txtRG.Text = cliente.RG;
                txtRua.Text = cliente.Rua;
            }*/
        }

        private void btnPesquisarCodigo_Click_1(object sender, EventArgs e)
        {
            if (txtPesquisarCodigo.TextLength == 0)
            {
                MessageBox.Show("Código não inserido", "Pequisa por código",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisarCodigo.Clear();
                txtPesquisarCodigo.Focus();
                return;
            }
            int codigo = Convert.ToInt32(txtPesquisarCodigo.Text);

                Clientes cliente = new Clientes();
                AcessoBanco acessobanco = new AcessoBanco();

                cliente = acessobanco.PesquisarClientePorId(codigo);

                if (cliente.NomeCompleto == null && cliente.id == 0)
                {
                    MessageBox.Show("Código não encontrado", "Pequisa por código",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPesquisarCodigo.Clear();
                    txtPesquisarCodigo.Focus();
                }
                else
                {
                    txtID.Text = cliente.id.ToString();
                    txtNomeCompleto.Text = cliente.NomeCompleto;
                    txtBairro.Text = cliente.Bairro;
                    txtCidade.Text = cliente.Cidade;
                    txtUF.Text = cliente.UF;
                    txtCNH.Text = cliente.CNH;
                    txtComplemento.Text = cliente.Completento;
                    txtCPF.Text = cliente.CPF;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    txtNumero.Text = cliente.Numero.ToString();
                    txtRG.Text = cliente.RG;
                    txtRua.Text = cliente.Rua;
                }
            
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

