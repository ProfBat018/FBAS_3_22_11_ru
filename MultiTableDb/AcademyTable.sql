use Academy2;

create table People(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL,
[Surname] nvarchar(30) NOT NULL,
[Email] nvarchar(30) NOT NULL UNIQUE,
[Age] int NOT NULL check ([Age] >= 14 and [Age] <= 100)
);


create table Employees(
[Id] int primary key identity(1, 1),
[Salary] smallmoney check ([Salary] >= 300) NOT NULL,
[Experience] int NOT NULL check([Experience] > 0)
);


create table Faculties(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL
);

create table Students(
[Id] int primary key identity(1, 1),
[PersonId] int foreign key references People(Id)
);

create table Teachers(
[Id] int primary key identity(1, 1),
[PersonId] int foreign key references People(Id),
[EmployeeId] int foreign key references Employees(Id)
);

create table Groups(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL,
[Course] int NOT NULL check([Course] >= 1 and [Course] <= 6),
[FacultyId]  int foreign key references Faculties(Id)
);


create table GroupsData(
[Id] int primary key identity(1, 1),
[StudentId] int foreign key references Students(Id),
[GroupId] int foreign key references Groups(Id)
);


create table StudyPlans(
[Id] int primary key identity(1, 1),
[TeacherId] int foreign key references Teachers(Id),
[GroupId] int foreign key references Groups(Id)
);

alter table Students
add [GPA] int NOT NULL check ([GPA] >= 1 and [GPA] <= 12);


insert into People([Name], [Surname], [Age], [Email]) values (N'Baxa', N'Mirzayev', 17, N'baxathebest@gmail.com');
insert into People([Name], [Surname], [Age], [Email]) values (N'Maqa', N'Farmanov', 23, N'maqalezgin05@salam.aleykum');
insert into People([Name], [Surname], [Age], [Email]) values (N'Afqan', N'Maksudlu', 16, N'afqan@daewoo.kr');

select * from People;
insert into Students values(4, 9);
insert into Students values(5, 12);
insert into Students values(6, 9);

 
 select * from Students;

 select Students.Id, People.Name, People.Surname, People.Email, People.Age, Students.GPA
 from Students
 inner join People on Students.PersonId = People.Id
 where Students.Id = 6



