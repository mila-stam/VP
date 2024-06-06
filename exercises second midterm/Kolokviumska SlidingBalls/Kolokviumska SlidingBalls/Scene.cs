using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokviumska_SlidingBalls
{
    public class Scene
    {
        public List<Ball> Balls {  get; set; }
        public Ball MovingBall { get; set; }

        public Scene() { 
            Balls = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }
        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }


    }
}
