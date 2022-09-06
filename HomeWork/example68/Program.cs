Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

int Method(int M, int N)
{   
   int akkerman = 0;
   if(M == 0) akkerman = N +1;
   else if(M > 0 && N == 0) akkerman =  Method(M - 1, 1);
   else if(M > 0 && N > 0) akkerman = Method(M - 1, Method(M, N -1));
return akkerman;
}

Console.WriteLine(Method(n, m));