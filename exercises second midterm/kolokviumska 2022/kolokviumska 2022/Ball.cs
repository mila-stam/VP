using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokviumska_2022
{
    [Serializable]
    public class Ball
    {
        public static int Radius = 15;
        public Color Color {  get; set; }
        public Point Center { get; set; }
        public static Random random = new Random();
        public int direction;
        

        public Ball(Point Center, int direction) { 
            this.Center = Center;
            this.direction = direction;
            
        }
  
        public void Draw(Graphics g)
        {
            
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
            
        }

        public void MoveBall(int width, int height)
        {
            
            if (direction == 0)
            {
                Center = new Point(Center.X + 15, Center.Y);
                if (Center.X > width)
                {
                    direction = 1;
                }
            }
            else if (direction == 1)
            {
                Center = new Point(Center.X - 15, Center.Y);
                if (Center.X < 0)
                {
                    direction = 0;
                }
            }
            else if (direction == 2)
            {
                Center = new Point(Center.X, Center.Y + 15);
                if(Center.Y > height)
                {
                    direction = 3;
                }
            }
            else if (direction == 3)
            {
                Center = new Point(Center.X , Center.Y - 15);
                if (Center.Y < 0)
                {
                    direction = 2;
                }
            }
        }

    }
}
