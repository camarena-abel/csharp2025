do
{
    Random r = new Random();
    int ordenador = r.Next(1, 4); // del 1 al 3

    Console.WriteLine("Salir del Juego, Piedra, Papel o Tijeras? (0, 1, 2, 3)");
    int usuario = int.Parse(Console.ReadLine());

    // opcion del ordenador
    switch (ordenador)
    {
        case 1:
            Console.WriteLine("El ordenador ha elegido Piedra");
            break;
        case 2:
            Console.WriteLine("El ordenador ha elegido Papel");
            break;
        case 3:
            Console.WriteLine("El ordenador ha elegido Tijeras");
            break;
    }

    // quien gana?
    switch (usuario)
    {
        case 1: // Piedra

            switch (ordenador)
            {
                case 1:
                    Console.WriteLine("Empate");
                    break;
                case 2:
                    Console.WriteLine("Has perdido");
                    break;
                case 3:
                    Console.WriteLine("Has ganado");
                    break;
            }
            break;
        case 2: // Papel

            switch (ordenador)
            {
                case 1:
                    Console.WriteLine("Has ganado");
                    break;
                case 2:
                    Console.WriteLine("Empate");
                    break;
                case 3:
                    Console.WriteLine("Has perdido");
                    break;
            }
            break;
        case 3: // Tijera

            switch (ordenador)
            {
                case 1:
                    Console.WriteLine("Has perdido");
                    break;
                case 2:
                    Console.WriteLine("Has ganado");
                    break;
                case 3:
                    Console.WriteLine("Empate");
                    break;
            }
            break;
        default:
            Console.WriteLine("Gracias por jugar");
            return;
    }

} while (true);
