using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class Animal
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string Gender { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name = "Not specified", string scientificName = "Not specified", string gender = "Not specified", float weight = 0.0f, int age = 0)
        {
            Name = name;
            ScientificName = scientificName;
            Gender = gender;
            Weight = weight;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"...");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
}
