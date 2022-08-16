Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string res = "";
for (int i = 1; i <= num; i++)
{
    res = res + ($" {Math.Pow(i,3)},");
}
Console.WriteLine($"{num} ->{res}");