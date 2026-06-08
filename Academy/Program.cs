//#define I_HERITANCE_PART_1
#define I_HERITANCE_PART_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if I_HERITANCE_PART_1
            Human human = new Human("Hernriksoon", "Marthin", 35);
            human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jesse", 22, "Chemistry", "WW_220", 90, 95);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher); 
#endif

            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student(human, "Auto", "Vice", 95, 98);
            Console.WriteLine(student);


        }
    }
}
