Console.WriteLine("Введите высоту елочки - ");
int num = int.Parse(Console.ReadLine());


void Method( int x1 )
{
for (int i = 0; i < x1; i++)
{
    for (int j = 0; j <= i; j++)
    {
       Console.SetCursorPosition(50 + j,10 + i);
       Console.WriteLine("*");  
       Console.SetCursorPosition(50 - j,10 + i);
       Console.WriteLine("*");  
    }
}
}
Method(num);