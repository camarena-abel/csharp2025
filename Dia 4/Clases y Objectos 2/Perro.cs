public class Perro : Animal
{
    public string Nombre { get; set; }

    public Perro(string raza, string nombre) : base("Canis", "C. familiaris", raza)
    {
        Nombre = nombre;
    }
}