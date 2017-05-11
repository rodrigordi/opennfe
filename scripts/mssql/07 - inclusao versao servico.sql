alter table ServicosPendentes
add versao int null default 1
go

update ServicosPendentes
set versao = 1
go
