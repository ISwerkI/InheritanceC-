using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Teacher: Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public Teacher
        (
                string lastName, string firstName, int age,
                string speciality, int experience
        ) : base(lastName, firstName, age)
        {
            this.Speciality = speciality;
            this.Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Speciality} {Experience}";
        }
    }
}
