using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeC_
{
    internal class Сircle:Shape
    {
        public double Radius;

        public Сircle
           (
           double radius,
           int startX, int startY, int lineWidth, Color color
           ) : base(startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public override double getArea()
        {
            return 3.14*Radius*Radius;
        }

        public override double getPerimeter()
        {
            return 2*3.14*Radius;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            // NONE
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус круга: {Radius}");
            Console.WriteLine($"Диаметр круга: {Radius*2}");

            base.Info(e);
        }
    }
}
