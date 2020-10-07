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
            Programmer programmer = new Programmer("John", Speciality.Csharp);
            programmer.Print();
            Team team = new Team();
            team.PrintAllTeamMembers();
            team.AddProgammer(new Programmer("Ketchup"));
            team.PrintAllTeamMembers();

            Console.ReadKey();
        }
    }
}
