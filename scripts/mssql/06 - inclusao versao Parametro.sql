alter table Parametros
add versao int null default 1
go

update Parametros
set versao = 1
go
