public class Animal
{
    public string Genero { get; set; }
    public string Especie { get; set; }
    public string Raza { get; set; }

    public Animal(string genero, string especie, string raza)
    {
        Genero = genero;
        Especie = especie;
        Raza = raza;
    }

    public void Comer()
    {
        Console.WriteLine($"El {Especie} hace ñam ñam");
    }

    // este metodo esta definido 2 veces!
    // pero con diferentes parametros
    // esto se llama sobrecarga de metodos
    public void Comer(string comida)
    {
        Console.WriteLine($"El {Especie} come {comida}");
    }

    public virtual void Dormir()
    {
        Console.WriteLine($"El {Especie} hace zZzZzZ");
    }

    public string ToString()
    {
        return $"Genero: {Genero}, Especie: {Especie}, Raza: {Raza}";
    }
}