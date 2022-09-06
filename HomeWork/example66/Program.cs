Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

int Method(int N, int M)
{   
    int sum = 0;
    if(N > M) return 0 ;
    sum = N + Method(N + 1, M);
    return sum;

    //return N > M ? 0 : sum = N + Method(N + 1, M);
}

Console.WriteLine(Method(n, m));