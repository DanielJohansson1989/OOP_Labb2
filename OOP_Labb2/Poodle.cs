using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Poodle : Dog
    {
        public bool IsGroomed { get; set; }

        public Poodle(string name, string scientificName, string gender, float weight, int age, string colour, bool isGroomed = false) : base(name, scientificName, gender, weight, age, colour)
        {
            IsGroomed = isGroomed;
        }

        public void StandOnHindLegs()
        {
            Console.WriteLine($"{Name} is balancing on its hind legs.");
        }
    }
}
