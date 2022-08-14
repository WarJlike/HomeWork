Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());
if(num > 99)
{
    Console.WriteLine($"{num} -> {(num/100) %10}");
}
else
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
