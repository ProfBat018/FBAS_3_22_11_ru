using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Services
{
    public class TaskManagerService
    {
        public List<ToDoItem> Tasks { get; set; } = new();
    }
}
