##Grupo:Sistema de Laboratório
##Nome:Christyan Henrique Costa da Silva,Keren Azevedo de Siqueira,Laura Gabrielly Dantas,Matheus Taylor Pedrosa Andrade Teles,Makeivy de Jesus Moura.
##Requisitos Funcionais:Logar Usúario,Cadastrar Paciente,Cadastrar Médico,Realizar Pedidos Pacientes,Exibir Exames Disponiveís,Realizar Resultado dos Exames,Gerar Convênio,Gerar Faturamento,Gerar Gerenciamento Financeiro,Vender Exames,Cadastrar Funcionarios,Exibir Menus.
create database BD_SistemLab;
use BD_SistemLab;

create table Funcionario(
id_func int primary key not null auto_increment,
atuacao_func varchar(200),
cpf_func varchar(20),
logradouro_func varchar(300),
telefone_func int,
numero_func int,
cidade_func varchar(50),
nome_func varchar(100),
cep_func int
);
 create table Usuario(
id_usu int primary key not null auto_increment,
id_func_fk int not null,
login varchar(100),
senha varchar(50),
foreign key (id_func_fk) references funcionario (id_func)
);

create table Medico(
id_med int not null primary key auto_increment,
cpf_med varchar(20),
RG_med varchar(30),
nome_med varchar(100),
logradouro_med varchar(300),
cep_med int
);

create table Paciente(
id_pa int not null primary key auto_increment, 
nome_pa varchar(100),
cep_pa int,
tipo_san_pa varchar(8),
cpf_pa varchar(20),
data_nas_pa date,
logradouro_pa varchar(300),
numero_pa int,
rg_pa varchar(30)
);

create table Pedidos_pacientes(
id_ped int not null primary key auto_increment,
descricao_ped varchar(200),
tipo_ped varchar(100),
id_pa_fk int not null,
foreign key (id_pa_fk) references paciente (id_pa)
);

create table Financeiro(
id_fin int not null primary key auto_increment,
data_entrega date,
valor_liq float,
valor_brut float
);

create table Venda (
id_vend int not null primary key auto_increment,
id_ped_fk int not null,
data_exa date,
valor_exa float,
quant_exa int,
id_fin_fk int not null,
foreign key (id_ped_fk) references pedidos_pacientes (id_ped),
foreign key (id_fin_fk) references financeiro (id_fin)

);

create table Pedidos_medicos(
id_ped_med int not null primary key auto_increment,
id_med_fk int not null,
id_ped_fk int not null,
foreign key (id_med_fk) references medico (id_med),
foreign key (id_ped_fk) references pedidos_pacientes (id_ped)
);

create table Convenio(
id_conv int not null primary key auto_increment,
CNPG_do_cli_conv varchar(30),
tipo_conv varchar(100)
);

create table Exame(
id_exa int not null primary key auto_increment,
exame varchar(100),
resultado varchar(200),
id_conv_fk int not null,
id_ped_fk int not null,

foreign key (id_conv_fk) references convenio (id_conv),
foreign key (id_ped_fk) references pedidos_pacientes (id_ped)

);

create table Venda_exame (
id_vend_exa int not null primary key auto_increment,
id_exa_fk int not null,
id_vend_fk int not null,
foreign key (id_exa_fk) references exame (id_exa),
foreign key (id_vend_fk) references venda(id_vend)	
);

create table Vend_func(
id_vend_func int not null primary key auto_increment,
id_func_fk int not null,
id_vend_fk int not null,
foreign key (id_func_fk) references funcionario (id_func),
foreign key (id_vend_fk) references venda(id_vend)
);

create table Faturamento(
id_fat int not null primary key auto_increment,
custo_exa_fat float,
data_reali_fat date,
data_cheg_fat date,
contas_pag float,
contas_rec float,
id_fin_fk int not null,
foreign key (id_fin_fk) references financeiro (id_fin)
);

create table Fat_vend (
id_vend_fat int not null primary key auto_increment,
id_vend_fk int not null,
id_fat_fk int not null,
foreign key (id_vend_fk) references venda (id_vend),
foreign key (id_fat_fk) references faturamento (id_fat)
);



##Atividade do procedimento e gatilhos
select * from funcionario;
delimiter $$
create procedure InserirFuncionario (atuacao varchar(200),cpf varchar(20),logradouro varchar(300),telefone int,numero int,cidade varchar(50),nome varchar(100),cep int)
begin
if(nome<>'') then
	if(cpf <>'') then
		select  'O cadastro de funcionario foi realizado com sucesso!!' as Confirmação;
		insert into funcionario values(null,atuacao,cpf,logradouro,telefone,numero,cidade,nome,cep);
	else 
		select 'o cpf deve ser fornecido' as Alerta;
	end if;
else
	select 'o nome deve ser fornecido' AS Alerta;
end if;
end;
$$ delimiter ;
select * from funcionario;
call InserirFuncionario('Vendedor','091.122.322.12','Avenida Cabral',699998723,00,'Cuiabá','Gustavo Safdo',09298767);
call InserirFuncionario('Vendedor','123.321.435.12','Avenida do Desespero',699998723,00,'Vilhena','Gabriek',09298767);
call InserirFuncionario('Vendedor','654.466.344.32','Avenida dos Bobos',699998723,00,'Ji-Paraná','Guilherme',09298767);

select * from usuario;
delimiter $$
create procedure InserirUsuario(funcionario int ,login varchar(100),senha varchar(50))
begin
declare test_func int;
set test_func=(select id_func from funcionario where id_func=funcionario);

if(test_func is not null)then
	if(login <> '')then
		insert into usuario values (null,funcionario,login,senha);
		select 'registro realizado com sucesso!!' as Confirmação;
    else
		select 'deve colocar o login' as Alerta;
	end if;
else
	select 'o funcionario não existe' as Alerta;
end if;
end;
$$ delimiter ;

call InserirUsuario(2,'matheustaylor@gmail.com','felizanatal2020');
call InserirUsuario(1,'joaopessoa@gmail.com','felizanatal2020');
call InserirUsuario(3,'matheustaylor@gmail.com','felizanatal2020');

select * from medico;
delimiter $$
create procedure InserirMedico (cpf varchar(20),RG varchar(25),nome varchar(100),logradouro varchar(300),cep int)
begin
if(nome<>'')then
	if(CPF <> '')then
		insert into medico values(null,cpf,RG,nome,logradouro,cep);
		select 'Registro realizado com sucesso!!' as Confirmação;
    else
		select 'cpf deve ser fornecido pelo medico' as Alerta;
    end if;
else
	select 'o nome do médico deve ser fornecido' as Alerta;
end if;
end;
$$ delimiter ;
select * from medico;
call InserirMedico('123.432.124.23','092.456.12','Jackson Bezerra','Vila dos Burgueses',092345);
call InserirMedico('123.432.124.23','092.456.12','Oliveira dos Anjos','Vila dos Anjos',534445);
call InserirMedico('123.432.124.23','092.456.12','Edson','Avenida Brasil',6752332);

select * from paciente;
delimiter $$
create procedure InserirPaciente(nome varchar(100),cep int ,tipo_sanguineo varchar(8) ,cpf varchar(20),data_de_nascimento date,logradouro varchar(300),numero int,rg varchar(30))
begin
if(nome <> '')then
	if(cpf <> '')then
		select 'O registro do paciente foi relizado com sucesso!!' as Confirmação;
        insert into paciente values(null,nome,cep,tipo_sanguineo,cpf,data_de_nascimento,logradouro,numero,rg);
	else 
		select 'o cpf deve ser fornecido' as Alerta;
    end if;
else
	select 'o paciente deve fornecer o nome' as Alerta;
end if;
end;
$$ delimiter ;
call InserirPaciente('Laura',24342,'B+','2342','2009-08-21','casa de esquina',09,'432.652.44');
call InserirPaciente('Manuel',1239873,'A-','123.432','2005-06-24','portão azul',298,'432.512.44');
call InserirPaciente('Rafael',1239873,'B-','123.432','2003-10-25','casa cor verde',9887,'432.098.34');

select * from Pedidos_pacientes;
delimiter $$

create procedure InserirPedido_pacientes(descricao varchar(200),tipo varchar(100),paciente int)
begin
declare test_pa int;
set test_pa=(select id_pa from paciente where id_pa=paciente);

if(tipo <> '')then
	if(test_pa is not null )then
		insert into pedidos_pacientes values(null,descricao,tipo,paciente);
        select 'O pedido do paciente foi realizado com sucesso' as Confirmação;
	else
		select 'O paciente não existe' as Alerta;
	end if;
else
		select 'O tipo do pedido deve ser fornecido' as Alerta;
end if;
end;
$$ delimiter ;

call InserirPedido_pacientes ('rubéula','sangue',12);
call InserirPedido_pacientes ('esquizofrenia','beta',2);
call InserirPedido_pacientes ('câncer de pulmão','sangue',3);
call InserirPedido_pacientes ('câncer de próstata','beta',3);

select * from pedidos_pacientes;
delimiter $$
create procedure InserirPedidosMedicos(medico int, pedido int)
begin
declare test_med,test_ped int;
set test_ped=(select id_ped from pedidos_pacientes where id_ped=pedido);
set test_med=(select id_med from medico where id_med=medico);

if(test_med is not null)then
	if(test_ped is not null)then
		select 'o registro foi realizado com sucesso!!' as Confirmação;
		insert into pedidos_medicos values(null,medico,pedido);
	else 
		select 'o pedido não existe' as Alerta;
	end if;
	else
		select 'o médico não existe' as Alerta;
end if;
end;
$$ delimiter ;

call InserirPedidosMedicos(2,1);
select * from medico;
select * from pedidos_pacientes;
select * from pedidos_medicos;
select * from venda;
select * from financeiro;
delimiter $$
create procedure InserirFinanceiro(data_de_entrega date,valor_liq float,valor_but float)
begin
if(valor_but > 0)then
	if(valor_liq > 0)then
		select 'O registro do financeiro foi realizado com sucesso!!' as Confirmação;
		insert into financeiro values(null,data_de_entrega,valor_liq,valor_but);
	else
		select 'valor inserido invalido favor insira outro' as Alerta;
	end if;
else
		select 'favor o valor correto' as Alerta;
end if;
end;
$$ delimiter ;

call InserirFinanceiro('2021-07-21','432.09','987.67');
call InserirFinanceiro('2020-05-11','432.09','987.67');
call InserirFinanceiro('2021-07-21','432.09','987.67');

delimiter $$
create procedure Inserirvenda(paciente int,data date,valor float,quantidade int,financeiro int)
begin
if(valor > 0)then
	if(quantidade > 0 )then
		select 'o registro foi realizado com sucesso!!' as Confirmação;
		insert into venda values(null,paciente,data,valor,quantidade,financeiro);
	else
		select 'a quantidade é menor que o permitido' as Alerta;
    end if;
else 
		select 'o valor informado é menor que o permitido' as Alerta;
end if;
end; 
$$ delimiter ;

call Inserirvenda(2,'2004-08-24',12,3,1);
call Inserirvenda(3,'2003-03-21',12,2,2);
call Inserirvenda(1,'2009-08-24',12,3,2);

select * from convenio;
select * from venda;
delimiter $$
create procedure Inserirconvenio(cnpj varchar (20),tipo varchar(100))
begin
if(cnpj <> '')then
	if(tipo = 'tipo empresarial')then
		select 'o registro foi realizado com sucesso' as Confirmação;
		insert into convenio values(null,cnpj,tipo);
	else
		if(tipo = 'tipo individual')then
			select 'o registro foi realizado com sucesso' as Confirmação;
			insert into convenio values(null,cnpj,tipo);
		else
			if(tipo = 'tipo coletivo')then
				select 'o registro foi realizado com sucesso' as Confirmação;
				insert into convenio values(null,cnpj,tipo);
			else
				if(tipo = 'tipo familiar')then
					select 'o registro foi realizado com sucesso' as Confirmação;
					insert into convenio values(null,cnpj,tipo);
							
				else
					select 'o tipo informado não existe' as Alerta;
				end if;
			end if;
		end if;
	end if;
else
	select 'o cnpj do cliente tem que ser informado' as Alerta;
end if;
end;
$$ delimiter ; 

call Inserirconvenio('892.432.098','tipo individual');
call Inserirconvenio('785.258.369','tipo coletivo');
call Inserirconvenio('951.753.468','tipo empresarial');
call Inserirconvenio('951.753.468','tipo familiar');

select * from convenio;
delimiter $$
create procedure InserirExames(exame varchar(100),resultado varchar(200),convenio int , pedidos int)
begin
declare test_conv,test_ped int;
set test_conv=(select id_conv from convenio where id_conv=convenio);
set test_ped=(select id_ped from pedidos_pacientes where id_ped=pedidos);

if(test_conv is not null)then
	if(test_ped is not null)then
		select 'O registro do exame foi realizado com sucesso!!' as Confirmação;
		insert into exame values(null,exame,resultado,convenio,pedidos);
	else
		select 'o pedido não existe favor inserir outro' as Alerta;
	end if;
else
    select 'o convenio não existe favor inserir outro' as Alerta;
end if;
end
$$ delimiter ;

select * from exame;
select * from convenio;
select * from pedidos_pacientes;
call InserirExames('exame de próstata','positivo',1,1);
call InserirExames('exame de costa','positivo',2,2);
call InserirExames('exame de próstata','negativo',3,3);
select * from venda;
select * from venda_exame;
select * from exame;

delimiter $$
create procedure InserirVendaExame(exame int , venda int)
begin
declare test_exa,test_vend int;
set test_exa=(select id_exa from exame where (id_exa=exame));
set test_vend=(select id_vend from venda where (id_vend=venda));

if(test_exa is not null)then
	if(test_vend is not null)then
		select 'O registro da venda do exame foi realizado com sucesso!!' as Confirmação;
        insert into venda_exame values(null,exame,venda);
	else
		select 'venda não existe!! favor selecione a venda  do exame' as Alerta;
    end if;
else
    select 'o exame não existe favor selecionar outro' as Alerta;
end if;
end

$$ delimiter ;

call InserirVendaExame(2,1);
call InserirVendaExame(2,3);
call InserirVendaExame(2,2);

select * FROM vend_func;
delimiter $$
create procedure InserirVendaFuncionario(funcionario int ,venda int)
begin
declare test_func,test_vend int;
set test_func=(select id_func from funcionario where (id_func=funcionario));
set test_vend=(select id_vend from venda where (id_vend=venda));
if(test_func is not null)then
	if(test_vend is not null)then
		select concat('O registro da venda do ',funcionario,' foi feita') as Confirmação;
		insert into vend_func values (null,funcionario,venda);
	else
		select 'a venda não existe' as Alerta;
    end if;
else 
    select 'o funcionario não existe' as Alerta;
end if;
end;
$$ delimiter ;

call InserirVendaFuncionario(2,1);

select * from financeiro;
select* from financeiro;
select * from faturamento;
select * from venda;
delimiter $$
create trigger AtualizarVenda after insert on venda for each row
begin
update financeiro set valor_brut=new.quant_exa * new.valor_exa where id_fin=new.id_fin_fk;
end;
$$ delimiter ; 
insert into venda values(null,2,'2021-05-20',100.00,4,1);

select * from venda;
select * from financeiro;
select * from pedidos_pacientes;
delimiter $$
create trigger AtualizarFinanceiro after insert on faturamento for each row
begin
update financeiro set valor_liq=new.contas_pag-valor_brut-new.contas_rec-new.custo_exa_fat where id_fin=new.id_fin_fk;
end;
$$ delimiter ;

select * from faturamento;
insert into faturamento values(null,'400.00','2021-05-23','2021-06-24',400,400,2);
select * from fat_vend;

delimiter $$
create procedure InserirFaturamento(custo float,data_real date,data_cheg date,contas float,contas_rec float,financeiro int)
begin
 insert into faturamento values(null,custo,data_real,data_cheg,contas,contas_rec,financeiro);
end;
$$ delimiter ;

call InserirFaturamento(150.00,'2021-07-23','2021-08-24',400.00,30.00,2);

delimiter $$
create procedure InserirFat(venda int ,faturamento int)
begin
declare test_vend,test_fat int;
set test_vend=(select id_vend from venda where (id_vend=venda));
set test_fat=(select id_fat from faturamento where (id_fat=faturamento));

if(test_vend is not null)then
	if(test_fat is not null)then
		select 'O registro foi realizado com sucesso!!' as Confirmação;
		insert into fat_vend values(null,venda,faturamento);
    else 
		select 'o faturamento não existe' as Alerta;
	end if;
		select 'a venda não existe' as Alerta;
end if;
end 
$$ delimiter ;

call InserirFat(1,2);
call InserirFat(2,2);
call InserirFat(3,2);