// - Haz una funcion que calcule la division entre 2 numeros, la funcion debe:
//   - Devolver true o false si la division es posible (division entre cero)
//   - En un parametro debe de devolver el resultado de la division (0 si no es posible)
//   - En otro parametro debe de devoler el resto (0 si no es posible)

bool DivisionEntera(int a, int b, out int resultado, out int resto)
{
    // le damos un valor inicial
    resultado = 0;
    resto = 0;    

    // si no se puede dividir, salimos
    if (b == 0)
        return false;

    // calculamos la division y el resto
    resultado = a / b;
    resto = a % b;

    // todo ok!
    return true;
}

int resultado, resto;
DivisionEntera(105, 4, out resultado, out resto);
Console.WriteLine($"Resultado: {resultado}, Resto: {resto}");