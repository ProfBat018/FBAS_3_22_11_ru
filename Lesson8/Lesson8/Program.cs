#region FirstExample

/*

// Showroom<string> sh = new();

// Showroom<Transport> sh1 = new();
// Showroom<Car> sh2 = new();
// Showroom<Scooter> sh3 = new();
//
//
//
// class Showroom<T> where T: Transport, new()
// {
//     public List<T> Stock { get; set; } = new();
// }
//
// class Transport
// {
//     public string Make { get; set; }
//     public string Model { get; set; }
// }
//
//
// class Car : Transport
// {
//     public int Doors { get; set; }
//     public int Wheels { get; set; }
// }
//
// class Scooter : Transport
// {
//     public int Wheels { get; set; }
// }

*/


#endregion

#region SecondExample

// ClassRoom<Student> cs1;
// ClassRoom<Teacher> cs2;

/*
ClassRoom<ILearnable> cs3 = new();


cs3.Add(new Student());
cs3.Add(new Teacher());


class ClassRoom<T> where T : ILearnable
{
    private List<T> Students = new();
    
    public void Add(T student)
    {
        Students.Add(student);
    }
}

interface ILearnable
{
    void Learn();
}

class Student : ILearnable
{
    public string Name { get; set; }
    public void Learn()
    {
        Console.WriteLine("Student is learning");
    }
}

class Teacher : ILearnable
{
    public void Learn()
    {
        throw new NotImplementedException();
    }
}
*/
#endregion


// Возвращает void. Не принимает параметров
Action a = () => Console.WriteLine("Hello");

// Возвращает void. Принимает один параметр типа int
Action<int> b = (int x) => Console.WriteLine(x);

// Прием двух параметров типа int и возвращает bool
Func<int, int, bool> c = (int x, int y) => ((x + y) % 2 == 0);

// Возвращает bool. Принимает один параметр типа int
Predicate<int> d = (int x) => (x % 2 == 0);

Predicate<string> e = (string x) => (x.Length > 5);

List<int> nums = new() {1, 2, 3, 4, 5};

var res= nums.Where((x, y) => x > y).ToList();



// string name = "Elvin";
// string surname = "Azimov";
//
// name.CheckLength(surname);
// StringExtensions.CheckLength(name, surname);
//
// static class StringExtensions
// {
//     public static bool CheckLength(this string data, string other)
//     {
//         if (data.Length != other.Length)
//             return false;
//         return true;
//     }
// } 

// delegate T MyDelegate<out T>(T a);




