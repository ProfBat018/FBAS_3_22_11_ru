namespace Serialization;

[Serializable] // Нужен только для бинарной сериализации
public class Person
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    
    public Person(string name, string surname)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Surname = surname;
    }

    public Person()
    {
        
    }
    
    public override string ToString()
    {
        return $"{Name} {Surname}";
    }
    
}