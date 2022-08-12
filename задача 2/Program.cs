Console.WriteLine("Введите номер дня");
int number = int.Parse(Console.ReadLine());
string day = "такого дня нет";

if(number == 1) day = "понедельник";
if(number == 2) day = "вторник";
if(number == 3) day = "среда";
if(number == 4) day = "четверг";
if(number == 5) day = "пятница";
if(number == 6) day = "суббота";
if(number == 7) day = "воскресенье";
Console.WriteLine($"{number}->{day}");