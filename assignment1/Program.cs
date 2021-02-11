using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programmers = new Program();
            programmers.Start();
        }

        void Start()
        {
            Programmer programmer = new Programmer("John", Specialty.Csharp);
            //programmer.Print();
            Team team = new Team();
            team.AddProgrammer(new Programmer("Peter", Specialty.Csharp));
            team.AddProgrammer(new Programmer("Kevin", Specialty.Java));
            team.AddProgrammer(new Programmer("John", Specialty.Csharp));
            team.AddProgrammer(new Programmer("Susan", Specialty.Java));

            //team.PrintAllTeamMembers();
            team.AddProgrammer(new Programmer("Emma"));
            team.PrintAllTeamMembers();

            Console.ReadKey();
        }
    }
}