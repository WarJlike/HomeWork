Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int max = 0;
if(number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
Console.WriteLine($" a={number1},b={number2}->max={max}");