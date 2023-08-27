using System.Dynamic;
using Lesson2.Interfaces;

namespace Lesson2.Classes;

class Car : IDrivable
{
    public string Make { get; init; }    
    public string Model { get; init; }
    public DateTime DateOfManufacture { get; init; }

    public int Year
    {
        get
        {
            if (DateTime.Now.Month < DateOfManufacture.Month)
            {
                return DateTime.Now.Year - DateOfManufacture.Year - 1;
            }
            else if (DateTime.Now.Month == DateOfManufacture.Month && DateTime.Now.Day < DateOfManufacture.Day)
            {
                return DateTime.Now.Year - DateOfManufacture.Year - 1;
            }
            else
            {
                return DateTime.Now.Year - DateOfManufacture.Year;
            }
        }
    }

    public Car()
    {
        
    }
    public Car(string make, string model, DateTime dateOfManufacture)
    {
        Make = make;
        Model = model;
        DateOfManufacture = dateOfManufacture;
    }

    public string Path { get; set; }

    public void Drive()
    {
        Console.WriteLine("Car driving...");
    }
}
