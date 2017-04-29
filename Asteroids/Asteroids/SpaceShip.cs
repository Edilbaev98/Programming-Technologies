using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class SpaceShip
    {
        public GraphicsPath path3 = new GraphicsPath();
        
        public SpaceShip(int x,int y)
        {
            
            Point[] ship =
            {
                new Point(x,y-30),
                new Point(x+30,y-15),
                new Point(x+30,y+15),
                new Point(x,y+30),
                new Point(x-30,y+15),
                new Point(x-30,y-15)
            };

            path3.AddPolygon(ship);
         
        }
    }
}
