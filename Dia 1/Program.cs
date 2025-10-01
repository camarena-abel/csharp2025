Random r = new Random();
int n = r.Next(1, 21); // del 1 al 20
Console.WriteLine("Adivina el número (entre 1 y 20):");
int usuario;
do
{
    usuario = int.Parse(Console.ReadLine());
    if (usuario < n)
    {
        Console.WriteLine("El número es mayor");
    }
    else if (usuario > n)
    {
        Console.WriteLine("El número es menor");
    }
} while (n != usuario);
Console.WriteLine("Enhorabuena! Has acertado el número!");