using FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories.Interfaces;

interface IMealFactory
{
    public IMeal CreateMeal();
}
