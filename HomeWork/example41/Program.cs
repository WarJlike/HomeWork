Console.WriteLine("Введите количество чисел -  ");
int N = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i < N +1; i++)
{
    Console.WriteLine($"Введите {i} число -  ");
    int x = int.Parse(Console.ReadLine());
    
    if(x > 0) count++;
}
Console.WriteLine($"пользователь ввел {count} чисел больше 0");