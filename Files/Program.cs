//#define WRITE_TO_FILE
#define READ_FROM_FILE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            //1) Создаем и открываем поток
            StreamWriter sw = new StreamWriter("File.txt");

            //2) Записываем вывод в файл:
            sw.Write("Hello World!");
            sw.WriteLine("Это запися в файл на языке C++");

            sw.Close();

            Process.Start("notepad", "File.txt"); 
#endif
            //1) Создаем и открываем поток
            StreamReader sr = new StreamReader("File.txt");

            //2) Читаем файл и выводим его в консоль:
            while (!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }

            sr.Close();
        }
    }
}
