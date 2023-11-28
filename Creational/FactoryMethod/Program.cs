// Фабричный метод 

using FactoryMethod.Entities.Interfaces;
using FactoryMethod.Factories.Classes;
using FactoryMethod.Factories.Interfaces;


IMealFactory factory = new FruitFactory();


var fruit = factory.CreateMeal() as IFruit;

Console.WriteLine($"Name: {fruit.Name}");


factory = new SoupFactory();

var soup = factory.CreateMeal() as ISoup;

Console.WriteLine($"Name: {soup.Name}");



