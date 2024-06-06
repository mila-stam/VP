using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokviumska_2022
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public static Random random = new Random();
        public BlackBall BlackBall { get; set; }
        public int dir { get; set; }
        public Scene()
        {
            Balls = new List<Ball>();

        }

        public void DrawAll(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
            
        }

        public void DrawBlack(Graphics g)
        {
            if (BlackBall != null)
            {
                BlackBall.Draw(g);
            }

        }
        public void Init(int width, int height)
        {
            dir = random.Next(4);
            int X = random.Next(25, width - 50);
            int Y = random.Next(25, height - 50);
            Balls.Add(new Ball(new Point(X, Y), dir));

        }

        public void Move(int width, int height)
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                Balls[i].MoveBall(width, height);
            }
        }
    }
}
