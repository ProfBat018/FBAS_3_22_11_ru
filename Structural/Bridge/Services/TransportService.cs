using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Bridge.Model;

namespace Bridge.Services;

static class TransportService
{
    public static ITransport CreateTransport()
    {
        int selection;
        string[] transportTypes = typeof(TransportType).GetEnumNames();

        Console.WriteLine("Enter transport type:\n");

        for (int i = 0; i < transportTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {transportTypes[i]}");
        }

        bool numberCheck = Int32.TryParse(Console.ReadLine(), out selection);

        if (numberCheck)
        {
            var transportType = GetTransportType((TransportType)selection);
            return GetTransport(transportType);
        }
        throw new ArgumentException("Selection is wrong");
    }

    private static Type GetTransportType(TransportType userSelection)
    {
        var types = userSelection.GetType().GetEnumValues();

        var IEntityTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IEntity))).ToList();

        foreach (var type in IEntityTypes)
        {
            if (type.Name == types.GetValue((int)userSelection - 1).ToString())
            {
                return type;
            }
        }
        throw new ArgumentException("Selection is wrong");
    }


    private static ITransport GetTransport(Type transportType)
    {
        var assembly = Assembly.GetExecutingAssembly(); // Рефлексия

        List<Type> types = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ITransport))).ToList();

        int i = 1;

        foreach (var type in types)
        {
            Console.WriteLine($"{i}. {type.Name}");
            i++;
        }

        Console.WriteLine("Enter transport Name:\n");

        int selection = Int32.Parse(Console.ReadLine());

        var transport = Activator.CreateInstance(types[selection - 1]) as ITransport;

        IEntity entity = transport as IEntity;

        Console.WriteLine("Enter make:");
        transport.Make = Console.ReadLine();

        Console.WriteLine("Enter model:");
        transport.Model = Console.ReadLine();

        transport.TransportEntity = Activator.CreateInstance(transportType) as IEntity;

        return transport;
    }
}
