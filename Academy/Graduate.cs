using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Graduate : Student
    {
        public string Subject { get; set; }
        public Graduate(string lastName, string firstName,int age,
            string speciality,string group,double rating,double attendance,
            string subject) : base(lastName,firstName,age,speciality,group,rating,attendance)
        {
            this.Subject = subject;
            Console.WriteLine($"GConstructor:\t{GetHashCode()}");
        }
        public Graduate(Student student,string subject) : base(student)
        {
            this.Subject = subject;
        }

        public Graduate(Graduate other):base(other)
        {
            this.Subject = other.Subject;
        }
        ~Graduate()
        {
            Console.WriteLine($"GDestructor:\t{GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $" \"{Subject}\"";
        }

        public override string ToFileSring()
        {
            return base.ToFileSring()+$",{Subject}";
        }
    }
}
