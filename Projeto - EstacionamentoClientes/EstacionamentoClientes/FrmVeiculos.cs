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
    public partial class FrmVeiculos : Form
    {
        public FrmVeiculos()
        {
            InitializeComponent();
        }
        public FrmVeiculos(string usuario)
        {
            InitializeComponent();
            txtUsuarioLogado.Text = usuario;
        }
        public void LimparCamposVeiculos()
        {
            txtID.Clear();
            cmbNomeCliente.SelectedItem = -1;
            txtPlaca.Clear();
            cmbMarca.SelectedItem = -1;
            txtModelo.Clear();
            txtAno.Clear();
            txtCor.Clear();
            cmbNomeCliente.Focus();
        }
        public void CarregarTodosVeiculos()
        {
            AcessoBanco acessobanco = new AcessoBanco();
            dgvVeiculos.DataSource = acessobanco.CarregarVeiculos();
            dgvVeiculos.Refresh();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            bool result = false;

            AcessoBanco acessobanco = new AcessoBanco();

            Veiculo veiculo = new Veiculo();

            //veiculo.Nome = cmbNomeCliente.SelectedItem.ToString();
            veiculo.Placa = txtPlaca.Text;
            veiculo.Marca = cmbMarca.SelectedItem.ToString();
            veiculo.Modelo = txtModelo.Text;
            veiculo.Ano = Convert.ToInt32(txtAno.Text);
            veiculo.Cor = txtCor.Text;
            veiculo.Veiculo_IDCliente = Convert.ToInt32(txtIdCliente.Text);


            result = acessobanco.CadastrarVeiculos(veiculo);

            if (result)
            {
                MessageBox.Show(" Cadastrado Realizado com sucesso!"
                , "Cadastro de Veiculo"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                CarregarTodosVeiculos();
            }
            else
            {
                MessageBox.Show("Erro! Tente Novamente."
                , "Erro ao cadastrar o veiculo "
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error);
                CarregarTodosVeiculos();
            }
            
        }

        private void dgvVeiculos_SelectionChanged(object sender, EventArgs e)
        {
            int LinhaAtual = 0;
            // Captura o índice da linha atual selecionada
            LinhaAtual = dgvVeiculos.CurrentRow.Index;

            // Captura o valor(conteúdo) da posição (coluna e linha) passada do grid e coloca no formulario.
            txtID.Text = dgvVeiculos[0, LinhaAtual].Value.ToString();
            cmbNomeCliente.SelectedItem = dgvVeiculos[7, LinhaAtual].Value.ToString();
            txtPlaca.Text = dgvVeiculos[5, LinhaAtual].Value.ToString();
            cmbMarca.SelectedItem = dgvVeiculos[2, LinhaAtual].Value.ToString();
            txtModelo.Text = dgvVeiculos[3, LinhaAtual].Value.ToString();
            txtAno.Text = dgvVeiculos[4, LinhaAtual].Value.ToString();
            txtCor.Text = dgvVeiculos[1, LinhaAtual].Value.ToString();
            txtIdCliente.Text = dgvVeiculos[6, LinhaAtual].Value.ToString();
            
        }

        private void FrmVeiculos_Load(object sender, EventArgs e)
        {
            CarregarTodosVeiculos();
            AcessoBanco acessobanco = new AcessoBanco();
            List<Clientes> cliente = new List<Clientes>();
            cliente = acessobanco.CarregarTodosClientes();
            foreach (var nomes in cliente)
            {
                cmbNomeCliente.Items.Add(nomes.NomeCompleto);
            }
            CarregarTodosVeiculos();
        }

        private void bntAlterarVeiculo_Click(object sender, EventArgs e)
        {
            {
                bool result = false;

                Veiculo veiculos = new Veiculo();
                AcessoBanco acessobanco = new AcessoBanco();

                veiculos.id = Convert.ToInt32(txtID.Text);
                veiculos.Cor = txtCor.Text;
                veiculos.Marca = cmbMarca.Text;
                veiculos.Modelo = txtModelo.Text;
                veiculos.Placa = txtPlaca.Text;
                veiculos.Ano = Convert.ToInt32(txtAno.Text);
                veiculos.Veiculo_IDCliente = Convert.ToInt32(txtIdCliente.Text);


                result = acessobanco.AlterarVeiculos(veiculos);
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
                CarregarTodosVeiculos();

            }
        }

        private void btnLimpaVeiculos_Click(object sender, EventArgs e)
        {
            LimparCamposVeiculos();
        }

        private void bntExcluirVeiculo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir ?" +
                    txtPlaca.Text.ToUpper() + "?", "Exclusão de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                bool result = false;
                AcessoBanco acessobanco = new AcessoBanco();
                string placa = txtPlaca.Text;
                result = acessobanco.ExcluirVeiculo(placa);
                if (result)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o Veiculo");
                }
                CarregarTodosVeiculos();
            }

        }

        private void btnPesquisarMarca_Click(object sender, EventArgs e)
        { 
                Veiculo veiculo = new Veiculo();
                AcessoBanco acessobanco = new AcessoBanco();

                veiculo = acessobanco.PesquisarVeiculoPorMarca(cmbPesquisarMarca.SelectedItem.ToString());
                if (veiculo.Marca == null)
                {
                    MessageBox.Show("Não encontrada", "Pequisa por nome",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAno.Text = veiculo.id.ToString();
                    txtCor.Text = veiculo.Cor;
                    txtModelo.Text = veiculo.Modelo;
                    txtPlaca.Text = veiculo.Placa;
                    txtAno.Text = veiculo.Ano.ToString();
                    cmbMarca.SelectedItem = veiculo.Marca.ToString();
                cmbNomeCliente.SelectedItem = veiculo.Nome.ToString();

                }
            
        }

        private void btnPesqPlaca_Click(object sender, EventArgs e)
        {
            Veiculo veiculos = new Veiculo();
            AcessoBanco acessobanco = new AcessoBanco();

            veiculos = acessobanco.PesquisarVeculoPorPlaca(txtPesquisarPlaca.Text);
            if (veiculos.Placa == null)
            {
                MessageBox.Show("Não encontrada", "Pequisa por nome",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisarPlaca.Clear();
                txtPesquisarPlaca.Focus();
            }
            else
            {
                txtID.Text = veiculos.id.ToString();
                txtCor.Text = veiculos.Cor;
                txtAno.Text = veiculos.Ano.ToString();
                txtPlaca.Text = veiculos.Placa;
                cmbMarca.Text = veiculos.Marca;
                txtModelo.Text = veiculos.Modelo;


            }
        }

        private void btnPesqPlaca_Click_1(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            AcessoBanco acessobanco = new AcessoBanco();

            veiculo = acessobanco.PesquisarVeculoPorPlaca(txtPesquisarPlaca.Text);
            if (veiculo.Placa == null)
            {
                MessageBox.Show("Não encontrada", "Pequisa por nome",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPesquisarPlaca.Clear();
                txtPesquisarPlaca.Focus();
            }
            else
            {
                txtAno.Text = veiculo.id.ToString();
                txtCor.Text = veiculo.Cor;
                txtModelo.Text = veiculo.Modelo;
                txtPlaca.Text = veiculo.Placa;
                txtAno.Text = veiculo.Ano.ToString();
                cmbMarca.Text = veiculo.Marca.ToString();

            }

        }

        private void cmbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteveiculo  = new Clientes();
            AcessoBanco acessobanco = new AcessoBanco();
            clienteveiculo = acessobanco.PesquisarClientePorNome(cmbNomeCliente.SelectedItem.ToString());
            txtIdCliente.Text = clienteveiculo.id.ToString();
        }
    }
}
