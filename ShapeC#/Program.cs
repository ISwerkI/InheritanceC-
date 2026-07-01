//#define CHECK_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Threading;

namespace ShapeC_
{
    internal class Program
    {
        struct Parameters
        {
            public Shape[] shapes;
            public PaintEventArgs e;
        }
        static bool finish = false;
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


#if CHECK_1
            Square square = new Square(200, 100, 300, 5, Color.Red);
            square.Draw(e);
            square.Info(e);

            Circle circle = new Circle(100, 400, 300, 5, Color.Yellow);
            circle.Draw(e);
            circle.Info(e); 
#endif

            Shape[] shapes = new Shape[]
            {
                new Square(200, 100, 300, 5, Color.Red),
            new Circle(100, 400, 300, 5, Color.Yellow)
            };

            Parameters parameters = new Parameters
            {
                shapes = shapes,
                e = new PaintEventArgs(graphics, window_rect)
            };

            Thread draw_thread = new Thread(new ParameterizedThreadStart(Draw));
            draw_thread.Start(parameters);
            Console.ReadKey();
            finish = true;

        }


        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("krenel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        static void Info(Shape[] shapes,PaintEventArgs e)
        {
            for (int i = 0; i < shapes.Length;i++)
            {
                shapes[i].Info(e);
            }
        }

        static void Draw(object obj)
        {
            Parameters parameters = (Parameters)obj;
            while (!finish)
            {
                for (int i = 0; i < parameters.shapes.Length; i++)
                {
                    parameters.shapes[i].Draw(parameters.e);
                }
            }
        }
    }
}
