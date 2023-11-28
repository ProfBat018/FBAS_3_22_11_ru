using FactoryMethod.Entities.Classes;
using FactoryMethod.Entities.Interfaces;
using FactoryMethod.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories.Classes;

class FruitFactory : IMealFactory
{
    public IMeal CreateMeal()
    {
        IFruit fruit = new Fruit()
        {
            Name = "Apple",
            Calories = 100,
            Color = "Red"
        };

        return fruit;
    }
}
