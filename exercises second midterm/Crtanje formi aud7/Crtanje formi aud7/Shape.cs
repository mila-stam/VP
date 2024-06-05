using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtanje_formi_aud7
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public int Size { get; set; }
        public bool Selected { get; set; }

        public Shape(Color color, int size)
        {
            Color = color;
            Size = size;
            Selected = false;
        }

        public abstract void Draw(Graphics g);
        public abstract void Pulse();
        public abstract bool IsHit(Point p);
        
    }
}
