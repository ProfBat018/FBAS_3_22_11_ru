using CodeFirst;
using Microsoft.EntityFrameworkCore;

using MyFancyFarmContext context = new();

#region Part1
/*
var animalTypes = new List<AnimalType>()
{
   new() {Name = "Mammal"},
   new() {Name = "Bird"},
   new() {Name = "Fish"}
};
context.AnimalTypes.AddRange(animalTypes);

context.SaveChanges();
*/
#endregion

#region Part2 

/*
 
var mammalId = context.AnimalTypes.First(x => x.Name == "Mammal").Id;
var birdId = context.AnimalTypes.First(x => x.Name == "Bird").Id;


// var animals = new List<Animal>()
// {
//    new() {Name = "Cow1", Age = 2, AnimalTypeId = mammalId},
//    new() {Name = "Cow2", Age = 1, AnimalTypeId = mammalId},
//    new() {Name = "Cow3", Age = 3, AnimalTypeId = mammalId},
//    new() {Name = "Cow4", Age = 1, AnimalTypeId = mammalId},
//    new() {Name = "Cow5", Age = 1, AnimalTypeId = mammalId}
// };

var animals = new List<Animal>()
{
   new() {Name = "Chicken1", Age = 2, AnimalTypeId = birdId},
   new() {Name = "Chicken2", Age = 1, AnimalTypeId = birdId},
   new() {Name = "Chicken3", Age = 3, AnimalTypeId = birdId},
   new() {Name = "Chicken4", Age = 1, AnimalTypeId = birdId},
   new() {Name = "Chicken5", Age = 1, AnimalTypeId = birdId}
};

context.Animals.AddRange(animals);

context.SaveChanges();

*/

#endregion


#region LinqToEntities
/*
var animals = 
              from animal in context.Animals
              where animal.Age > 1
              select animal;
   
foreach (var animal in animals)
{
   Console.WriteLine(animal.Name);
}
*/

// var animals = context.Animals.Where(x => x.Age > 1);
//
// foreach (var animal in animals)
// {
//    Console.WriteLine(animal.Name);
// }


// var animals = context.Animals
//    .Include(x => x.AnimalType)
//    .Where(x => x.Age > 1);
//
// foreach (var animal in animals)
// {
//    Console.WriteLine(animal.AnimalType.Name);
// }
//

// var animals = context.Animals.AsEnumerable();
//
// var res = animals.Aggregate(animals, (current, animal) =>
// {
//    animal.Name = animal.Name + "1";
//       return current;
// });
//
// foreach (var animal in res)
// {
//    Console.WriteLine(animal.Name);
// }



#endregion


