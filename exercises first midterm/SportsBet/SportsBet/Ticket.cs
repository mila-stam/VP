using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{
    public class Ticket
    {
        public Game game {  get; set; }
        public int Type { get; set; } //0=1, 1=X, 2=2


        public Ticket(Game game, int Type) {
            this.game = game;
            this.Type = Type;
        }


        public override string ToString()
        {
            return string.Format("{0} vs {1}: {2}", game.home.Name, game.guest.Name, Type == 0 ? "1" : Type ==  1 ? "X" : "2");
        }
    }
}
