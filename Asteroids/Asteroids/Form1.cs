using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        SolidBrush brushwhite, brushred, brushgreen, brushyellow, brushblue;
        MyAsters aster1, aster2, aster3, aster4;
        MyStars star1, star2, star3, star4, star5, star6, star7, star8;

        SpaceShip ship;
        MyBullet bullet;
        MyGun gun;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            g = Graphics.FromImage(bmp);
            g.FillRectangle(brushblue, 0, 0, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = bmp;

            x1++;
            y1++;
            if (x1 == Width)
                x1 = 0;
            if (y1 == Height)
                y1 = 0;
            x2++;
            y2--;
            if (x2 == Width)
                x2 = 0;
            if (y2 == 0)
                y2 = Height;
            x3--;
            y3++;
            if (x3 == 0)
                x3 = Width;
            if (y3 == Height)
                y3 = 0;
            x4--;
            y4--;
            if (x4 == 0)
                x4 = Width;
            if (y4 == 0)
                y4 = Height;

            aster1 = new MyAsters(x1, y1);
            aster2 = new MyAsters(x2, y2);
            aster3 = new MyAsters(x3, y3);
            aster4 = new MyAsters(x4, y4);

            a1++;
            b1++;
            if (a1 == Width)
                a1 = 0;
            if (b1 == Height)
                b1 = 0;
            a2--;
            b2++;
            if (a2 == 0)
                a2 = Width;
            if (b2 == Height)
                b2 = 0;
            a3++;
            b3++;
            if (a3 == Width)
                a3 = 0;
            if (b3 == Height)
                b3 = 0;
            a4--;
            b4--;
            if (a4 == 0)
                a4 = Width;
            if (b4 == 0)
                b4 = Height;
            a5--;
            b5++;
            if (a5 == 0)
                a5 = Width;
            if (b5 == Height)
                b5 = 0;
            a6--;
            b6--;
            if (a6 == 0)
                a6 = Width;
            if (b6 == 0)
                b6 = Height;
            a7++;
            b7--;
            if (a7 == Width)
                a7 = 0;
            if (b7 == 0)
                b7 = Height;
            a8++;
            b8--;
            if (a8 == Width)
                a8 = 0;
            if (b8 == 0)
                b8 = Height;

            star1 = new MyStars(a1, b1);
            star2 = new MyStars(a2, b2);
            star3 = new MyStars(a3, b3);
            star4 = new MyStars(a4, b4);
            star5 = new MyStars(a5, b5);
            star6 = new MyStars(a6, b6);
            star7 = new MyStars(a7, b7);
            star8 = new MyStars(a8, b8);

            c1++;
            c2--;
            if (c1 == Width)
                c1 = 0;
            if (c2 == 0)
                c2 = Height;
            bullet = new MyBullet(c1, c2);


            Paint1();

        }


        static int x1 = 180, x2 = 220, x3 = 800, x4 = 610;
        static int y1 = 200, y2 = 450, y3 = 170, y4 = 510;
        static int a1 = 50, a2 = 400, a3 = 650, a4 = 880, a5 = 770, a6 = 865, a7 = 380, a8 = 70;
        static int b1 = 110, b2 = 60, b3 = 100, b4 = 275, b5 = 400, b6 = 570, b7 = 500, b8 = 510;
        static int c1 = 492;
        static int c2 = 240;


        public Form1()
        {
            InitializeComponent();


            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;


            brushwhite = new SolidBrush(Color.White);
            brushred = new SolidBrush(Color.Red);
            brushgreen = new SolidBrush(Color.Green);
            brushyellow = new SolidBrush(Color.Yellow);
            brushblue = new SolidBrush(Color.Blue);

            aster1 = new MyAsters(180, 200);
            aster2 = new MyAsters(220, 450);
            aster3 = new MyAsters(800, 170);
            aster4 = new MyAsters(610, 510);


            ship = new SpaceShip(492, 325);
            bullet = new MyBullet(492, 240);
            gun = new MyGun(490, 325);
            
            star1 = new MyStars(50, 110);
            star2 = new MyStars(400, 60);
            star3 = new MyStars(650, 100);
            star4 = new MyStars(880, 275);
            star5 = new MyStars(770, 400);
            star6 = new MyStars(865, 570);
            star7 = new MyStars(380, 500);
            star8 = new MyStars(70, 510);

        }


        public void Paint1()
        {

            g.FillPath(brushyellow, ship.path3);

            g.FillPath(brushwhite, star1.path7);
            g.FillPath(brushwhite, star2.path7);
            g.FillPath(brushwhite, star3.path7);
            g.FillPath(brushwhite, star4.path7);
            g.FillPath(brushwhite, star5.path7);
            g.FillPath(brushwhite, star6.path7);
            g.FillPath(brushwhite, star7.path7);
            g.FillPath(brushwhite, star8.path7);

            g.FillPath(brushred, aster1.path1);
            g.FillPath(brushred, aster1.path2);
            g.FillPath(brushred, aster2.path1);
            g.FillPath(brushred, aster2.path2);
            g.FillPath(brushred, aster3.path1);
            g.FillPath(brushred, aster3.path2);
            g.FillPath(brushred, aster4.path1);
            g.FillPath(brushred, aster4.path2);

            g.FillPath(brushgreen, gun.path8);

            g.FillPath(brushgreen, bullet.path5);
            g.FillPath(brushgreen, bullet.path6);

        }
    }
}
