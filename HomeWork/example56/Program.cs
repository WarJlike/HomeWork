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

int MinimalSummElement(int[,] array)
{ 
    int minimalString = 1;
    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min+= array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int summElementString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           summElementString+= array[i,j];
        }
          if(summElementString < min)
          {
            min = summElementString;
            minimalString = i + 1;
          } 
    }
return minimalString;
}

int[] PrintElementString(int[,] array, int minStringIndex)
{
    int[] monoArray = new int[array.GetLength(1)];
    for (int j = 0; j < monoArray.Length; j++)
    {
        monoArray[j] = array[minStringIndex - 1, j];
    }
return monoArray;
}
int[] monoArray = PrintElementString(finishArray,MinimalSummElement(finishArray));
Console.WriteLine($"{MinimalSummElement(finishArray)} строка с элементами [{String.Join(",", monoArray)}] является минимальной в матрице");