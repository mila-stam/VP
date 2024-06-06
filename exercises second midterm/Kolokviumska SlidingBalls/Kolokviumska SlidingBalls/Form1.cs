using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokviumska_SlidingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        Random random = new Random();
        public Form1()
        {
            scene = new Scene();
            InitializeComponent();
            timer1.Interval = 50;
            DoubleBuffered = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int num = random.Next(0, 2);
                if (num == 0)
                {
                    scene.Balls.Add(new Ball(e.Location, Color.Green));
                    tsslActive.Text = $"Active:{scene.Balls.Count}";
                }
                else if (num == 1)
                {
                    scene.Balls.Add(new Ball(e.Location, Color.Blue));
                    tsslActive.Text = $"Active:{scene.Balls.Count}";
                }
            }
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && scene.MovingBall == null)
            {
                foreach (Ball b in scene.Balls)
                {
                    if (b.Color == Color.Red)
                    {
                        if (b.IsHit(e.Location))
                        {
                            b.IsMoving = true;
                            scene.MovingBall = b;
                            scene.MovingBall.Direction = random.Next(0, 4);
                            timer1.Start();
                            
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                scene.Balls.Add(new Ball(e.Location, Color.Red));
                tsslActive.Text = $"Active:{scene.Balls.Count}";
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scene.MovingBall != null)
            {
                scene.MovingBall.Move();
                for (int i = 0; i < scene.Balls.Count; i++)
                {
                    if (scene.MovingBall != scene.Balls[i] && scene.MovingBall.IsHit(scene.Balls[i].Center))
                    {
                        if (scene.Balls[i].Color == Color.Green)
                        {
                            scene.Balls.RemoveAt(i);
                            tsslActive.Text = $"Active:{scene.Balls.Count}";
                        }
                    }
                }

                if (scene.MovingBall.IsOut(this.Width, this.Height))
                {
                    scene.Balls.Remove(scene.MovingBall);
                    tsslActive.Text = $"Active:{scene.Balls.Count}";

                    scene.MovingBall = null;
                }
            }
            Invalidate();
        }
    }
}
