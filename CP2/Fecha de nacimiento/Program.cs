Console.WriteLine("Introduzca su carnet de identidad:");
long carnet = long.Parse(Console.ReadLine()!);
int date = (int)(carnet /100000);
int year = date / 10000;
int month = date / 100 % 100;
int day = date % 100;
Console.WriteLine($"La fecha de nacimiento es {day}/{month}/{year}");


