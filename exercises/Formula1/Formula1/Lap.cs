using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Lap() { }
        public Lap(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }
        public int totalSec()
        {
            return (Minutes * 60) + Seconds;
        }
        public override string ToString()
        {
            return String.Format("{0}:{1}", Minutes, Seconds);
        }
    }
}
