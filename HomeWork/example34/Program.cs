Console.WriteLine("Введите размер массива - ");
int N = int.Parse(Console.ReadLine());

int[] Method1(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
return(array);
}

int[] arr = Method1(N);

int Method2(int[] a)
{
    int count = 0;
    foreach (int el in a)
    {
        count+= el % 2 == 0 ? 1 : 0;
    }
    return(count);
}

Console.WriteLine($"В массиве [{String.Join(", ", arr)}] -> {Method2(arr)} четных чисел");