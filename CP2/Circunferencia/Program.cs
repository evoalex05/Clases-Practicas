Console.WriteLine("Introduzca el radio de la circunferencia");
double rad = double.Parse(Console.ReadLine()!);
double Asc = (2 * Math.PI * rad * rad) / 3;
double Ate = (Math.Sqrt(3) * rad * rad) / 2;
double Ac = Asc - Ate;
Console.WriteLine($"El area de dicho circulo es {Ac}");

