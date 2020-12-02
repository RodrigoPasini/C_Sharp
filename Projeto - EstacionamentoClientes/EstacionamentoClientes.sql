CREATE DATABASE EstacionamentoClientes
GO

USE EstacionamentoClientes
GO

CREATE TABLE Logar(
	id int primary key identity,
	Usuario varchar(20),
	Senha varchar(20)
)
GO
CREATE TABLE Cliente(

	id int primary key identity,
	NomeCompleto varchar(100),
	RG varchar(20),
	CPF varchar(11),
	CNH varchar(12),
	Telefone varchar(10),
	Email varchar(50),
	Rua varchar(50),
	Numero int,
	Complemento varchar(20),
	Bairro varchar (20),
	Cidade varchar(50),
	UF char (2),
)

GO

CREATE TABLE Veiculo(
	
	id int primary key identity,
	Cor varchar(50),
	Modelo varchar(40),
	Marca varchar(20),
	Ano int,
	Placa varchar(20),
	Veiculo_IDCliente int
	)
	
GO


--Inserindo a Chave Estrangeira "Cliente(id)" na Tabela "Veiculo"
alter table Veiculo ADD FOREIGN KEY (Veiculo_IDCliente) REFERENCES Cliente(id)

GO

insert into Logar (Usuario, Senha) values
	( 'Rodrigo','123123'),
	( 'Joao','123123'),
	( 'Joaquim','123123')



select*from Veiculo
select*from Cliente
select*from Logar


