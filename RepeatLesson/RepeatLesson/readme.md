# Тема урока: Повторение
* Файлы + 
* Boxing + 
* Unboxing + 
* Generic + 
* LINQ + 
* Exceptions


## Вопросы к повторению:
1. Рефлексия
2. Встроеннын интерфейсы
3. LINQ
4. StringBuilder
5. Отличие абстрактного класса от интерфейса
6. Top level statements
7. IL Code



## Рефлексия - это способность сущность(класс или структура) брать информацию о себе.

## Список часто используемых встроенных интерфейсов:
1. IComparable - интерфейс, который позволяет сравнивать объекты между собой.
2. IComparer - интерфейс, который позволяет сравнивать объекты между собой.
3. IEnumerable - интерфейс, который позволяет перебирать объекты.
4. IEnumerator - итератор
5. ICloneable - интерфейс, который позволяет клонировать объекты.
6. IFormattable - интерфейс, который позволяет форматировать объекты.
7. IConvertible - интерфейс, который позволяет преобразовывать объекты.
8. IDisposable - интерфейс, который позволяет освобождать ресурсы.

#### IComparable
Позволяет сравнивать объекты между собой. 
По сути он точно такой же как встроенный метод Equals, но он нужен для того, 
чтобы сравнивать объекты разного типа между собой.

```csharp

public class Person : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(object obj)
    {
        if (obj is Person person) 
        {
            return Age.CompareTo(person.Age);
        }
        else
        {
            throw new Exception("Невозможно сравнить два объекта");
        }
    }
}

```

#### IComparer
Позволяет сравнивать объекты между собой.

Отличие от IComparable в том, что IComparer позволяет сравнивать объекты одного типа между собой.

```csharp

class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}

```

Вы спросите, смысл в IComarable или IComparer, если есть встроенный метод equals или оператор ==.

1. Если вы хотите сравнить объекты по какому-то своему алгоритму, то вам нужно реализовать IComparable или IComparer.
Но веь можно перегрузить оператор == и Equals. Тут нам поможет знание того зачем нужны интерфейсы.

Есть встроенные методы, которые не принимают конкретные тип, а принимают интерфейс. По сути вы не сможете 
передать свой тип в такой метод, а Generic интерфейс позволяет это сделать.

```csharp

void foo<T>(IComparable<T> comparable)
{
    // ...
}

```
Как пример такого встроенного метода можно привести метод Sort класса Array.
Или OrderBy класса Enumerable.

## IFormattable

Позволяет форматировать объекты.

```csharp

Person person = new() { Name = "Tom", Age = 23 };

Console.WriteLine(person.ToString("N", null)); // Tom

public class Person : IFormattable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string ToString(string format, IFormatProvider formatProvider)
    {
        if (format == "N")
        {
            return Name;
        }
        else if (format == "A")
        {
            return Age.ToString();
        }
        else
        {
            return ToString();
        }
    }
}
```

## IConvertible

Позволяет преобразовывать объекты.

```csharp

Person person = new() { Name = "Tom", Age = 23 };

public class Person : IConvertible
{
    public string Name { get; set; }
    public int Age { get; set; }

    public TypeCode GetTypeCode()
    {
        return TypeCode.Object;
    }

    public bool ToBoolean(IFormatProvider provider)
    {
        return true;
    }

    public byte ToByte(IFormatProvider provider)
    {
        return 0;
    }

    public char ToChar(IFormatProvider provider)
    {
        return ' ';
    }

    public DateTime ToDateTime(IFormatProvider provider)
    {
        return DateTime.Now;
    }

    public decimal ToDecimal(IFormatProvider provider)
    {
        return 0;
    }

    public double ToDouble(IFormatProvider provider)
    {
        return 0;
    }

    public short ToInt16(IFormatProvider provider)
    {
        return 0;
    }

    public int ToInt32(IFormatProvider provider)
    {
        return 0;
    }

    public long ToInt64(IFormatProvider provider)
    {
        return 0;
    }

    public sbyte ToSByte(IFormatProvider provider)
    {
        return 0;
    }

    public float ToSingle(IFormatProvider provider)
    {
        return 0;
    }

    public string ToString(IFormatProvider provider)
    {
        return Name;
    }

    public object ToType(Type conversionType, IFormatProvider provider)
    {
        return this;
    }

    public ushort ToUInt16(IFormatProvider provider)
    {
        return 0;
    }

    public uint ToUInt32(IFormatProvider provider)
    {
        return 0;
    }

    public ulong ToUInt64(IFormatProvider provider)
    {
        return 0;
    }
}
```

    
## LINQ 

LINQ - это язык запросов, который позволяет работать с данными.

Список extension методов для работы с коллекциями, то есть IEnumerable<T>

## StringBuilder

StringBuilder - это класс, который позволяет работать со строками.

Например обычный string при конкатенации создает новую строку в памяти, а StringBuilder работает с одной строкой.

То есть по факту StringBuilder - List<string> с готовыми методами для работы со строками.

По факту в нем есть Capacity, который все время  увеличивается в два раза. 
То есть если у вас строка из 10 символов, то Capacity будет 16, а если 20, то 32 и т.д.
При увеличивании Capacity происходит копирование строки в новую память.

## Отличие абстрактного класса от интерфейса

Почитайте сами, я гоыорил 1000 раз.

## Top level statements

Когда в проекте нет явного метода Main, то компилятор ищет файл с расширением .cs, в котором есть top level statements.

Top level statements - это код, который не находится внутри класса.







