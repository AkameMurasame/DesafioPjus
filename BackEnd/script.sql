create database desafiopjus;
use desafiopjus;

create table Cep (
id int unsigned auto_increment not null,
cep varchar(20) not null,
logradouro varchar(100) not null,
complemento varchar(20) not null,
bairro varchar(20) not null,
localidade varchar(20) not null,
uf char(2) not null,
ibge varchar(20),
gia varchar(20),
ddd varchar(20) not null,
siafi varchar(20),
primary key (id)
);