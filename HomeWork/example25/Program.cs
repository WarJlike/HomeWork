Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());

void Method1(int num1, int num2)
{
int sum = 1;
for (int i = 1; i <= num2; i++)
{
    sum = sum * num1;
}
Console.WriteLine($"{num1}, {num2} -> {sum}");
}

Method1(x1,y1);