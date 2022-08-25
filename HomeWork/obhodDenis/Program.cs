int[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int[,] res = new int[sizeX, sizeY];

    for (int i = 0; i < sizeX; i++)

    {
        for (int j = 0; j < sizeY; j++)

        {
            res[i, j] = new Random().Next(minValue, maxValue);

        }



    }

    return res;

}



void PrintArray(int[,] mass1)

{
    for (int i = 0; i < mass1.GetLength(0); i++)

    {
        for (int j = 0; j < mass1.GetLength(1); j++)

        {
            Console.Write($"{mass1[i, j]} ");

        }

        Console.WriteLine();

    }

}



void PrintToString(int[,] mass2)

{
    int StartRow = 0;

    int StartCol = 0;

    int EndRow = mass2.GetLength(0);

    int EndCol = mass2.GetLength(1);



    while (StartRow < EndRow && StartCol < EndCol)

    {
        //нижний ряд

        for (int i = StartCol; i < EndCol; i++)

        {
            Console.Write(mass2[EndRow - 1, i] + " ");

        }

        EndRow--;

        //правый ряд

        for (int i = EndRow; i > StartRow; i--)

        {
            Console.Write(mass2[i - 1, EndCol - 1] + " ");

        }

        EndCol--;

        //верхний ряд

        if (EndRow > StartRow)

        {
            for (int i = EndCol - 1; i >= StartCol; i--)

            {
                Console.Write(mass2[StartRow, i] + " ");

            }

            StartRow++;

        }

        //левый ряд

        if (EndCol > StartCol)

        {
            for (int i = StartRow; i < EndRow; i++)

            {
                Console.Write(mass2[i, StartCol] + " ");

            }

            StartCol++;

        }

    }

}



Console.Write("Введите число строк массива: ");

int countX = int.Parse(Console.ReadLine());

Console.Write("Введите число столбцов массива: ");

int countY = int.Parse(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");

int minNumber = int.Parse(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");

int maxNumber = int.Parse(Console.ReadLine());

int[,] array = GetArray(countX, countY, minNumber, maxNumber);

PrintArray(array);

Console.WriteLine();

PrintToString(array);

Console.WriteLine();

