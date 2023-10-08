using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models;
public class ToDoItem
{
    public string Name { get; set; }
    public DateTime Due { get; set; }
    public string ImagePath { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Due}";
    }
}
