using System;
using System.Collections.Generic;


// Общий интерфейс для компонентов
public abstract class FileSystemComponent
{
    public string Name { get; protected set; }

    public FileSystemComponent(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

// Лист (листовой узел) - представляет отдельный файл
public class File : FileSystemComponent
{
    public File(string name) : base(name) { }

    public override void Display()
    {
        Console.WriteLine($"Файл: {Name}");
    }
}

// Контейнер (узел-каталог) - представляет группу файлов
public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> components = new List<FileSystemComponent>();

    public Directory(string name) : base(name) { }

    public void AddComponent(FileSystemComponent component)
    {
        components.Add(component);
    }

    public void RemoveComponent(FileSystemComponent component)
    {
        components.Remove(component);
    }

    public override void Display()
    {
        Console.WriteLine($"Каталог: {Name}");

        // Рекурсивный вызов для отображения содержимого композита
        foreach (var component in components)
        {
            component.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаем несколько файлов
        var file1 = new File("file1.txt");
        var file2 = new File("file2.txt");
        var file3 = new File("file3.txt");

        // Создаем каталоги и добавляем в них файлы
        var directory1 = new Directory("Каталог 1");
        directory1.AddComponent(file1);
        directory1.AddComponent(file2);

        var directory2 = new Directory("Каталог 2");
        directory2.AddComponent(file3);

        // Создаем основной каталог и добавляем в него каталоги и файлы
        var rootDirectory = new Directory("Основной каталог");
        rootDirectory.AddComponent(directory1);
        rootDirectory.AddComponent(directory2);

        // Выводим содержимое файловой системы
        rootDirectory.Display();
    }
}




