namespace OOP_Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger1 = new Tiger("Felix", "Panthera tigris", "Male", 185.4f, 5, 205.8f);

            Console.WriteLine($"Name: {tiger1.Name}\nScientific name: {tiger1.ScientificName}\nGender: {tiger1.Gender}\nWeight: {tiger1.Weight}\nAge: {tiger1.Age}\nLength: {tiger1.Length}");

            tiger1.MakeSound();
            tiger1.Eat();
            tiger1.Sleep();
            tiger1.Crouch(); 
            Console.WriteLine();


            Gorilla gorilla1 = new Gorilla("Sara", "Gorilla gorilla", "Female", 83.5f, 7, 135.3f);
            Console.WriteLine($"Nme: {gorilla1.Name}\nScientific name: {gorilla1.ScientificName}\nGender: {gorilla1.Gender}\nWeight: {gorilla1.Weight}\nAge: {gorilla1.Age}\nHeight: {gorilla1.Height}");

            gorilla1.MakeSound();
            gorilla1.UseStick();
            Console.WriteLine();


            Chowchow dog1 = new Chowchow("Pluto", "Canis familiaris", "Male", 30.5f, 10, "Brown");

            Console.WriteLine($"Name: {dog1.Name}\nScientific name: {dog1.ScientificName}\nGender: {dog1.Gender}\nWeight: {dog1.Weight}\nAge: {dog1.Age}\nColour: {dog1.Colour}\nTongue colour: {dog1.TongueColour}");

            dog1.MakeSound();
            dog1.ChaseTail();
            dog1.WagTail();
            Console.WriteLine();


            Poodle dog2 = new Poodle("Lady", "Canis familiaris", "Female", 20.9f, 5, "Black", true);

            Console.WriteLine($"Name: {dog2.Name}\nScientific name: {dog2.ScientificName}\nGender: {dog2.Gender}\nWeight: {dog2.Weight}\nAge: {dog2.Age}\nColour: {dog2.Colour}\nIt is groomed: {dog2.IsGroomed}");

            dog2.WagTail();
            dog2.StandOnHindLegs();
        }
    }
}