using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool FirstDriver { get; set; }
        public List<Lap> Laps { get; set; } = new List<Lap> { };

        
        public Driver(string name, int age, bool first) { 
            Name = name;
            Age = age;
            FirstDriver = first;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2}", Name, Age, FirstDriver ? "F" : "S");
        }
    }
}
