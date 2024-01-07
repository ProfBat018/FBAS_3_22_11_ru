USE Academy_11;
GO;

CREATE VIEW [dbo].[StudentsView]
AS
    SELECT P.Name, S.GPA
    FROM Students as S
    INNER JOIN People AS P ON P.Id = S.PersonId
GO;


select * from StudentsView


update Students
set GPA = 4
where Id = 1


select * from StudentsView;

drop view StudentsView;

