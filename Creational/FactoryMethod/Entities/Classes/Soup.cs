using FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities.Classes;

internal class Soup : ISoup
{
    public int Litres { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
    public int Calories { get; set; }
}
