using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

// тот самый паттерн builder
var builder = new ConfigurationBuilder();

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

var connectionString = config.GetConnectionString("Default");

using SqlConnection conn = new(connectionString);

SqlCommand command = new("select * from People", conn);

conn.Open();

{
    using SqlDataReader reader = command.ExecuteReader(); // ExecuteReader - это метод,
    // который использутеся для чтения
    // из таблицы, то есть select 

    while (reader.Read())
    {
        var id = reader.GetInt32(0);
        Console.WriteLine($"{reader[0]}\t{reader[1]}");
    }
}

command = new SqlCommand("insert into People(Name, Surname, Age) values(N'Baxa', N'Mirzayev', 17);", conn);

var res = command.ExecuteNonQuery();

Console.WriteLine(res);

