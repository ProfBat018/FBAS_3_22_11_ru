using Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.ViewModels
{
    class MainViewModel
    {
        public PersonModel First { get; set; } = new()
        {
            Name = "John",
            Surname = "Doe"
        };

    }
}
