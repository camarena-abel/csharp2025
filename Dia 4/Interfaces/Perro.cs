public class Perro : IAnimal, IMascota
{
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
        Console.WriteLine("El perro está jugando.");
    }    
}