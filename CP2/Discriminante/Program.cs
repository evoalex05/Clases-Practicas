using System;
Console.WriteLine("Introduzca los coeficientes de la ecuacion cuadratica");
double a = Convert.ToDouble(Console.ReadLine()!);
double b = Convert.ToDouble(Console.ReadLine()!);
double c = Convert.ToDouble(Console.ReadLine()!);

double raiz =  Math.Sqrt(Math.Pow(b, 2) - (4*a*c));
double E = 2*a;

double solucion1 = (0 -b - raiz)/E;
double solucion2 = (0 -b + raiz)/E;

string d = Convert.ToString(solucion1);
string e = Convert.ToString(solucion2);
Console.WriteLine( "Las soluciones de la ecuacion cuadraticas son {0} y {1}", d, e);
