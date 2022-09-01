int[,] workArray = new int[4,4];
int[,] FillArray( int[,] mas)
{
    
    int a = 1;
    int min = mas.GetLength(0);
    if(mas.GetLength(1) < mas.GetLength(0)) min = mas.GetLength(1);
    if(min % 2 > 0) min = min +1;
    
    for(int s = 0; s < min/2; s++)
    {
    for (int j = s; j < mas.GetLength(1) -s; j++)
    {
        
        mas[s, j] = a;
        a++;
    }
    if(a > mas.GetLength(0)*mas.GetLength(1)) break;
    
     
     for (int i = 1 + s; i < mas.GetLength(0) - 1 -s; i++)
    {
       
        mas[i, mas.GetLength(1) - 1 - s] = a;
        a++;
    }
    if(a > mas.GetLength(0)*mas.GetLength(1)) break;
     for (int j = mas.GetLength(1) -1 - s; j >= s; j--)
    {
        mas[mas.GetLength(0) - 1 - s, j] = a;
        a++;
    }
    if(a > mas.GetLength(0)*mas.GetLength(1)) break;
     for (int i = mas.GetLength(0) - 2 -s; i > s; i--)
    {
        mas[i, s] = a;
        a++;
    }
    if(a > mas.GetLength(0)*mas.GetLength(1)) break;
    }
    
return mas;
}

void PrintArray( int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            if( array[i,j]> 9) Console.Write($"{array[i,j]} ");
            else
            {
                int decimalLength = array[i,j].ToString("D").Length + 1;
                Console.Write($"{array[i,j].ToString("D" + decimalLength.ToString())} ");
            }
        }
        Console.WriteLine();
    }
  
}
Console.Clear();
PrintArray(FillArray(workArray));