using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeC_
{
    internal class Rectangle: Shape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public Rectangle
            (
            double width, double height,
            int startX, int startY,int lineWidth,Color color
            ) : base(startX, startY, lineWidth, color )
        {
            Width = width;
            Height = height;
        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return 2*(Width+Height);
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Ширина прямоугольника: {Width}");
            Console.WriteLine($"Высота прямоугольника: {Height}");

            base.Info(e);
        }
    }
}
