public class Gato : IAnimal, IMascota
{
    public void Maullar()
    {
        Console.WriteLine("El gato está maullando.");
    }

    public void Comer()
    {
        Console.WriteLine("El gato está comiendo.");
    }

    public void Dormir()
    {
        Console.WriteLine("El gato está durmiendo.");
    }

    public void Jugar()
    {
        Console.WriteLine("El gato está jugando.");
    }
}