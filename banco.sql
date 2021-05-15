create database banco;
use banco;
create table Produtos(
id int not null auto_increment,
nome varchar(45) not null,
valor double(9,2) not null,
descrição varchar(200) not null,
 fornecedorID int not null,
 categoriaID int not null,
 quantidadeEstoque int unsigned not null,
 foto varchar(200) not null,
 primary key(id),
 foreign key(fornecedorID) references Fornecedores(id),
 foreign key(categoriaID) references Categoria(id)
 );

create table Clientes(
id int not null auto_increment,
nome varchar(45) not null,
cpf char(14) not null,
endereco varchar(200) not null,
 telefone varchar(20) not null,
 email varchar(40) not null,
 senha varchar(30) not null,
 primary key(id)
);

create table Categoria(
id int not null auto_increment,
nome varchar(45) not null,
descricao varchar(200) not null,
primary key(id)
);

create table Fornecedores(
id int not null auto_increment,
nome varchar(45) not null,
cnpj char(18) not null,
email varchar(40) not null,
telefone varchar(20) not null,
nomeRepresentante varchar(45) not null,
 primary key(id)
);
Select * from Clientes ;
insert into Produtos
values(null,"nome",11,"mt bom",0,0,20,"A"); 

Select * from Fornecedores ;
insert into Fornecedores
values(null,"nome",12121212,"caio@gmail.com",31010070,"Marcio",20101010); 

insert into clientes values(null,"maicon","111802246-00","rua tal ", "31010070070", "caio@gmail.com","mamaeu");
