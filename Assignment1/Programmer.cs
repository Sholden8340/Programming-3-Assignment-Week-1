using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Programmer
    {
        public Speciality Speciality { get; set; }
        public String Name { get; set; }

        public Programmer(String name, Speciality speciality)
        {
            this.Name = name;
            this.Speciality = speciality;
        }
        public Programmer(String name) : this(name, Speciality.Unknown) {}

        public override String ToString()
        {
            return String.Format("Name: {0} \t Speciality: {1}\n", this.Name, this.Speciality.ToString());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
