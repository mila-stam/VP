using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flying_balls_aud10
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public static Random Random = new Random();
        public int Height { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; } = 0;
        public int Misses { get; set; } = 0;


        public Scene(int Height, int Width) {
            Balls = new List<Ball>();
            this.Height = Height;
            this.Width = Width;
        }
        public void AddBall()
        {
            Balls.Add(new Ball(new Point(-Ball.RADIUS, Random.Next(2 * Ball.RADIUS, Height - 2 * Ball.RADIUS))));
        }
        public void Move()
        {
            foreach (Ball b in Balls)
            {
                b.Move(5, 0);
            }

            foreach(Ball b in Balls)
            {
                if(b.Center.X-Ball.RADIUS > Width)
                {
                    b.State = -1;
                }
            }

            for (int i = 0; i < Balls.Count(); i++)
            {
                if (Balls[i].State == -1)
                {
                    Misses++;
                    Balls.RemoveAt(i);

                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        internal void Hit(Point location)
        {
            foreach(Ball ball in Balls)
            {
                ball.Hit(location);
            }

            for(int i =0; i<Balls.Count(); i++)
            {
                if (Balls[i].State == 3)
                {
                    Hits++;
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
