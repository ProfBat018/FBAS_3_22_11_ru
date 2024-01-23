using System.Data.Common;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder = new();

builder.AddJsonFile("appsettings.json");

var config = builder.Build();
var connectionString = config.GetConnectionString("Default");





