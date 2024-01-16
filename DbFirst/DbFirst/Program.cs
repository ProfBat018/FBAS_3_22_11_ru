using DbFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

DbContextOptions<AcademyContext> configureOptoins(string dbName)
{
    var configBuilder = new ConfigurationBuilder();
    configBuilder.AddJsonFile("appsettings.json");

    var config = configBuilder.Build();
    var connectionString = config.GetConnectionString(dbName);

    var dbContextOptionsBuilder = new DbContextOptionsBuilder<AcademyContext>();

    return dbContextOptionsBuilder.UseSqlServer(connectionString).Options;
}

var options = configureOptoins("Default");

using var context = new AcademyContext(options);

// var people = context.People.Where(x => x.Age >= 18);
//
// Console.WriteLine(people.ToQueryString());
//
// foreach (var item in people)
// {
//     Console.WriteLine($"{item.Id} {item.Name} {item.Age}");
// }



// var people = context.People;
//
// Console.WriteLine(people.ToQueryString());
// var peopleRes = people.ToList().Where(x => x.Age >= 18);
//
//
// foreach (var item in peopleRes)
// {
//     Console.WriteLine($"{item.Id} {item.Name} {item.Age}");
// }

//
// var people = context.People
//     .Select(x => new {x.Name, x.Age})
//     .Where(x => x.Age >= 18);
//
// Console.WriteLine(people.ToQueryString());
//
// foreach (var item in people)
// {
//     Console.WriteLine($"{item.Name} {item.Age}");
// }




