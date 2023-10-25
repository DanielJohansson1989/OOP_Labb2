using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Gorilla : Animal
    {
        public float Height { get; set; }

        public Gorilla(string name, string scientificName, string gender, float weight, int age, float height = 0.0f) : base(name, scientificName, gender, weight, age)
        {
            Height = height;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Oh oh oh!");
        }

        public void UseStick()
        {
            Console.WriteLine($"{Name} is using a stick.");
        }
    }
}
