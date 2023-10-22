use Supermarker
create table Product
(
Product_Id int identity (100000,1) primary key,
Product_Name nvarchar (50) not null,
Product_Observation nvarchar (50) not null,
)
go
insert into Product values('Galleta', 'Galleta Mode')
insert into Product values('Bonbones', 'Bonbones mode')