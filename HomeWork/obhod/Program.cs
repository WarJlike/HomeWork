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
    int[] line = new int[mas.GetLength(0) * mas.GetLength(1)];
    int a = 0;
    int min = mas.GetLength(0);
    if(mas.GetLength(1) < mas.GetLength(0)) min = mas.GetLength(1);
    if(min % 2 > 0) min = min +1;
    
    for(int s = 0; s < min/2; s++)
    {
    for (int j = 0 + s; j < mas.GetLength(1) -s; j++)
    {
        line[a] = mas[mas.GetLength(0) - 1 - s, j];
        a++;
    }
    if(a >= line.Length - 1) break;
     for (int i = mas.GetLength(0) -2 -s ; i >= s; i--)
    {
        line[a] = mas[i, mas.GetLength(1) - 1 - s];
        a++;
    }
    if(a >= line.Length - 1) break;
     for (int j = mas.GetLength(1) -2 - s; j >= s; j--)
    {
        line[a] = mas[s, j];
        a++;
    }
    if(a >= line.Length - 1) break;
     for (int i = 1 + s; i < mas.GetLength(0) - 1 -s; i++)
    {
        line[a] = mas[i, s];
        a++;
    }
    if(a >= line.Length - 1) break;
    }
    
return line;
}
Console.WriteLine($"{String.Join(", ", Method3(pro))}");