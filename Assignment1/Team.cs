using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Team
    {

        public List<Programmer> Programmers { get; private set; }
        public Team()
        {
            Programmers = new List<Programmer>
            {
                new Programmer("Gred", Speciality.PHP),
                new Programmer("Andy", Speciality.Csharp),
                new Programmer("Jackson", Speciality.HTML),
                new Programmer("Horseraddish", Speciality.Java)
            };
        }

        public void AddProgammer(Programmer p)
        {
            Programmers.Add(p);
        }

        public override String ToString()
        {
            String team = null;
            foreach (Programmer p in Programmers)
            {
                team += p.ToString();
            }
            return team;
        }

        public void PrintAllTeamMembers()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
