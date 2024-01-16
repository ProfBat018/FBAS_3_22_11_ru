using System;
using System.Collections.Generic;

namespace DbFirst;

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; } 

    public int Age { get; set; }

    public ICollection<Student> Students { get; set; } = new List<Student>();

    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
