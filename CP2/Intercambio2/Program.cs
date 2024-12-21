/* Dado que tienes dos numeros guardados en las variables a y b  e intercambiar sus valores SIN
USAR UNA VARIABLE AUXILIAR
*/
Console.WriteLine("Introduzca dos valores enteros");
int a = Int32.Parse(Console.ReadLine()!);
int b = Int32.Parse(Console.ReadLine()!);
Console.WriteLine("Los valores introducidos son a = {0} y b = {1}", a, b);
a = a + b;
b = a - b;
a = a - b; 
Console.WriteLine($"Los valores intercambiados de estos son a = {a} y b = {b}");
