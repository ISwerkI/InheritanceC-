//#define I_HERITANCE_PART_1
#define I_HERITANCE_PART_2
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            Graduate graduate = new Graduate("Rosenberg", "Ken", 35, "Law", "Vice", 32, 25, "How to make money");
            Console.WriteLine(graduate);
#endif

#if I_HERITANCE_PART_2
            Human human = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(human);

            Student student = new Student(human, "Auto", "Vice", 95, 98);
            Console.WriteLine(student);

            Graduate graduate = new Graduate(student, "How to make money");
            Console.WriteLine(graduate);
#endif
            //Upcast
            Human[] group = new Human[]
            {
                new Student("Vercetty","Tomy",30,"Ayto","Vice",91,98),
                new Teacher("Diaz","Ricardo",45,"Weapons distribution",20),
                new Graduate("Rozenberg","Ken",35,"Law","Vice",32,25,"How to make money"),
                new Teacher("Colonel","Cortez",50,"Weapons distribution",25)
            };

            foreach (Human i in group)
            {
                Console.WriteLine(i);
            }


        }
    }
}
