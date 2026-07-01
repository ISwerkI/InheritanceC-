using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShapeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop,
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            Pen pen = new Pen(Color.AliceBlue, 5);


            Square square = new Square(200, 100,300, 5, Color.Red);
            square.Draw(e);
            square.Info(e);

            Circle circle = new Circle(100, 400, 300, 5, Color.Yellow);
            circle.Draw(e);
            circle.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("krenel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
