use Academy_3_11;

select *
from Students
where Name like 'A%';

update Students
set Age = 18
where Name like 'Arne'

delete from Students
where Name like 'Arne'

insert into Students values(N'Yusif', 15, N'yusifdestructor123@fortnite.com')
insert into Students(Name, Age, Email) values(N'Yusif', 15, N'yusifdestructor123@fortnite.com')

select * from Students
order by Age;


select COUNT(*) as StudentCount from Students;

select MAX(Age) from Students;

select MIN(Age) from Students;

select AVG(Age) from Students;

select SUM(Age) from Students;


select * from Students;

alter table Students
add Address nvarchar(50);

alter table Students
drop column Address;

alter table Students
alter column Name nvarchar(50);

select * from Students;

alter table Students
alter column Age float;

select * from Students;

alter table Students
alter column Age int;

-- add constraint to age
alter table Students
add check(Age > 0 and Age <= 100);




