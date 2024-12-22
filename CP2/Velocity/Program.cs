Console.WriteLine("Introduzca una oracion:");
int time = Environment.TickCount;
string text = Console.ReadLine()!;
int time2 = Environment.TickCount;
int result = time2 - time;
Console.WriteLine($"Se ha demorado{result}");


