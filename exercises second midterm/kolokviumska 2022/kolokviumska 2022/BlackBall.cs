using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokviumska_2022
{
    public class BlackBall
    {
        public int Radius { get; set; } = 25;
        public Point Center { get; set; }
        public BlackBall(Point Center) { 
            this.Center = Center;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, Center.X - Radius, Center.Y- Radius, Radius*2, 2*Radius);  
            b.Dispose();
        }


    }
}
