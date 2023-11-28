using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities.Interfaces;

interface ISoup : IMeal
{
    public int Litres { get; set; }
}
