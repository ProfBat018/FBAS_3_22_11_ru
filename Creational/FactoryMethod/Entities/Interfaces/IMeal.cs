using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities.Interfaces;

interface IMeal
{
    public string Name { get; set; }
    public int Calories { get; set; }
}
