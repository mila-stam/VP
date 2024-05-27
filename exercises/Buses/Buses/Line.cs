using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class Line
    {
        public string Destination {  get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public float Price { get; set; }
        public Line() { }
        public Line(string destination, int hour, int minutes, float price)
        {
            Destination = destination;
            Hour = hour;
            Minutes = minutes;
            Price = price;
        }
        public override string ToString()
        {
            return String.Format("{0}:{1} - {2} - {3} den", Hour, Minutes, Destination, Price);
        }
    }
}
