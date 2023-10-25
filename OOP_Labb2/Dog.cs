using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Dog : Animal
    {
        public string Colour { get; set; }

        public Dog(string name, string scientificName, string gender, float weight, int age, string colour = "Not specified") : base(name, scientificName, gender, weight, age)
        {
            Colour = colour;    
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woff, woff!");
        }

        public void WagTail()
        {
            Console.WriteLine($"{Name} is wagging its tail.");
        }
    }
}
