using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kolokviumska_SlidingBalls
{
    public class Ball
    {
        public static int RADIUS = 30;
        public Color Color { get; set; }
        public Point Center;
        public bool IsMoving = false;
        public int Direction;
        public Ball(Point Center, Color color)
        {
            this.Center = Center;
            this.Color = Color;
        }

        public void Draw(Graphics g)
        {

            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }
        public bool IsHit(Point point)
        {
            return Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2)) <= RADIUS;
        }
        public void Move()
        {
            if (Direction == 0)
            {
                Center = new Point(Center.X + 10, Center.Y);
            }
            else if (Direction == 1)
            {
                Center = new Point(Center.X - 10, Center.Y);
            }
            else if (Direction == 2)
            {
                Center = new Point(Center.X, Center.Y + 10);
            }
            else if (Direction == 1)
            {
                Center = new Point(Center.X, Center.Y - 10);
            }
        }

        public bool IsOut(int width, int height)
        {
            if (Center.X > width || Center.Y > height || Center.X < 0 || Center.Y < 0)
            {
                return true;
            }
            return false;
        }

    }
}
