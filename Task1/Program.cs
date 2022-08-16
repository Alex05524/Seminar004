void PowerDeg()
{
int NaturalDegree(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;
        }
        return result;
        }

  Console.Write("Число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int exp = NaturalDegree(A, B);
  Console.WriteLine("Результат: " + exp);
}
PowerDeg();