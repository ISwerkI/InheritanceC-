//#define INHERITANCE_PART_1
//#define INHERITANCE_PART_2
#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if INHERITANCE_PART_1
            Human human = new Human("Hernriksoon", "Marthin", 35);
            human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jesse", 22, "Chemistry", "WW_220", 90, 95);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Rosenberg", "Ken", 35, "Law", "Vice", 32, 25, "How to make money");
            Console.WriteLine(graduate);
#endif

#if INHERITANCE_PART_2
            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student(human, "Auto", "Vice", 95, 98);
            Console.WriteLine(student);

            Graduate graduate = new Graduate(student, "How to make money");
            Console.WriteLine(graduate);
#endif

#if WRITE_TO_FILE
            //Upcast
            Human[] group = new Human[]
            {
                new Student("Vercetty","Tomy",30,"Ayto","Vice",91,98),
                new Teacher("Diaz","Ricardo",45,"Weapons distribution",20),
                new Graduate("Rozenberg","Ken",35,"Law","Vice",32,25,"How to make money"),
                new Teacher("Colonel","Cortez",50,"Weapons distribution",25)
            };
            Print(group);
            Save(group, "group.csv");
#endif

        }
        static void Save(Human[] group, string filename)
        {
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            //string filename = "group.csv";
            StreamWriter writer = new StreamWriter(filename);
            foreach (Human h in group)
            {
                writer.WriteLine(h.ToFileSring());
            }
            writer.Close();
            Process.Start("notepad", filename);
        }

        static void Print(Human[] group)
        {
            foreach (Human h in group)
            {
                Console.WriteLine(h);
            }
        }
    }
}
