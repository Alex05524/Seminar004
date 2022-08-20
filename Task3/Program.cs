Console.Write("Введите числа через запятую: ");
string? SerOfNum = Console.ReadLine();
SerOfNum = SerOfNum + ",";

string RemovingSpaces(string Ser)
{
    string SerNew = " ";
    for (int i = 0; i < Ser.Length; i++)
    {
        if (Ser[i] != ' ')
        {
            SerNew += Ser[i];
        }
    }
    return SerNew;
}

void СheckNumber2(int S)
{
    if (S == '0' || S == '1' || S == '2'
    || S == '3' || S == '4' || S == '5' || S == '6'
    || S == '7' || S == '8' || S == '9' || S == ','
    || S == '-')
    {

    }
    else Console.WriteLine($"Ошибка");
}

int[] ArrayOfNumbers(string SerNew)
{
  int[] arrayOfNumbers = new int[1];
  int j = 0;
  
  for (int i = 0; i < SerNew.Length; i++)
  {
    string SerNew1 = "";
    
    while(SerNew[i] != ',' && i < SerNew.Length)
        {
            SerNew1 += SerNew[i];
            СheckNumber2(SerNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(SerNew1);
        if (i < SerNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
        }
        j++;
    }
    return arrayOfNumbers;
}

void PrintArry(int[] col)
{
    int count = col.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(col[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string SerNew = RemovingSpaces(SerOfNum);
int[] arrayOfNumbers = ArrayOfNumbers(SerNew);
PrintArry(arrayOfNumbers);