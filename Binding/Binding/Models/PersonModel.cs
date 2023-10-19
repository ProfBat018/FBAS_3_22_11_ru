using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.Models
{
    class PersonModel
    {
        private static uint _id = 0;
        
        public uint Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public PersonModel()
        {
            Id = ++_id;
        }
    }
}
