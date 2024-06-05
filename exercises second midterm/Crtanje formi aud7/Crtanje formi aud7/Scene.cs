 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtanje_formi_aud7
{
    public class Scene
    {
        public List<Shape> Shapes {  get; set; }
        public Shape Selected { get; set; } = null; 
        public Scene()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape shape in Shapes)
            {
                shape.Draw(g);
            }
        }

        internal void Click(Point location, string Type)
        {
            bool found = false;
            foreach(Shape shape in Shapes)
            {
                if (shape.IsHit(location))
                {
                    found = true;
                    shape.Selected = !shape.Selected;

                }
            }
            if(!found)
            {
                if (Type == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, location));
                }
                else
                {
                    Shapes.Add(new Square(Color.Red, 60, location));
                }
            }
             
        }

        public void Pulse()
        {
            foreach(Shape s in Shapes)
            {
                s.Pulse();
            }
        }
    }
}
