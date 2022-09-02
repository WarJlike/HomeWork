Console.WriteLine("Введите m - ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n - ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите o - ");
int o = int.Parse(Console.ReadLine());

int[,,] RandomArray(int a, int b, int c)
{
    int[,,] randomArray = new int[a,b,c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
              randomArray[i,j,k] = new Random().Next(10, 100);  
            }
            
        }
    }
return randomArray;
}
int[,,] finishArray = RandomArray(m,n,o);

void PrintArray( int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
            Console.WriteLine($"{array[i,j,k]}({i},{j},{k}) ");
           } 
        }
    }
  
}
Console.Clear();
PrintArray(finishArray);