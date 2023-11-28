using FactoryMethod.Entities.Classes;
using FactoryMethod.Entities.Interfaces;
using FactoryMethod.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories.Classes;

internal class SoupFactory : IMealFactory
{
    public IMeal CreateMeal()
    {
        ISoup soup = new Soup()
        {
            Name = "Chicken Soup",
            Calories = 200,
            Litres = 1,
        };

        return soup;
    }
}
