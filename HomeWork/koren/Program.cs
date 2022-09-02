Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

void SqrtArray(int a)
{
    for (int i = 0; i < a; i++)
    {
        if(i * i <= a && (i+1)*(i+1) > a)
        {
           Console.WriteLine($"{i} равен корню из {a}");
        }
    }
}
SqrtArray(n);