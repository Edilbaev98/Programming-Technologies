using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class MyGun
    {
        public GraphicsPath path8 = new GraphicsPath();
        public MyGun(int x, int y)
        {

            Point[] gun =
            {
                new Point(x-20,y-10),
                new Point(x,y-25),
                new Point(x+20,y-10),
                new Point(x+6,y-10),
                new Point(x+6,y+25),
                new Point(x-6,y+25),
                new Point(x-6,y-10)
            };

            path8.AddPolygon(gun);
        }
    }
}
