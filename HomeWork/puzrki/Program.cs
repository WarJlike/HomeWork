Console.WriteLine("Введите размер массива - ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое число массива - ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое число массива - ");
int max = int.Parse(Console.ReadLine());
int[] Method1(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
return(array);
}

int[] arr = Method1(N);

int[] Method2(int[] a)
{
    for (int i = 1; i < a.Length; i++)
    {
        for (int j = 0; j < a.Length - i; j++)
        {
            if(a[j] < a[j + 1])
            {
            int x = a[j];
            a[j] = a[j+1];
            a[j+1] = x;
            }
        }
    }
return(a);
}

Console.WriteLine($"[{String.Join(", ", arr)}]-->[{String.Join(", ", Method2(arr))}]");