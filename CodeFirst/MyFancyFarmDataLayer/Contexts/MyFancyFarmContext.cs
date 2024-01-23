using System;
using System.Collections.Generic;
using CodeFirst;
using Microsoft.EntityFrameworkCore;

namespace MyFancyFarmDataLayer;

public class MyFancyFarmContext : DbContext
{
    public MyFancyFarmContext()
    {
    }

    public MyFancyFarmContext(DbContextOptions<MyFancyFarmContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
    public DbSet<AnimalType> AnimalTypes { get; set; }
}
