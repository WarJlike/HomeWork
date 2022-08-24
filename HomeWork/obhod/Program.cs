Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());
int[,] Method1(int a, int b)
{
    int[,] mas = new int[a,b];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = new Random().Next(1, 10);
        }
    }
return mas;
}

int[,] pro = Method1(a,b);

void Method2(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
Method2(pro);


int[] Method3( int[,] mas)
{
    int[] line = new int[9];
    int a = 0;
    for(int s = 0; s < 2; s++)
    {
    for (int j = 0 + s; j < mas.GetLength(1) -s; j++)
    {
        line[a] = mas[mas.GetLength(0) - 1 - s, j];
        a++;
    }
    
     for (int i = mas.GetLength(0) -2 -s ; i >= 0; i--)
    {
        line[a] = mas[i, mas.GetLength(1) - 1 - s];
        a++;
    }
    
     for (int j = mas.GetLength(1) -2 - s; j >= 0; j--)
    {
        line[a] = mas[0 + s, j];
        a++;
    }
    
     for (int i = 1 + s; i < mas.GetLength(0) - 1 -s; i++)
    {
        line[a] = mas[i, 0];
        a++;
    }
    }

return line;
}

Console.WriteLine($"{pro[0,0]}");
Console.WriteLine($"{String.Join(", ", Method3(pro))}");