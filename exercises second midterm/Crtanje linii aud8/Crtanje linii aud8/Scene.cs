using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtanje_linii_aud8
{
    public class Scene
    {
        public List<Line> Lines { get; set; }
        public Point LastPoint { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public bool Positioner { get; set; }
        public Point Cursor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Stack<Line> UndoStack { get; set; }

        public Scene(int Width, int Height)
        {
            Lines = new List<Line>();
            Color = Color.Red;
            Thickness = 1;
            LastPoint = Point.Empty;
            Positioner = false;
            this.Width = Width;
            this.Height = Height;
            UndoStack = new Stack<Line>();
        }


        public void AddPoint(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, Thickness));
            }
            LastPoint = point;
        }


        public void Draw(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }

            if (Positioner)
            {
                Pen p = new Pen(Color.Black);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(p, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X, 0), new Point(Cursor.X, Height));
                p.Dispose();
            }
        }

        internal void Undo()
        {
            if (Lines.Count > 0)
            {
                Line l = Lines[Lines.Count - 1];
                UndoStack.Push(l);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else
                {
                    LastPoint = Lines[Lines.Count - 1].Right;
                }

            }

        }

        internal void Redo()
        {
            if (UndoStack.Count > 0)
            {
                Line l = UndoStack.Pop();
                Lines.Add(l);
                LastPoint = l.Right;
            }


        }
    }
}
