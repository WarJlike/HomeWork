Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());

void Method1(int num)
{
int sum = 0;
string str = num.ToString();
for (int i = 0; i < str.Length; i++)
{
    sum = sum + str[i] -48;
}
Console.WriteLine($"{num} -> {sum}");
}


void Method2(int element)
{
 int element1 = element;
 int sum = 0;
 while(element1 > 0)
 {
    sum = sum + element1 % 10;
    element1 = element1 / 10;
 }
Console.WriteLine($"{element} -> {sum}");
}

Method2(x1);
