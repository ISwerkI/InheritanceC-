using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeC_
{
    internal class Circle:Shape,IHaveDiameter
    {
        public double Radius {  get; set; }
        int angle = 30;
        int opposite_angle;

        public Circle
           (
           double radius,
           int startX, int startY, int lineWidth, Color color
           ) : base(startX, startY, lineWidth, color)
        {
            Radius = radius;
            angle = 30;
            opposite_angle = angle + 180;
        }


        public override double getArea()
        {
            return 3.14*Radius*Radius;
        }

        public override double getPerimeter()
        {
            return 2*3.14*Radius;
        }
        public double GetDiameter()
        {
            return Radius*2;
        }
        public Point GetCenter()
        {
            return new Point(StartX + (int)Radius,StartY + (int)Radius);
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            // NONE
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius * 2, (float)Radius * 2);
        }
        void DrawCenter(PaintEventArgs e)
        {
            Point center = new Point(StartX + (int)Radius, StartY + (int)Radius);
            Pen pen = new Pen(Color, 4);
            e.Graphics.DrawEllipse
            (
                pen,
                center.X - 2, center.Y - 2,
                4, 4
            );
        }

        public void DrawRadius(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine
            (
                pen,
                StartX + (int)Radius, StartY + (int)Radius,
                StartX + (int)Radius + (int)(Radius*Math.Cos(angle * Math.PI/180)),
                StartY + (int)Radius+ (int)(Radius * Math.Sin(angle * Math.PI / 180))
            );
        }
        public void DrawDiameter(PaintEventArgs e)
        {
            Pen pen = new Pen (Color, 1);
            e.Graphics.DrawLine
                (
                pen,
                StartX + (int)Radius + (int)(Radius * Math.Sin(opposite_angle * Math.PI / 180)),
                StartY + (int)Radius + (float)(Radius * Math.Cos(opposite_angle * Math.PI / 180)),
                StartX + (int)Radius + (float)(Radius * Math.Sin(angle * Math.PI / 180)),
                StartY + (int)Radius + (float)(Radius * Math.Cos(angle * Math.PI / 180))
                );
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус круга: {Radius}");
            Console.WriteLine($"Диаметр круга: {GetDiameter()}");
            DrawDiameter(e);
            DrawRadius(e);
            DrawCenter(e);
            base.Info(e);
        }
    }
}
