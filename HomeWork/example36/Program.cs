Console.WriteLine("Введите размер массива - ");
int N = int.Parse(Console.ReadLine());

int[] Method1(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
return(array);
}

int[] arr = Method1(N);

int Method2(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i= i + 2)
    {
        count+= a[i];
    }
    return(count);
}

Console.WriteLine($"В массиве [{String.Join(", ", arr)}] сумма четных чисел {Method2(arr)}");