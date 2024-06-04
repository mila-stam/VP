using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public Team (string Name, string Country)
        {
            this.Name = Name;
            this.Country = Country;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Country);
        }
    }
}
