Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

void SqrtArray(int b)
{
    int a = b;
    int count = -1;
    for (int i = 1; b >= 0; i = i + 2)
    {
        b-= i;
        count++;
    }
    Console.WriteLine($"Целочисленный корень из {a} равен {count}");
}
SqrtArray(n);