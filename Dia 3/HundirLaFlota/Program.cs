
﻿int[,] tablero = new int[,]
{
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 }
};

// vamos a colocar barcos al azar
Random rnd = new Random();
int barcos = 3;
int pendientes = barcos;
while (pendientes > 0)
{
    // calculamos posicion horizontal y vertical al azar
    int horizontal = rnd.Next(0, 5);
    int vertical = rnd.Next(0, 5);

    // hay agua (0) o un barco (1) en esa posicion?
    if (tablero[horizontal, vertical] == 0)
    {
        // colocamos un barco (1) en esa posicion
        tablero[horizontal, vertical] = 1;
        pendientes--;
    }
}

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        Console.Write(tablero[f, c] + " ");
    }
    Console.WriteLine();
}

pendientes = barcos;
do
{
    Console.WriteLine("Introduce coordenadas para disparar (horizontal y vertical):");
    int hor = int.Parse(Console.ReadLine());
    int ver = int.Parse(Console.ReadLine());
    var casilla = tablero[ver, hor];
    if (casilla == 1)
    {
        Console.WriteLine("¡Has hundido un barco!");
        tablero[ver, hor] = 0; // marcamos el barco como hundido (ahor hay agua)
        pendientes--;
    }
    else
    {
        Console.WriteLine("Agua.");
    }
} while (pendientes > 0);
Console.WriteLine("¡Has hundido todos los barcos!");