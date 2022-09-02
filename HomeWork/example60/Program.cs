Console.WriteLine("Введите m - ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n - ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите o - ");
int o = int.Parse(Console.ReadLine());
if (m * n * o <= 90)
{
    int[] workArray = new int[90];
    for (int i = 0; i < workArray.Length; i++)
    {
      workArray[i] = 10 + i;
    }


    int[,,] RandomArray(int a, int b, int c, int[] array)
    {
        int[,,] randomArray = new int[a, b, c];
        int p = 1;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    int d = new Random().Next(0, array.Length -p);
                    randomArray[i, j, k] = array[d];
                    array[d] = array[array.Length - p];
                    p++;
                }

            }
        }
        return randomArray;
    }
    int[,,] finishArray = RandomArray(m, n, o, workArray);

    void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ");
                }
            }
        }

    }

    Console.Clear();
    PrintArray(finishArray);
}
else Console.WriteLine("Задача не имеет решения");