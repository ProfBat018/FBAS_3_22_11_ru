using Loadings;
using Microsoft.EntityFrameworkCore;

using AcademyContext context = new();


// var student = context.Students.First();
//
// context.Entry(student)
//     .Reference(x => x.Person)
//     .Load();
//
// // Кинул ссылку от студента к человеку и подгрузил человека
// Console.WriteLine(student.Person.Name);


var person = context.People.First();

context.Entry(person)
    .Collection(x => x.Students)
    .Load();

// Кинул ссылку от человека к студентам и подгрузил студентов

foreach (var student in person.Students)
{
    Console.WriteLine(student.Person.Name);
}

