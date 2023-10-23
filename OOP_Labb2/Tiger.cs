using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Tiger : Animal
    {
        public float Length { get; set; }

        public Tiger(string name, string scientificName, string gender, float weight, int age, float length = 0.0f) : base (name, scientificName, gender, weight, age)
        {
            Length = length;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Grrrrrrr!");
        }

        public void Crouch()
        {
            Console.WriteLine($"{Name} is crouching behind a rock.");
        }
    }
}
