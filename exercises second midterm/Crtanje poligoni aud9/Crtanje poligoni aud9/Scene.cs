using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtanje_poligoni_aud9
{
    [Serializable]
    public class Scene
    {
        public List<Poligon> poligons { get; set; } = new List<Poligon>();
        public Poligon CurrentPoligon { get; set; } = new Poligon();


        public Scene() { }

        public void AddPoint(Point p)
        {
            CurrentPoligon.AddPoint(p);
            if (CurrentPoligon.IsClosed)
            {
                poligons.Add(CurrentPoligon);
                CurrentPoligon = new Poligon();
            }
        }

        public void UpdateCursor (Point p)
        {
            CurrentPoligon.UpdateCursor(p);
        }

        public void Draw(Graphics g)
        {
            CurrentPoligon.Draw(g);
            foreach(Poligon p in poligons)
            {
                p.Draw(g); 
            }
        }
    }
}
