// // Definir un array
// string[] animales;
// int[] numeros;

// // Asignarle un tamaño
// animales = new string[5];
// numeros = new int[10];

// // Crear y asignar tamaño al mismo tiempo
// string[] animales = new string[5];

// // Asignar valores/Leer valores
// animales[0] = "Perro";
// animales[1] = "Gato";
// animales[2] = "Tortuga";
// animales[3] = "Loro";
// animales[4] = "Pez";

// Crear el array, asignarle un tamaño y los valores todo de golpe
string[] animales = new string[] { "Perro", "Gato", "Tortuga", "Loro", "Pez" };
for (int i = 0; i < animales.Length; i++)
{
    string animal = animales[i];
    Console.WriteLine(animal);
}

// Propiedades y metodos de los arrays
Console.WriteLine($"Hay {animales.Length} animalitos");

// La clase array tiene algunos metodos utiles
Array.Sort(animales);     // Ordena alfabeticamente
Array.Reverse(animales);  // Le damos la vuelta

foreach (string animal in animales)
{
    Console.WriteLine(animal);
}

