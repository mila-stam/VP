using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class Bus
    {
        public string Registration {  get; set; }
        public string Name { get; set; }
        public bool Local { get; set; }
        public List<Line> lines { get; set; } = new List<Line> { };
        public Bus() { }
        public Bus(string registration, string name, bool local)
        {
            Registration = registration;
            Name = name;
            Local = local;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name, Registration, Local ? "L" : "M");
        }
    }
}
