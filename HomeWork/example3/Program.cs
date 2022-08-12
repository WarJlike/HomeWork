Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
string max = "no";
if(number1 % 2 == 0) max = "yes";
Console.WriteLine($"{number1}->{max}");