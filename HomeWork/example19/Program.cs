Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());
if(num/10000 == num % 10 && (num/1000) % 10 == (num / 10) % 10)
{
    Console.Write($"{num} -> да");
}
else
{
    Console.Write($"{num} -> нет");
}