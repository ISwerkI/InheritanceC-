using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeC_
{
    internal class Square: Shape
    {
        public double Size;
        
        public Square
            (
            double size,
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            Size = size;
        }

        public override double getArea()
        {
            return Size*Size;
        }

        public override double getPerimeter()
        {
            return Size*4;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Size, (float)Size);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Размер квадрата: {Size}");

            base.Info(e);
        }
    }
}
