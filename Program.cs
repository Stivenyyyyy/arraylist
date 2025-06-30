
//El siguiente programa lee cinco numeros y al final indica el mayor y el menor 
//Y la suma de los elementos
ArrayList lista = new();
Console.Write("Ingrese un numero separados por espacio: ");
lista.AddRange(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
lista.Sort();
Console.WriteLine($"Maximo: {((int[])lista.ToArray(typeof(int))).Max()}");
Console.WriteLine($"Minimo: {((int[])lista.ToArray(typeof(int))).Min()}");
Console.WriteLine($"Suma: {lista.OfType<int>().Sum()}");
