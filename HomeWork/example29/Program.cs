Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine());

void Method54(int arr, int min, int max)
{
    int[] array = new int[arr];
    //string poo = String.Empty;

    for (int i = 0; i < arr; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    for (int i = 0; i < arr; i++)
    {
       //poo = ($"{poo} {array[i]}," );
       Console.Write($"{array[i]}, ");

    }
    //Console.WriteLine(poo);
}

Method54(N, a, b);
