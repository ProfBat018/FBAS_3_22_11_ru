using FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities.Classes;

class Fruit : IFruit
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public string Color { get; set; }
}
