DROP DATABASE IF EXISTS bdCarro;
CREATE DATABASE bdCarro;
USE bdCarro;
CREATE TABLE veiculos(
	vei_ID int(11) auto_increment not null,
	vei_Nome varchar(50) not null,
	vei_End varchar(50) not null,
	vei_Bairro varchar(50) not null,
	vei_Complemento varchar(100),
	vei_EstadoPes varchar(50) not null,
	vei_CidadePes varchar(50) not null,
	vei_Rg varchar(50) not null,
	vei_Cpf varchar(50) not null,
	vei_DatNasc varchar(50) not null,
	vei_Sexo varchar(50) not null,
	vei_Modelo varchar(50) not null,
	vei_Ano int(10) not null,
	vei_Placa varchar(10) not null,
	vei_CidadeCar varchar(50) not null,
	vei_Fabricante varchar(50) not null,
	vei_Cor varchar(50) not null,
	vei_EstadoCar varchar(50) not null,
CONSTRAINT vei_ID PRIMARY KEY(vei_ID));