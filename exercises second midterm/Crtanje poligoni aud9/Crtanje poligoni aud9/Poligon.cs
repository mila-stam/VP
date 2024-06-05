using System;
using System.Collections.Generic;
using System.Drawing;


namespace Crtanje_poligoni_aud9
{
    [Serializable]
    public class Poligon
    {
        public List<Point> points { get; set; }
        public bool IsClosed { get; set; } = false;
        public bool IsCloseToStart { get; set; } = false;
        public Point Cursor { set; get; } = new Point();

        public Poligon()
        {
            points = new List<Point>();
        }

        public void AddPoint(Point p)
        {
            IsCloseToStart = NearStart();
            if (IsCloseToStart)
            {
                points.Add(points[0]);
                IsClosed = true;
                IsCloseToStart = false;
            }
            else
            {
                points.Add(p);
            }

        }

        public void UpdateCursor(Point p)
        {
            Cursor = p;
            IsCloseToStart = NearStart();
        }
        public bool NearStart()
        {
            if (points.Count < 3)
            {
                return false;
            }
            Point firstPoint = points[0];
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - Cursor.X, 2) + Math.Pow(firstPoint.Y - Cursor.Y, 2));
            return distance <= 5;
        }
        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 1);  //pen for the line
            Pen pDash = new Pen(Color.Black, 1);
            pDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; 
            Brush b = new SolidBrush(Color.Blue);

            if(points.Count >= 2)
            {
                g.DrawLines(p, points.ToArray());
                if(IsCloseToStart)
                {
                    Point firstPoint = points[0];
                    g.DrawEllipse(pDash, firstPoint.X-5, firstPoint.Y-5, 10, 10);
                }

                if (IsClosed)
                {
                    g.FillPolygon(b, points.ToArray());
                    
                }

            }


            if(points.Count > 0)
            {
                Point lastPoint = points[points.Count - 1];
                g.DrawLine(pDash, lastPoint, Cursor);
            }

            p.Dispose();
            pDash.Dispose();
            b.Dispose();
        }
    }
}
