using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Entities
{
    internal class Departament
    {
        public string Name { get; set; }

        public Departament(string name)
        {
            Name = name;
        }
    }
}
