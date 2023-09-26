# Using в С#

Есть несколько способов использования в C#:

1. Использовать namespace 
2. Использовать using static
3. Использовать using IDisposable
4. Использовать using alias

## Использование namespace

```csharp
using System;
```

## Использование using static

```csharp
using static System.Console;
```

using static позволяет использовать статические члены класса без указания имени класса.
В таком примере вы напишите просто 
```csharp
WriteLine("Hello World!");
```

## Использование using IDisposable

```csharp
using (var file = new StreamReader("file.txt"))
{
    // Do something with file
}
```

## Использование using alias

```csharp
using Project = PC.MyCompany.Project;
```

alias позволяет использовать сокращенное имя класса. В таком примере вы напишите просто 
```csharp
var project = new Project();
```

