/*
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

var connectionString = config.GetConnectionString("Default");

using SqlConnection conn = new(connectionString);

using SqlDataAdapter adapter = new("select * from People", conn);

var ds = new DataSet();
// DataSet - это класс, который хранит в себе таблицы
// DataTable - это класс, который хранит в себе строки и столбцы
// DataRow - это класс, который хранит в себе одну строку
// DataColumn - это класс, который хранит в себе один столбец


adapter.Fill(ds);

while (true)
{
    foreach (DataRow row in ds.Tables[0].Rows)
    {
        Console.WriteLine($"{row[0]}\t{row[1]}");
    }

    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine("Cleared");
}
*/



using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

var connectionString = config.GetConnectionString("Default");

using SqlConnection conn = new(connectionString);
using SqlDataAdapter adapter = new();
conn.Open();

adapter.InsertCommand = new("insert into People(Name, Surname, Age) values(N'Vaqif', N'Aliyev', 16);", conn);
adapter.UpdateCommand = new("update People set Name = N'Yusif', Surname = N'Bayramov', Age = 20 where Id = 1;", conn);

adapter.InsertCommand.ExecuteNonQuery();
adapter.UpdateCommand.ExecuteNonQuery();

adapter.SelectCommand = new("select * from People", conn);

var ds = new DataSet();

adapter.Fill(ds);

foreach (DataRow row in ds.Tables[0].Rows)
{
    Console.WriteLine($"{row[0]}\t{row[1]}");
}


