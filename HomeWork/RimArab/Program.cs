Console.WriteLine("Введите римское число");
string rim = Console.ReadLine();

int Convert(string str)
{
    int[] arab = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == 'M') arab[i] = 1000;
        else if (str[i] == 'D') arab[i] = 500;
        else if (str[i] == 'C') arab[i] = 100;
        else if (str[i] == 'L') arab[i] = 50;
        else if (str[i] == 'X') arab[i] = 10;
        else if (str[i] == 'V') arab[i] = 5;
        else if (str[i] == 'I') arab[i] = 1;
        else return -1;
    }
    for (int i = 1; i < arab.Length; i++)
    {
        if (arab[i - 1] < arab[i])
        {
            arab[i] -= arab[i - 1];
            arab[i - 1] = 0;
        }
    }
    int sumArab = arab[0];
    for (int i = 1; i < arab.Length; i++)
    {
        sumArab = sumArab + arab[i];
    }
    return sumArab;
}
if (Convert(rim) == -1) Console.WriteLine("Такого числа нет");
else Console.WriteLine($"{rim} -> {Convert(rim)}");