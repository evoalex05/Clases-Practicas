/* Dado que tienes dos numeros guardados en las variables a y b  e intercambiar sus valores
USANDO UNA VARIABLE AUXILIAR
*/
Console.WriteLine("Introduzca dos valores enteros");
int a = Int32.Parse(Console.ReadLine()!);
int b = Int32.Parse(Console.ReadLine()!);
Console.WriteLine("Los valores iniciales son a = {0} y b = {1}", a, b);
int c = a + b;
a = c - a;
b = c - b;
Console.WriteLine($"Los valores ahora de estas son, a = {a} y b = {b}"); 