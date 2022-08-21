internal class Program
{
    private static void Main(string[] args)
    {
        int input;
        do
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("{0}", Convert.ToString(input, 2));
            }
            Console.WriteLine();
        }
        while (true);
    }
}