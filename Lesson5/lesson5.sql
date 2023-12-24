use Academy_11;

create table dbo.Employee
(
    Id         int identity
        primary key,
    Salary     smallmoney not null
        check ([Salary] >= 300),
    Experience int        not null
        check ([Experience] >= 0)
)
go

create table dbo.Faculty
(
    Id   int identity
        primary key,
    Name nvarchar(30) not null
)
go

create table dbo.Groups
(
    Id        int identity
        primary key,
    Name      nvarchar(30) not null,
    Course    int          not null
        check ([Course] >= 1 AND [Course] <= 6),
    FacultyId int
        references dbo.Faculty
)
go

create table dbo.People
(
    Id      int identity
        primary key,
    Name    nvarchar(30) not null,
    Surname nvarchar(30) not null,
    Age     int          not null
        check ([Age] >= 14 AND [Age] < 100)
)
go

create table dbo.Students
(
    Id       int identity
        primary key,
    PersonId int
        references dbo.People,
    GPA      int
        constraint GPA_default default 0.0
        check ([GPA] >= 0 AND [GPA] <= 12)
)
go

create table dbo.GroupData
(
    Id        int identity
        primary key,
    StudentId int
        references dbo.Students,
    GroupId   int
        references dbo.Groups
)
go

create table dbo.Teachers
(
    Id         int identity
        primary key,
    PersonId   int
        references dbo.People,
    EmployeeId int
        references dbo.Employee
)
go

create table dbo.StudyPlan
(
    Id        int identity
        primary key,
    TeacherId int
        references dbo.Teachers,
    GroupId   int
        references dbo.Groups
)
go




-- Insert data into dbo.Employee
INSERT INTO dbo.Employee (Salary, Experience) VALUES
(500, 2),
(1000, 5),
(800, 3),
(1200, 7),
(600, 1),
(900, 4),
(1100, 6),
(700, 2),
(950, 5),
(850, 3);

-- Insert data into dbo.Faculty
INSERT INTO dbo.Faculty (Name) VALUES
('Science'),
('Arts'),
('Engineering'),
('Business'),
('Medicine'),
('Social Sciences'),
('Law'),
('Computer Science'),
('Education'),
('Fine Arts');

-- Insert data into dbo.Groups
INSERT INTO dbo.Groups (Name, Course, FacultyId) VALUES
('Group1', 1, 1),
('Group2', 2, 2),
('Group3', 3, 3),
('Group4', 4, 4),
('Group5', 5, 5),
('Group6', 6, 6),
('Group7', 1, 7),
('Group8', 2, 8),
('Group9', 3, 9),
('Group10', 4, 10);

-- Insert data into dbo.People
INSERT INTO dbo.People (Name, Surname, Age) VALUES
('John', 'Doe', 25),
('Alice', 'Smith', 30),
('Bob', 'Johnson', 22),
('Emily', 'Williams', 28),
('Michael', 'Brown', 35),
('Sophia', 'Jones', 21),
('David', 'Miller', 32),
('Emma', 'Davis', 24),
('Daniel', 'Wilson', 29),
('Olivia', 'Moore', 27);

-- Insert data into dbo.Students
INSERT INTO dbo.Students (PersonId, GPA) VALUES
(1, 3),
(2, 4),
(3, 2),
(4, 3),
(5, 3),
(6, 4),
(7, 2),
(8, 3),
(9, 4),
(10, 3);

-- Insert data into dbo.GroupData
INSERT INTO dbo.GroupData (StudentId, GroupId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

-- Insert data into dbo.Teachers
INSERT INTO dbo.Teachers (PersonId, EmployeeId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

-- Insert data into dbo.StudyPlan
INSERT INTO dbo.StudyPlan (TeacherId, GroupId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);


select * from Students
union all
select * from Teachers

insert into People (Name, Surname, Age) values ('John', 'Doe', 25)

select distinct Name from People


