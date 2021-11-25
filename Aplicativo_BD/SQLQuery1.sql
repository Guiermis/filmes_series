create database filmes_series;
use filmes_series;
create table lista(
id int primary key identity,
nome varchar(100),
lancamento int,
servico_que_assistiu varchar(100),
nota int);

select * from lista;

insert into lista values ('Your Name', 2016, 'Netflix', 5);