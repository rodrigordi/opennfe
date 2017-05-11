alter table NotasFiscais
add versao int null default 1
go

update NotasFiscais
set versao = 1
go
