void SumNumbers()
{
    Console.Write("Число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int Summ(int a)
    {
        int count = Convert.ToString(a).Length;
        int advance = 0;
        int result = 0;
        for (int i = 0; i < count; i++)
        {
            advance = a - a % 10;
            result = result + (a - advance);
            a = a / 10;
            }
            return result;
            }
            int summ = Summ(a);
            Console.WriteLine("Результат: " + summ);
}
SumNumbers();