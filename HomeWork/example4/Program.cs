Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int count = 1;
string line = "";
while(count < (number1 + 1))
{
    if( count % 2 == 0)
    {line = ($"{line}{count},");
     count++;
    }
    else
    {
    count++;
    }
}
Console.WriteLine($"{number1}->{line}");