﻿use Supermarker

create table Categorie 

(

Categorie_Id int identity (100000, 1) primary key,
Categorie_Name nvarchar (50) not null,
Categorie_Observation nvarchar (50) not null,
)

go

insert into Categorie values ('Jabon', 'Aseo')
insert into Categorie values ('Aguardiente', 'Licores')