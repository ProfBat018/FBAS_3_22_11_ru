#region ParseExact

// using System.Globalization;

// ParseExact

// DateTime time = DateTime.Parse("9/3/2023");
//Console.WriteLine(time.Date.DayOfYear);

// DateTime time = DateTime.ParseExact("03/09/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(time.Date.DayOfYear);

#endregion

#region TryFormat

/*
using System.Runtime.Serialization;

var time = DateTime.Now; // сегодняшняя дата

DateTimeFormat format = new DateTimeFormat("dd/MM/yyyy"); // формат даты, в котором я хочу ее вывести

int res; // количество символов, которое заняла дата

// Span - это структура, которая позволяет работать с буфером, как с массивом
// От массива она отличается тем, что не хранит в себе данные, а просто ссылается на них
// Про Span можно почитать тут: https://www.linkedin.com/pulse/span-vs-array-performance-c-bhaumik-patel#:~:text=Net%20Core%20%7C%20Microservice%20%7C%20Azure%E2%80%A6&text=Span%20and%20array%20are%20both,is%20a%20container%20of%20memory.

Span<char> span = new Span<char>(new char[10]); // буфер, в который будет записана дата

bool result = time.TryFormat(span, out res, format.FormatString); //

if (result)
{
    Console.WriteLine(span.Slice(0, res).ToString());
}
*/

#endregion

#region DynamicPolymorphism

/*
abstract class Transport
{
    public virtual void Move()
    {
        Console.WriteLine("Transport is moving");
    }
    public abstract void Stop();

    public virtual string Make { get; set; }
    public abstract string Model { get; set; }
}


class Car : Transport
{
    private string _make;
    public override string Make { get => "Aloha"; set => _make = value; }

    public override string Model { get; set; }


    public override void Stop()
    {
        Console.WriteLine("Car is stopped");
    }
}
*/

#endregion


Animal a1 = new() { Name = "Rax", Breed = "German Shepherd" };
Animal a2 = new() { Name = "Rax", Breed = "German Shepherd" };

Console.WriteLine(a1.Equals(a2));


class Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is Animal) // obj.getType() == typeof(Animal)
        {
            Animal tmp = obj as Animal;
            
            return Name == tmp.Name && Breed == tmp.Breed;
        }
        return false;
    }
}