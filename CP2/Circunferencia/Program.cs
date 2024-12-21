Console.WriteLine("Introduzca el radio de la circunferencia");
double rad = double.Parse(Console.ReadLine()!);
double Asc = (Math.PI * Math.Pow(rad, 2) * 60)/360;
double Ate = (Math.Pow(rad, 2) * Math.Cbrt(3))/8;
double Ac = 4*(Asc - Ate);
Console.WriteLine($"El area de dicho circulo es {Ac}");
