internal class Program
{
    private static void Main(string[] args)
    {
        int number = 198843292;
        List<int> numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (var num in number.ToString())
        {
            numbers[(int)Char.GetNumericValue(num)]++;
        }

        Console.WriteLine("Statystyki cyfr dla liczby " + number + ":");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(i + " => " + numbers[i]);
        }
    }
}