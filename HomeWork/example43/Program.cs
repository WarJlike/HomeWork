Console.WriteLine("Введите k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 = ");
double b2 = double.Parse(Console.ReadLine());

string Method1(double k1, double b1, double k2, double b2)
{
    double x = ( b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string z = $"A({x};{y})";
    return z;
}
Console.WriteLine($"функции y = {k1}x + {b1}, y = {k2}x +{b2} пересекаются в точке {Method1(k1, b1, k2, b2)}");