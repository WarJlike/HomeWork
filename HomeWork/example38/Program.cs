Console.WriteLine("Введите размер массива - ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое число массива - ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое число массива - ");
int max = int.Parse(Console.ReadLine());
double[] Method1(int a)
{
    double[] array = new double[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        int num = new Random().Next(min, max);
        array[i] = array[i] + num;
    }
return(array);
}

double[] arr = Method1(N);

double Method2(double[] a)
{
    double sum = 0;
    double max = a[0];
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if(a[i] > max) max = a[i];
        if(a[i] < min) min = a[i];
    }
sum = max - min;
return(sum);
        
}

Console.WriteLine($"В массиве [{String.Join(", ", arr)}] разница максимального и минимального числа равна  {Method2(arr):f3}");