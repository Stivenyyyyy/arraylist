using System.Collections;

ArrayList lista = new();
Console.Write("Ingrese un numero separados por espacio: ");
lista.AddRange(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
lista.Sort();
Console.WriteLine($"Maximo: {((int[])lista.ToArray(typeof(int))).Max()}");
Console.WriteLine($"Minimo: {((int[])lista.ToArray(typeof(int))).Min()}");

