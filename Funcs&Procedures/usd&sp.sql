create procedure sp_test
as
begin
    select P.Name, S.GPA, P.Age from Students as S
    inner join dbo.People P on P.Id = S.PersonId
end

go;

create function fn_test()
returns table
as
return
(
    select P.Name, S.GPA, P.Age from Students as S
    inner join dbo.People P on P.Id = S.PersonId
)

go;

exec sp_test;

go;

select * from fn_test();

go;

create procedure sp_test2
    @name nvarchar(30),
    @age int,
    @info nvarchar(50) output
as
begin
    set @info = Concat(@name, N' ', cast(@age as nvarchar(50)))
end

go;

declare @result nvarchar(50);
declare @name nvarchar(30) =
    (select top 1 Name from Students
     inner join dbo.People P on P.Id = Students.PersonId);

exec sp_test2 @name = @name, @age = 20, @info = @result output

select @result;

go;





