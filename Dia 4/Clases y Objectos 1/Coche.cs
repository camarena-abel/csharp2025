using System.Drawing;

public class Coche
{
    // propiedades estaticas (pertenecen a la clase!)
    private static int contadorDeCoches = 0;
    private static List<Coche> coches = new List<Coche>();

    // esto es un campo, es public y accesible desde fuera
    public string marca;
    // esto NO es un campo, es una propiedad
    // fijate que la primera letra es mayusculas
    public string Modelo { get; set; }

    // esto tambien es una propiedad
    public int Anyo { get; set; }

    // esto es un campo privado, no es accesible desde fuera
    private string color;

    // este par es otra forma de hacer una propiedad
    // fijate como la misma variable se define como 
    // privada y como publica pero con la inicial diferente    
    private int numeroDePuertas;

    public static int Count()
    {
        return contadorDeCoches;
    }

    public static void Dump()
    {
        foreach (Coche c in coches)
        {
            c.ToString();
        }
    }

    public void ToString()
    {
        Console.WriteLine($"Coche : {marca} {Modelo} {Anyo} Color: {GetColor()} Puertas: {numeroDePuertas}");
    }
    
    public int NumeroDePuertas
    {
        get { return numeroDePuertas; }
        set { numeroDePuertas = value; }
    }

    // este es el constructor
    public Coche(string marcaCoche, string modeloCoche, int anyoCoche)
    {
        marca = marcaCoche;
        Modelo = modeloCoche;
        Anyo = anyoCoche;
        Coche.contadorDeCoches++;
        coches.Add(this);
    }

    // estos metodos me permiten modificar un campo privado
    public void SetColor(string c)
    {
        color = c;
    }

    public string GetColor()
    {
        return color;
    }
}