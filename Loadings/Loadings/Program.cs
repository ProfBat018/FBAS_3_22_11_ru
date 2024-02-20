using Loadings;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

//using var context = new Academy2Context();

//var people = context.People.AsNoTracking();

//people.First(p => p.Name == "Baxa").Name = "Baxa123";

//context.SaveChanges();


// Lazy loading 

//using var context = new Academy2Context();

//var students = context.Students.ToList();

//foreach (var student in students)
//{
//    Console.WriteLine(student.Person.Name);
//}


// Eager loading 

using var context = new Academy2Context();

var students = context.GroupsData
    .Include(x => x.Group)
    .ThenInclude(x => x.Faculty);

foreach (var student in students)
{
    Console.WriteLine(student.Person.Name);
}


