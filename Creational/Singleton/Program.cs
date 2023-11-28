
var car = SingletonManager.CreateSingleton<Car>();

car.Make = "Cadillac";
car.Model = "Escalade";
Console.WriteLine(car);

var car2 = SingletonManager.CreateSingleton<Car>();

car2.Make = "Ford";

Console.WriteLine(car);
Console.WriteLine(car2);


static class SingletonManager
{
    private static object? _instance;
    public static T CreateSingleton<T>()
    {
        if (_instance is null)
            _instance = Activator.CreateInstance<T>();
        return (T)_instance;
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}






