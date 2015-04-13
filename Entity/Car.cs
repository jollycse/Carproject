using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Entity
{
    public class Car
    {
        public int speed;
      

       public void DrawCar(Graphics g, int objectId)
        { 
            Pen p = new Pen(Color.SteelBlue, 5);
            if (objectId == 0)
            {
                g.DrawLine(p, new Point(10, 150), new Point(10, 95));
                g.DrawLine(p, new Point(10, 95), new Point(400, 95));
                g.DrawLine(p, new Point(400, 95), new Point(400, 150));
                g.DrawLine(p, new Point(400, 150), new Point(300, 150));
               
                g.DrawLine(p, new Point(240, 150), new Point(150, 150));
               
                g.DrawLine(p, new Point(90, 150), new Point(10, 150));
                g.DrawLine(p, new Point(10, 95), new Point(60, 70));
                g.DrawLine(p, new Point(60, 70), new Point(90, 25));
                g.DrawLine(p, new Point(90, 25), new Point(250, 25));
                g.DrawLine(p, new Point(250, 25), new Point(300, 70));
                g.DrawLine(p, new Point(300, 70), new Point(400, 95));
                g.DrawLine(p, new Point(170, 25), new Point(170, 94));
                g.FillRectangle(Brushes.Salmon, 95, 42, 50, 38);
                g.FillRectangle(Brushes.Salmon, 200, 42, 50, 38);

                 g.DrawEllipse(new Pen(Color.Black,5), 90, 120, 60,60);
                 g.FillEllipse(Brushes.Bisque, 100, 130, 40, 40);
                 g.FillEllipse(Brushes.Black, 110, 140, 20, 20);

                 g.DrawEllipse(new Pen(Color.Black, 5), 240, 120, 60, 60);
                 g.FillEllipse(Brushes.Bisque, 250, 130, 40, 40);
                 g.FillEllipse(Brushes.Black,260, 140, 20, 20);

                 g.FillEllipse(Brushes.Red, 385, 93, 18, 20);
               
             
            }
            if (objectId == 1)
            {
                g.DrawLine(p, new Point(10, 150), new Point(10, 95));
                g.DrawLine(p, new Point(10, 95), new Point(400, 95));
                g.DrawLine(p, new Point(400, 95), new Point(400, 150));
                g.DrawLine(p, new Point(400, 150), new Point(300, 150));
                g.DrawLine(p, new Point(240, 150), new Point(150, 150));
                g.DrawLine(p, new Point(90, 150), new Point(10, 150));


                //g.DrawLine(p, new Point(0, 150), new Point(10, 100));
                g.DrawLine(p, new Point(10, 95), new Point(100, 70));
                g.DrawLine(p, new Point(100, 70), new Point(134, 25));
                g.DrawLine(p, new Point(134, 25), new Point(300, 25));
                g.DrawLine(p, new Point(300, 25), new Point(330, 70));
                g.DrawLine(p, new Point(330, 70), new Point(400, 95));
                g.DrawLine(p, new Point(217, 25), new Point(217, 94));

                g.FillRectangle(Brushes.Salmon, 134, 42, 50, 38);
                g.FillRectangle(Brushes.Salmon, 250, 42, 50, 38);
                
                g.DrawEllipse(new Pen(Color.Black, 5), 90, 120, 60, 60);
                g.FillEllipse(Brushes.Salmon, 100, 130, 40, 40);
                g.FillEllipse(Brushes.Black, 110, 140, 20, 20);
                g.DrawEllipse(new Pen(Color.Black, 5), 240, 120, 60, 60);
                g.FillEllipse(Brushes. Salmon, 250, 130, 40, 40);
                g.FillEllipse(Brushes.Black, 260, 140, 20, 20);

               
                g.FillEllipse(Brushes.Red, 10, 93, 20, 20);
               

            }
            if (objectId == 2)
            {
                g.DrawLine(p, new Point(100, 210), new Point(190, 210));
                g.DrawLine(p, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p, new Point(100, 50), new Point(120, 10));
                g.DrawLine(p, new Point(120, 10), new Point(170, 10));
                g.DrawLine(p, new Point(170, 10), new Point(190, 50));
                g.DrawLine(p, new Point(190, 210), new Point(190, 50));
                Point[] p1 = { new Point(100, 50), new Point(150, 40), new Point(190, 50) };
                g.DrawCurve(p, p1);
                g.DrawLine(p, new Point(100, 50), new Point(120, 70));
                g.DrawLine(p, new Point(120, 70), new Point(120, 180));
                g.DrawLine(p, new Point(120, 180), new Point(100, 210));
                g.DrawLine(p, new Point(190, 50), new Point(170, 70));
                g.DrawLine(p, new Point(170, 70), new Point(170, 180));
                g.DrawLine(p, new Point(170, 180), new Point(190, 210));
                g.DrawLine(p, new Point(120, 70), new Point(170, 70));
                g.DrawLine(p, new Point(120, 180), new Point(170, 180));
                g.DrawLine(p, new Point(100, 210), new Point(120, 230));
                g.DrawLine(p, new Point(120, 230), new Point(170, 230));
                g.DrawLine(p, new Point(190, 210), new Point(170, 230));
                g.DrawLine(p, new Point(100, 122), new Point(123, 125));
                g.DrawLine(p, new Point(170, 125), new Point(190, 122));

                g.FillRectangle(Brushes.Salmon, 105, 72, 15, 28);
                g.FillRectangle(Brushes.Salmon, 105, 152, 15, 28);
                g.FillRectangle(Brushes.Salmon, 172, 72, 15, 28);
                g.FillRectangle(Brushes.Salmon, 172, 152, 15, 28);

                g.FillRectangle(Brushes.Red, 120, 20, 10, 10);
                g.FillRectangle(Brushes.Red, 160, 20, 10, 10);
               
               

               

            }
            if (objectId == 3)
            {
               // g.DrawLine(p, new Point(100, 210), new Point(190, 210));
                g.DrawLine(p, new Point(100, 210), new Point(100, 50));
                g.DrawLine(p, new Point(100, 50), new Point(120, 30));
                g.DrawLine(p, new Point(120, 30), new Point(170, 30));
                g.DrawLine(p, new Point(170, 30), new Point(190, 50));
                g.DrawLine(p, new Point(190, 210), new Point(190, 50));
                g.DrawLine(p, new Point(100, 50), new Point(190, 50));
                Point[] p1 = { new Point(100, 210), new Point(150, 220), new Point(190, 210) };
                g.DrawCurve(p, p1);
                g.DrawLine(p, new Point(100, 50), new Point(120, 70));
                g.DrawLine(p, new Point(120, 70), new Point(120, 180));
                g.DrawLine(p, new Point(120, 180), new Point(100, 210));
                g.DrawLine(p, new Point(190, 50), new Point(170, 70));
                g.DrawLine(p, new Point(170, 70), new Point(170, 180));
                g.DrawLine(p, new Point(170, 180), new Point(190, 210));
                g.DrawLine(p, new Point(120, 70), new Point(170, 70));
                g.DrawLine(p, new Point(120, 180), new Point(170, 180));
                g.DrawLine(p, new Point(100, 210), new Point(120, 240));
                g.DrawLine(p, new Point(120, 240), new Point(170, 240));
                g.DrawLine(p, new Point(190, 210), new Point(170, 240));
                g.DrawLine(p, new Point(100, 122), new Point(123, 125));
                g.DrawLine(p, new Point(170, 125), new Point(190, 122));

                g.FillRectangle(Brushes.Salmon, 105, 72, 15, 28);
                g.FillRectangle(Brushes.Salmon, 105, 152, 15, 28);
                g.FillRectangle(Brushes.Salmon, 172, 72, 15, 28);
                g.FillRectangle(Brushes.Salmon, 172, 152, 15, 28);
                g.FillRectangle(Brushes.Red, 122, 227, 10, 10);
                g.FillRectangle(Brushes.Red, 165, 227, 10, 10);
                //g.FillRectangle(Brushes.Red, 140, 150, 10, 10);


            }
            
        }
    }
}
