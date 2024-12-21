//Reciba tres numeros enteros de la consola el de valor medio.(utilice Math.Max y Math.Min) y el promedio de estos.
int a = Int32.Parse(Console.ReadLine()!);
int b = Int32.Parse(Console.ReadLine()!);
int c = Int32.Parse(Console.ReadLine()!);
int d = Math.Max(a, b);
int e = Math.Max(a, c);
int f = Math.Min(d, e);

Console.WriteLine("El valor del medio es {0}", f);
Console.WriteLine("El valor promedio de estos 3 numeros es {0}", (double)(a + b + c) / 3);
