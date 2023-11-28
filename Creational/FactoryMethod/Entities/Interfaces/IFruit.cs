using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities.Interfaces;


interface IFruit : IMeal
{
    public string Color { get; set; }
}


