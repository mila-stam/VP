using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{
    public class Game
    {
        public string Code { get; set; }
        public Team home {  get; set; }
        public Team guest { get; set; }
        public decimal coef1 { get; set; }
        public decimal coefX { get; set; }
        public decimal coef2 { get; set; }

        public Game (string code, Team home, Team guest, decimal coef1, decimal coefX, decimal coef2)
        {
            this.Code = code;
            this.home = home;
            this.guest = guest;
            this.coef1 = coef1;
            this.coefX = coefX;
            this.coef2 = coef2;
        }


        public override string ToString()
        {
            return string.Format("{0} - {1} vs. {2}", Code, home, guest);
        }
    }
}
