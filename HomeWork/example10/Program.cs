int num = new Random().Next(100, 1000);
Console.Write($"Вторая цифра числа {num} ->{(num/10) % 10}");