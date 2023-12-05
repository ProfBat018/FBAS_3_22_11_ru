using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Model;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Memento.Services;

class SnapshotService
{
    private Dictionary<string, Forecast> _snapshots = new();

    public void AddSnapshot(string query, Forecast forecast)
    {
        _snapshots.Add(query, forecast);

        using FileStream fs = new("snapshots.json", FileMode.OpenOrCreate);
        using StreamWriter sw = new(fs);

        var JsonSerial = JsonConvert.SerializeObject(_snapshots);

        sw.WriteLine(JsonSerial);

        Console.WriteLine("Snapshot saved");
    }

    public Forecast GetSnapshots()
    {
        using FileStream fs = new("snapshots.json", FileMode.OpenOrCreate);
        using StreamReader sr = new(fs);

        var json = sr.ReadToEnd();

        _snapshots = JsonSerializer.Deserialize<Dictionary<string, Forecast>>(json);

        Console.WriteLine("Snapshots loaded");

        Console.WriteLine("Enter id to load data...");

        int i = 0;
        foreach (var item in _snapshots)
        {
            i++;
            Console.WriteLine($"{i}. {item}");
        }

        int selection = int.Parse(Console.ReadLine());

        return _snapshots.ElementAt(selection - 1).Value;
    }
}
