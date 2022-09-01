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

int[,] SortingElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
             for (int h = 0; h < array.GetLength(1) - j; h++)
            {
                if(array[i,h] > array[i,h + 1])
                {
                    int x = array[i,h];
                    array[i,h] = array[i,h + 1];
                    array[i,h + 1] = x;
                }
            }
        }
    }
return array;
}
Console.WriteLine();
PrintArray(SortingElement(finishArray));

