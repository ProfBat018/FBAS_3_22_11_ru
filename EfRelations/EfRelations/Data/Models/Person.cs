using System;
using System.Collections.Generic;

namespace EfRelations;

public class Person: IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Age { get; set; }

    public ICollection<Student> Students { get; set; } = new List<Student>();

    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
