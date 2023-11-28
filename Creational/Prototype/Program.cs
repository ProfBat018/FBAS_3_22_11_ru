Car c1 = new()
{
    Make = "Cadillac",
    Model = "Escalade",
    Engine = new Engine()
    {
        Volume = 6,
        HP = 300
    }
};

Car c2 = c1.Clone() as Car;

c2.Make = "Ford";
c2.Engine.Volume = 1;

Console.WriteLine($"C2 is: {c2}");
Console.WriteLine($"C1 is: {c1}");


class Car : ICloneable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public object Clone()
    {
        return new Car
        {
            Make = Make,
            Model = Model,
            Engine = new() { Volume = Engine.Volume, HP = Engine.HP }
        };
    }

    public override string ToString()
    {
        return $"{Make} {Model} {Engine}";
    }
}

class Engine {
    public int Volume { get; set; }
    public int HP { get; set; }

    public override string ToString()
    {
        return $"{Volume} {HP}";
    }
}

