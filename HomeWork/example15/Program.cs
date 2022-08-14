Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());
if(num == 6 || num == 7)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}
