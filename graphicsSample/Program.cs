using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Graphics graphics;
            graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 50, 50));
            graphics.FillEllipse(Brushes.Yellow, 200, 200, 100, 100);

            brush.Color = Color.Black;
            graphics.FillEllipse(brush, 220, 230, 17, 17);
            graphics.FillEllipse(brush, 260, 230, 17, 17);

            brush.Color = Color.Pink;
            graphics.FillClosedCurve(brush, new Point[]{
                new Point(250, 280),
                new  Point(230, 265),
                new Point(270, 265)
            });
            Pen pen = new Pen(Color.FromArgb(100, 100, 0));

            Rectangle rectangle = new Rectangle
            {
                X = 100,
                Y = 100,
                Width = 100,
                Height = 100

            };
            graphics.FillRectangle(brush, rectangle);

            //graphics.DrawLines(pen, new Point[]
            //{
            //    new Point(100, 150),
            //    new Point(100, 200),
            //    new Point(150, 200),
            //    new Point(150, 150),
            //    new Point(100, 150)

            //});
            Rectangle rectangle1 = new Rectangle
            {
                X = 125,
                Y = 120,
                Width = 50,
                Height = 50

            };
            pen.Color = Color.White;
            graphics.DrawRectangle(pen, rectangle1);


            brush.Color = Color.Brown;
            Rectangle rectangle2 = new Rectangle
            {
                X = 170,
                Y = 70,
                Width = 10,
                Height = 30

            };
            graphics.FillRectangle(brush, rectangle2);

            graphics.DrawLine(pen, 150, 120, 150, 170);
            graphics.DrawLine(pen, 125, 145, 175, 145);
            brush.Color = Color.Gray;
            graphics.FillPolygon(brush, new Point[]
            {
                new Point(150, 70),
                new Point(200, 100),
                new Point(100, 100),
                new Point(150, 70)
            });



            Console.ReadLine();
        }
    }
}
