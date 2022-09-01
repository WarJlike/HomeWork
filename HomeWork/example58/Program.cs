Console.WriteLine("Введите количество строк 1 матрицы - ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы - ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 матрицы - ");
int m2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы - ");
int n2 = int.Parse(Console.ReadLine());

if(n1 == m2)
{
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
int[,] Array1 = RandomArray(m1,n1);
int[,] Array2 = RandomArray(m2,n2);

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
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();

int[,] ProductOfMatrices(int[,] array1, int[,] array2)
{ 
    int[,] finishArray = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < finishArray.GetLength(0); i++)
    {
        for (int j = 0; j < finishArray.GetLength(1); j++)
        {
            for (int a = 0; a < array1.GetLength(1); a++)
            {
                  finishArray[i,j] += array1[i,a] * array2[a,j];   
            }
        }
    }
return finishArray;
}
PrintArray(ProductOfMatrices(Array1,Array2));
}
else Console.WriteLine("Задача не имеет решения");