Console.WriteLine("Введите количество строк - ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов - ");
int n = int.Parse(Console.ReadLine());

double[,] RandomArray(int a, int b)
{
    double[,] randomArray = new double[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            randomArray[i,j] = new Random().NextDouble() * 200 - 100;
        }
    }
return randomArray;
}

void PrintArray( double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1} ");
        }
        Console.WriteLine();
    }
  
}
PrintArray(RandomArray(m,n));