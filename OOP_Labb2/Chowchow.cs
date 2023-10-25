using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Chowchow : Dog
    {
        public string TongueColour { get; set; }

        public Chowchow(string name, string scientificName, string gender, float weight, int age, string colour, string tongueColour = "Blue") : base (name, scientificName, gender, weight, age, colour)
        {
            TongueColour = tongueColour;
        }

        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is spinning around chasing its tail.");
        }
    }
}
