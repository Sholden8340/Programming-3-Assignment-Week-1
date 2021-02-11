using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Programmer
    {
        private Specialty Specialty { get; set; }
        private String Name { get; set; }

        public Programmer(String name, Specialty specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }

        public Programmer(String name) : this(name, Specialty.Unknown)
        {
        }

        public override String ToString()
        {
            return String.Format("Name: {0}, Specialty: {1}\n", this.Name, this.Specialty.ToString());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}