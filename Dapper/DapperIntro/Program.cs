using System.Data;
using System.Data.SqlClient;
using System.Threading.Channels;
using Dapper;
using DapperIntro;

string connString = "Data Source=localhost;Initial Catalog=Academy;User Id=sa;Password=Elvin123";

using IDbConnection connection = new SqlConnection(connString);

connection.Open();

#region ExecuteMany

// var sql = "select * from Students";
//
// var res = connection.Query<Student>(sql);
//
// foreach (var student in res)
// {
//     Console.WriteLine($"Id: {student.Id}");
// }

#endregion

#region ExecuteOne

// var sql = "select * from Students where Id = 1";

// var res = connection.QuerySingle<Student>(sql);

// Console.WriteLine(res.Id);

#endregion

#region ExecuteScalar

// var sql = "select count(*) from Students";

// var res = connection.ExecuteScalar<int>(sql);

// Console.WriteLine(res);

#endregion

#region ExecuteNonQuery

// var sql = "insert into People (Name, Surname, Age) values (@Name, @Surname, @Age)";
//
// var person = new Person()
// {
//     Name = "Maqa",
//     Surname = "Lezgin",
//     Age = 23
// };
//
// var res = connection.Execute(sql, person);
//
// Console.WriteLine($"Inserted {res} rows");

#endregion

#region ExecuteWithJoins

// var sql = """
//             select * from Students s 
//             inner join People p on s.Id = p.Id
//           """;
//           
// var res = connection.Query<Student, Person, Student>(sql, (student, person) =>
// {
//     student.Person = person;
//     return student;
// }, splitOn: "Id");
//
// foreach (var student in res)
// {
//     Console.WriteLine($"Student: {student.Id} {student.Person.Name} {student.Person.Surname} {student.Person.Age} {student.Gpa}");
// }

#endregion

#region ExecuteWithMultipleJoins

// var sql = """
//             select * from GroupData gd
//             inner join Groups g on gd.GroupId = g.Id
//             inner join Faculty f on g.FacultyId = f.Id
//           """;
//
// var res = connection.Query<GroupDatum, Group, Faculty, GroupDatum>(sql, 
//     (datum, group, faculty) => {
//         datum.Group = group;
//         group.Faculty = faculty;
//         return datum;
//     }, splitOn: "Id, Id");
//
//
// foreach(var datum in res)
// {
//     Console.WriteLine($"GroupDatum: {datum.Id} {datum.GroupId} {datum.StudentId} {datum.Group.Name} {datum.Group.Faculty.Name}");
// }

#endregion

#region DbString
//
// var sql = "select * from People where Name = @Name";
//
// Console.WriteLine("Enter name: ");
// var name = Console.ReadLine();
//
//
// var res = connection.Query<Person>(sql,
//     new
//     {
//         Name = new DbString()
//         {
//             Value = name, IsFixedLength = true, Length = name.Length
//         }
//     });
//
//
// foreach (var person in res)
// {
//     Console.WriteLine($"Person: {person.Id} {person.Name} {person.Surname} {person.Age}");
// }

#endregion
