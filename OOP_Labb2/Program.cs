namespace OOP_Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger1 = new Tiger("Felix", "Panthera tigris", "Male", 185.4f, 5, 205.8f);

            Console.WriteLine($"{tiger1.Name}\n{tiger1.ScientificName}\n{tiger1.Gender}\n{tiger1.Weight}\n{tiger1.Age}\n{tiger1.Length}");

            tiger1.MakeSound();
            tiger1.Eat();
            tiger1.Sleep();
        }
    }
}