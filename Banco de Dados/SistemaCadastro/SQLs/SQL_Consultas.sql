select * 
from pessoa;

select * 
from convenio;

select * 
from endereco;

select *
from pessoa as p
join endereco as e
	on p.id = e.id_pessoa;
select * from endereco;

SELECT id as ID, nome as Nome, cgccpf as CGCCPF, tipopessoa as TipoPessoa, flstatus as Status from pessoa