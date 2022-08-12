Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int count = 1;
string line = "";
while(count < (number1 + 1))
{
line = ($"{line}{count * count},");
count++;
}
Console.WriteLine($"{number1}->{line}");