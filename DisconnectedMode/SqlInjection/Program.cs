using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();

Console.WriteLine("Enter your surname: ");
var surname = Console.ReadLine();

Console.WriteLine("Enter your age: ");
var age = Console.ReadLine();

ConfigurationBuilder builder = new();
builder.AddJsonFile("appsettings.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("Default");

using SqlConnection conn = new(connectionString);

conn.Open();

var parameters = new[]
{
    new SqlParameter("@Name", name),
    new SqlParameter("@Surname", surname),
    new SqlParameter("@Age", age)
};

using SqlCommand command = 
    new($"insert into People(Name, Surname, Age) values(@Name, @Surname, @Age)",conn);

command.Parameters.AddRange(parameters);

command.ExecuteNonQuery();



