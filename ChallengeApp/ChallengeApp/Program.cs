internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Dominik";
        int age = 17;
        char sex = 'M';

        if (age < 30 && sex == 'K')
        {
            Console.WriteLine("Kobieta poniżej 30 lat");
        }
        else if (name == "Ewa" && age == 30)
        {
            Console.WriteLine("Ewa. lat 30");
        }
        else if (age < 18 && sex == 'M')
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }
    }
}