create table #TempTable
(
    Id int primary key identity(1,1),
    Name varchar(50),
    GPA float
)
go;

declare @i int = (select count(*) from Students)
declare @j int = (select top 1 id from Students);

while @i <> @j
begin
    insert into #TempTable (Name, GPA)
    values(
           (select Name
            from Students as S
            inner join People as P on P.Id = S.PersonId
            where S.Id = @j),
           (select GPA
            from Students as S
            where S.Id = @j));

    set @j = @j + 1;
end

go;

select * from #TempTable;


