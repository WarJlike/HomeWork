Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());
int x = 1;
while (x < 1000)
{
    if (num / 10000 * x % 10 == num / x % 10)
    {
        x = x * 10;
    }
    else
    {
        Console.Write($"{num} -> нет");
        break;
    }
Console.Write($"{num} ->да");
break;
}