using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{GetHashCode()}");
        }

        public Human(Human other)
        {
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
        }
        ~Human()
        {
            Console.WriteLine($"HDestructor:\t{GetHashCode()}");
        }

        //              Methods
        public void Info()
        {
            Console.WriteLine($"{LastName.PadRight(12)} {FirstName.PadRight(12)} {Age.ToString().PadLeft(2).PadRight(3)} ");
        }
        public override string ToString()
        {
            return $"{LastName.PadRight(12)} {FirstName.PadRight(12)} {Age.ToString().PadLeft(2).PadRight(3)} ";
        }

        public virtual string ToFileSring()
        {
            return $"{this.GetType().ToString().Split('.').Last()}:{LastName},{FirstName},{Age}";
        }

    }
}
