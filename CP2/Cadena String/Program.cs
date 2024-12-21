Console.WriteLine("Introduzca una palabra");
string word = Console.ReadLine()!;
int medida = word.Length;
Console.WriteLine("Introduzca ahora un numero igual o menor que {0}", medida);
int caracter = Int32.Parse(Console.ReadLine()!);
Console.WriteLine("El caracter que ocupa la posicion {0} es {1}", caracter, word[caracter - 1]);
