// IMPORTANTE: para usar Listas hay que usar System.Collections.Generic!
using System.Collections.Generic;

// Crear una lista de enteros
List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

// Añadir un número al final de la lista
numeros.Add(60);
Console.WriteLine($"Tenemos {numeros.Count} elementos en la lista");
foreach (int numero in numeros)
    Console.WriteLine(numero);

// borramos el de la posicion 3 [el numero 40]
numeros.RemoveAt(3); 
Console.WriteLine($"Tenemos {numeros.Count} elementos en la lista");
foreach (int numero in numeros)
    Console.WriteLine(numero);

// borramos todos los elementos
numeros.Clear(); 
Console.WriteLine($"Tenemos {numeros.Count} elementos en la lista");

// Convertir la lista a un array
int[] num = numeros.ToArray();

