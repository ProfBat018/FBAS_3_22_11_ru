# Тема урока: SOLID

По началу SOLID была всего лишь парадигма, как например:
* KISS - Keep It Simple, Stupid
* DRY - Don't Repeat Yourself
* YAGNI - You Aren't Gonna Need It


## SOLID - Как смысл жизни в ООП
* **S**ingle responsibility principle (Принцип единственной ответственности)
* **O**pen-closed principle (Принцип открытости/закрытости)
* **L**iskov substitution principle (Принцип подстановки Барбары Лисков)
* **I**nterface segregation principle (Принцип разделения интерфейса)
* **D**ependency inversion principle (Принцип инверсии зависимостей)

По истечению времени он настолько прижился, что его пишут в вакансиях.

## Single responsibility principle (Принцип единственной ответственности)
Запоминаем раз и навсегда - любая сущность должна отвечать за одно действие

Сущность - метод, класс, структура, интерфейс, делегат и т.д.

Как не надо делать: 
```csharp
class ContactManager 
{
    public List<Contact> Contacts { get; set; }
    
    public void AddContact(Contact contact) {
        Contacts.Add(contact);
        
        using FileStream fs = new("data.txt", FileMode.OpenOrCreate);
        using StreamWriter sw = new(fs);
        sw.WriteLine(contact);
    }
}
```

## Open-closed principle (Принцип открытости/закрытости)
Запоминаем раз и навсегда - сущность должна быть открыта для расширения, но закрыта для модификации.
Простыми словами - можно добавить код, старый менять можно но только осторожно.

## Liskov substitution principle (Принцип подстановки Барбары Лисков)
Запоминаем раз и навсегда - При смене наследника базовый класс должен оставаться работоспособным.

Сразу пример:
```csharp

// Transport t1 = new Car();
Rectangle rectangle = new Square();

rectangle = new Romb();


class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
}

class Romb : Rectangle
{
    public new int Width
    {
        set => base.Width = base.Height = value;
    }

    public new int Height
    {
        set => base.Width = base.Height = value;
    }
}

class Square : Rectangle
{
    public new int Width
    {
        set => base.Width = base.Height = value;
    }

    public new int Height
    {
        set => base.Width = base.Height = value;
    }
}

```

## Interface segregation principle (Принцип разделения интерфейса)
Запоминаем раз и навсегда - Много специализированных интерфейсов лучше, чем один универсальный.
Если в вашем интерфейсе к примеру 10 методов, есть вариант, что не все классы будут реализовывать все методы.
Говорю лично со своего опыта. Иногда мы даже создаем пустые интерфейсы. Но это уже другая история. Ни в 
коем случае не создавайте большие интерфейсы !!! 

## Dependency inversion principle (Принцип инверсии зависимостей)
Что нужно знать ? Никакой класс высшего уровня не должен зависеть от класса нижнего уровня. 
К примеру, если у вас есть класс который работает с контактами, то при смене класса `Contact`
надо сделать так, чтобы мы не трогали класс `ContactManager` для этого нужно использовать
интерфейсы, абстрактные классы, делегаты и т.д.

Дл примера мы напишем программу, которая берет данные по прогнозу погоды из интренета и выводит их на экран.
Потом мы сделаем `refactoring` и вынесем логику в отдельный класс, соблюдая принципы SOLID.





