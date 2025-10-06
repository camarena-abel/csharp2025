// - Haz una funcion para pedir un numero entre un minimo y un maximo (con mensaje personalizado por parametro)
//   - Añade al ejecicio un valor por defecto de 1 para el minimo y 10 para el maximo

int PedirNumero(string mensaje, int minimo = 1, int maximo = 10)
{
    int numero;
    do
    {
        Console.WriteLine(mensaje);
        numero = int.Parse(Console.ReadLine());
    } while (numero < minimo || numero > maximo);
    return numero;
}

if (PedirNumero("Dime tu edad", 1, 120) > 18) {
    Console.WriteLine("Eres mayor de edad");
} else {
    Console.WriteLine("Eres menor de edad");
}
int favo = PedirNumero("Dime tu número favorito del 1 al 10");
Console.WriteLine($"Tu número favorito es {favo}");
