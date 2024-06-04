using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport2
{
    public class Destination
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public float Price { get; set; }
        public Destination() { }
        public Destination(string name, int distance, float price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }
        public override string ToString()
        {
            return String.Format("{0}  {1} - {2} EUR", Name, Distance, Price);
        }
    }
}
