Console.WriteLine("Введите строку искомого элемента - ");
int StringElement = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента - ");
int ColumnElement = int.Parse(Console.ReadLine());

int m = new Random().Next(1,10);
int n = new Random().Next(1,10);

int[,] RandomArray(int a, int b)
{
    int[,] randomArray = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            randomArray[i,j] = new Random().Next(-99, 100);
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

void PrintElement(int[,] array, int a, int b)
{
    if(a < array.GetLength(0) && b < array.GetLength(1))
    {
         Console.WriteLine($"Элемент под номером ({StringElement};{ColumnElement}) равен {array[a,b]}");
    }
    else Console.WriteLine("Элемента с таким номером в массиве не существует");
}

PrintElement(finishArray, StringElement, ColumnElement);