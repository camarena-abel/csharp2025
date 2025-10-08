public class Gato : Animal
{
    public string Nombre { get; set; }

    public Gato(string raza, string nombre) : base("Felis", "F. catus", raza)
    {
        Nombre = nombre;
    }

    public void HacerCuquerias()
    {
        Console.WriteLine($"El gato {Nombre} está haciendo cuquerías");
    }

    public override void Dormir()
    {
        Console.WriteLine($"{Nombre} caza por las noches!");
        Console.WriteLine("Y despues...");
        base.Dormir();
    }
}