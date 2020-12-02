
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EstacionamentoClientes
{
    class AcessoBanco
    {
        SqlConnection conn = new SqlConnection();
        string strConexao = @"Data Source=DESKTOP-3RMRMBD\SQLEXPRESS;Initial Catalog=EstacionamentoClientes;Integrated Security=True";
        //cadastrar e carregar todos os clientes frmcadastrocliente

        public bool Login(string usuario, string senha)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "SELECT * FROM Logar where Usuario = '" + usuario + "'and Senha = '" + senha + "'";
                    SqlDataAdapter dp = new SqlDataAdapter(cmdo.CommandText, conn);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        result = true;

                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        
        public bool CadastrarCliente(Clientes clientes)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "INSERT INTO cliente(nomecompleto,rg,cpf,cnh,telefone,email,rua,numero,complemento,bairro,cidade,uf) VALUES (@nomecompleto,@rg,@cpf,@cnh,@telefone,@email,@rua,@numero,@complemento,@bairro,@cidade,@uf)";
                    cmdo.Parameters.Add("@nomecompleto", SqlDbType.Text, 100).Value = clientes.NomeCompleto;
                    cmdo.Parameters.Add("@rg", SqlDbType.Text, 20).Value = clientes.RG;
                    cmdo.Parameters.Add("@cpf", SqlDbType.Text, 11).Value = clientes.CPF;
                    cmdo.Parameters.Add("@cnh", SqlDbType.Text, 12).Value = clientes.CNH;
                    cmdo.Parameters.Add("@telefone", SqlDbType.Text, 10).Value = clientes.Telefone;
                    cmdo.Parameters.Add("@email", SqlDbType.Text, 50).Value = clientes.Email;
                    cmdo.Parameters.Add("@rua", SqlDbType.Text, 50).Value = clientes.Rua;
                    cmdo.Parameters.Add("@numero", SqlDbType.Int).Value = clientes.Numero;
                    cmdo.Parameters.Add("@complemento", SqlDbType.Text, 20).Value = clientes.Completento;
                    cmdo.Parameters.Add("@bairro", SqlDbType.Text, 20).Value = clientes.Bairro;
                    cmdo.Parameters.Add("@cidade", SqlDbType.Text, 50).Value = clientes.Cidade;
                    cmdo.Parameters.Add("@uf", SqlDbType.Text, 2).Value = clientes.UF;

                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        //Metodo do  dgv clientes
        public List<Clientes> CarregarTodosClientes()
        {
            List<Clientes> cliente = new List<Clientes>();
            conn.ConnectionString = strConexao;

            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;

                    cmdo.CommandText = "SELECT * FROM Cliente";
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente.Add(new Clientes()
                        {
                            id = Convert.ToInt32(dataReader["Id"]),
                            NomeCompleto = dataReader["nomecompleto"].ToString(),
                            RG = dataReader["rg"].ToString(),
                            CPF = dataReader["cpf"].ToString(),
                            CNH = dataReader["cnh"].ToString(),
                            Telefone = dataReader["telefone"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Rua = dataReader["rua"].ToString(),
                            Numero = Convert.ToInt32(dataReader["numero"]),
                            Completento = dataReader["complemento"].ToString(),
                            Bairro = dataReader["bairro"].ToString(),
                            Cidade = dataReader["cidade"].ToString(),
                            UF = dataReader["uf"].ToString(),
                        });

                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }
        public Clientes PesquisarClientePorId(int id)
        {
            conn.ConnectionString = strConexao;
            Clientes cliente = new Clientes();
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "SELECT * FROM Cliente WHERE id = @id";
                    cmdo.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente.id = Convert.ToInt32(dataReader["Id"]);
                        cliente.NomeCompleto = dataReader["nomecompleto"].ToString();
                        cliente.RG = dataReader["rg"].ToString();
                        cliente.CPF = dataReader["cpf"].ToString();
                        cliente.CNH = dataReader["cnh"].ToString();
                        cliente.Telefone = dataReader["telefone"].ToString();
                        cliente.Email = dataReader["email"].ToString();
                        cliente.Rua = dataReader["rua"].ToString();
                        cliente.Numero = Convert.ToInt32(dataReader["numero"]);
                        cliente.Completento = dataReader["complemento"].ToString();
                        cliente.Bairro = dataReader["bairro"].ToString();
                        cliente.Cidade = dataReader["cidade"].ToString();
                        cliente.UF = dataReader["uf"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }
        public Clientes PesquisarClientePorNome(string nome)
        {
            conn.ConnectionString = strConexao;
            Clientes cliente = new Clientes();
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "SELECT * FROM Cliente WHERE nomecompleto = @nomecompleto";
                    cmdo.Parameters.Add("@nomecompleto", SqlDbType.VarChar,100).Value = nome;
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente.id = Convert.ToInt32(dataReader["Id"]);
                        cliente.NomeCompleto = dataReader["nomecompleto"].ToString();
                        cliente.RG = dataReader["rg"].ToString();
                        cliente.CPF = dataReader["cpf"].ToString();
                        cliente.CNH = dataReader["cnh"].ToString();
                        cliente.Telefone = dataReader["telefone"].ToString();
                        cliente.Email = dataReader["email"].ToString();
                        cliente.Rua = dataReader["rua"].ToString();
                        cliente.Numero = Convert.ToInt32(dataReader["numero"]);
                        cliente.Completento = dataReader["complemento"].ToString();
                        cliente.Bairro = dataReader["bairro"].ToString();
                        cliente.Cidade = dataReader["cidade"].ToString();
                        cliente.UF = dataReader["uf"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }

        public List<Clientes> PesquisarClientePorNomeLike(string nome)
        {
            conn.ConnectionString = strConexao;
            List<Clientes> cliente = new List<Clientes>();
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "SELECT * FROM Cliente WHERE nomecompleto like '%" + nome + "%'";
                    //cmdo.Parameters.Add("@nomecompleto", SqlDbType.VarChar, 100).Value = nome;
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente.Add(new Clientes()
                        {
                            id = Convert.ToInt32(dataReader["Id"]),
                            NomeCompleto = dataReader["nomecompleto"].ToString(),
                            RG = dataReader["rg"].ToString(),
                            CPF = dataReader["cpf"].ToString(),
                            CNH = dataReader["cnh"].ToString(),
                            Telefone = dataReader["telefone"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Rua = dataReader["rua"].ToString(),
                            Numero = Convert.ToInt32(dataReader["numero"]),
                            Completento = dataReader["complemento"].ToString(),
                            Bairro = dataReader["bairro"].ToString(),
                            Cidade = dataReader["cidade"].ToString(),
                            UF = dataReader["uf"].ToString(),
                        });

                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }

        public Veiculo PesquisarVeiculoPorMarca(string Marca)
        {
            conn.ConnectionString = strConexao;
            Veiculo veiculo = new Veiculo();
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "Select Veiculo.id, Veiculo.Cor, Veiculo.Modelo, Veiculo.Marca, Veiculo.Ano, Veiculo.Placa, Veiculo.Veiculo_IDCliente, Cliente.NomeCompleto From Veiculo inner join Cliente on Cliente.id = Veiculo.Veiculo_IDCliente WHERE marca = '" + Marca + "'";
                    //cmdo.Parameters.Add("@marca", SqlDbType.Text, 20).Value = Marca;
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        veiculo.id = Convert.ToInt32(dataReader["id"]);
                        veiculo.Nome = dataReader["NomeCompleto"].ToString();
                        veiculo.Cor = dataReader["cor"].ToString();
                        veiculo.Ano = Convert.ToInt32(dataReader["ano"]);
                        veiculo.Marca = dataReader["marca"].ToString();
                        veiculo.Placa = dataReader["placa"].ToString();
                        veiculo.Modelo = dataReader["modelo"].ToString();
                        veiculo.Veiculo_IDCliente = Convert.ToInt32(dataReader["Veiculo_IDCliente"]);

                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return veiculo;
        }
        public bool CadastrarVeiculos(Veiculo veiculo)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "INSERT INTO Veiculo(Cor,Modelo,Marca,Ano,Placa,Veiculo_IDCliente) VALUES (@cor,@modelo,@marca,@ano,@placa,@Veiculo_IDCliente)";
                    cmdo.Parameters.Add("@cor", SqlDbType.Text, 50).Value = veiculo.Cor;
                    cmdo.Parameters.Add("@modelo", SqlDbType.Text, 40).Value = veiculo.Modelo;
                    cmdo.Parameters.Add("@marca", SqlDbType.Text, 20).Value = veiculo.Marca;
                    cmdo.Parameters.Add("@ano", SqlDbType.Int).Value = veiculo.Ano;
                    cmdo.Parameters.Add("@placa", SqlDbType.Text).Value = veiculo.Placa;
                    cmdo.Parameters.Add("@Veiculo_IDCliente", SqlDbType.Int).Value = veiculo.Veiculo_IDCliente;


                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        // metodo do dgv de veiculos
        public List<Veiculo> CarregarVeiculos()
        {
            List<Veiculo> veiculo = new List<Veiculo>();
            conn.ConnectionString = strConexao;

            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;

                    cmdo.CommandText = "Select Veiculo.id, Veiculo.Cor, Veiculo.Modelo, Veiculo.Marca, Veiculo.Ano, Veiculo.Placa, Veiculo.Veiculo_IDCliente, Cliente.NomeCompleto From Veiculo inner join Cliente on Cliente.id = Veiculo.Veiculo_IDCliente";
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        veiculo.Add(new Veiculo()
                        {
                            id = Convert.ToInt32(dataReader["id"]),
                            Cor = dataReader["Cor"].ToString(),
                            Marca = dataReader["Marca"].ToString(),
                            Modelo = dataReader["Modelo"].ToString(),
                            Ano = Convert.ToInt32(dataReader["Ano"]),
                            Placa = dataReader["Placa"].ToString(),
                            Nome = dataReader["NomeCompleto"].ToString(),
                            Veiculo_IDCliente = Convert.ToInt32(dataReader["Veiculo_IDCliente"]),                            
                        }) ;

                    }
                }

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return veiculo;
        }
        public bool ExcluirClientes(string NomeCompleto)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "DELETE Cliente WHERE nomecompleto = @nomecompleto";
                    cmdo.Parameters.Add("@nomecompleto", SqlDbType.VarChar, 100).Value = NomeCompleto;
                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool ExcluirVeiculo(string placa)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "DELETE Veiculo WHERE placa = @placa";
                    cmdo.Parameters.Add("@placa", SqlDbType.VarChar, 20).Value = placa;
                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool AlterarClientes(Clientes clientes)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "UPDATE Cliente SET @nomecompleto = @nomecompleto, rg = @rg, cpf = @cpf, cnh = @cnh, telefone = @telefone, email = @email, rua = @rua, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf WHERE id = @id";
                    cmdo.Parameters.Add("@id", SqlDbType.Int).Value = clientes.id;
                    cmdo.Parameters.Add("@nomecompleto", SqlDbType.Text, 100).Value = clientes.NomeCompleto;
                    cmdo.Parameters.Add("@rg", SqlDbType.Text, 20).Value = clientes.RG;
                    cmdo.Parameters.Add("@cpf", SqlDbType.Text, 11).Value = clientes.CPF;
                    cmdo.Parameters.Add("@cnh", SqlDbType.Text, 12).Value = clientes.CNH;
                    cmdo.Parameters.Add("@telefone", SqlDbType.Text, 10).Value = clientes.Telefone;
                    cmdo.Parameters.Add("@email", SqlDbType.Text, 50).Value = clientes.Email;
                    cmdo.Parameters.Add("@rua", SqlDbType.Text, 50).Value = clientes.Rua;
                    cmdo.Parameters.Add("@numero", SqlDbType.Int).Value = clientes.Numero;
                    cmdo.Parameters.Add("@complemento", SqlDbType.Text, 20).Value = clientes.Completento;
                    cmdo.Parameters.Add("@bairro", SqlDbType.Text, 20).Value = clientes.Bairro;
                    cmdo.Parameters.Add("@cidade", SqlDbType.Text, 50).Value = clientes.Cidade;
                    cmdo.Parameters.Add("@uf", SqlDbType.Text, 2).Value = clientes.UF;
                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool AlterarVeiculos(Veiculo veiculo)
        {
            bool result = false;
            conn.ConnectionString = strConexao;
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "UPDATE Veiculo SET cor = @cor, modelo  = @modelo, marca = @marca, ano = @ano, placa = @placa, Veiculo_IDCliente = @Veiculo_IDCliente WHERE id = @id";
                    cmdo.Parameters.Add("@id", SqlDbType.Int).Value = veiculo.id;
                    cmdo.Parameters.Add("@modelo", SqlDbType.Text, 40).Value = veiculo.Modelo;
                    cmdo.Parameters.Add("@cor", SqlDbType.Text, 50).Value = veiculo.Cor;
                    cmdo.Parameters.Add("@marca", SqlDbType.Text, 20).Value = veiculo.Marca;
                    cmdo.Parameters.Add("@ano", SqlDbType.Int).Value = veiculo.Ano;
                    cmdo.Parameters.Add("@placa", SqlDbType.Text, 20).Value = veiculo.Placa;
                    cmdo.Parameters.Add("@Veiculo_IDCliente", SqlDbType.Int).Value = veiculo.Veiculo_IDCliente;

                    int linhasAfetadas = cmdo.ExecuteNonQuery();
                    if (linhasAfetadas == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public Veiculo PesquisarVeculoPorPlaca(string Placa)
        {
            conn.ConnectionString = strConexao;
            Veiculo veiculos = new Veiculo();
            try
            {
                using (SqlCommand cmdo = new SqlCommand())
                {
                    conn.Open();
                    cmdo.Connection = conn;
                    cmdo.CommandType = CommandType.Text;
                    cmdo.CommandText = "SELECT * FROM Veiculo WHERE placa = @placa";
                    cmdo.Parameters.Add("@placa", SqlDbType.VarChar, 100).Value = Placa;
                    SqlDataReader dataReader = cmdo.ExecuteReader();
                    while (dataReader.Read())
                    {
                        veiculos.id = Convert.ToInt32(dataReader["Id"]);
                        veiculos.Cor = dataReader["cor"].ToString();
                        veiculos.Marca = dataReader["marca"].ToString();
                        veiculos.Modelo = dataReader["modelo"].ToString();
                        veiculos.Ano = Convert.ToInt32(dataReader["ano"]);
                        veiculos.Placa = dataReader["placa"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return veiculos;
        }
    }
}

          

