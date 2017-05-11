alter table parametros
add tempoEspera int null default 1
go

update parametros 
set tempoEspera = 1
go