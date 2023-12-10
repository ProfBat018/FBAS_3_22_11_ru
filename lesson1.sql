create database Academy_3_11;
go;

use Academy_3_11;

create table Students(
    Id int primary key identity(1, 1),
    Name nvarchar(30) NOT NULL,
    Surname nvarchar(30) NOT NULL,
    Email nvarchar(50)
);
go;


drop table Students;
go;


insert into Students values(N'Elvin', N'Azimov', N'profbat018@gmail.com');
insert into Students(name, surname, email) values (N'Anver', N'Mamedov', N'anver123@gmail.com');


go;

select *
from Students

go;

select *
from Students
where Name = 'Elvin';






