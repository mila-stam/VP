using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Destination
    {
        public string Name { get; set; }
        public decimal Distance { get; set; }
        public decimal Price { get; set; }
        public Destination() { }
        public Destination(string Name, decimal Distance, decimal Price)
        {
            this.Name = Name;
            this.Distance = Distance;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}km- {2}EUR", Name, Distance, Price);

        }
    }
}
