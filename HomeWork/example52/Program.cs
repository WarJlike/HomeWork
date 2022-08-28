Console.WriteLine("Введите количество строк - ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов - ");
int n = int.Parse(Console.ReadLine());

int[,] RandomArray(int a, int b)
{
    int[,] randomArray = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            randomArray[i,j] = new Random().Next(0, 10);
        }
    }
return randomArray;
}
int[,] finishArray = RandomArray(m,n);

void PrintArray( int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
  
}
Console.Clear();
PrintArray(finishArray);

void PrintElement(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    { 
        double sum = 0;
        double ArithmeticMean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        ArithmeticMean = sum / array.GetLength(0);
        Console.Write($"{ArithmeticMean:F1}  ");
    }
}
PrintElement(finishArray);