List<IAnimal> animales = new List<IAnimal>();
animales.Add(new Gato());
animales.Add(new Perro());
animales.Add(new Leon());
foreach (var animal in animales)
{
    animal.Comer();
    animal.Dormir();
    if (animal is IMascota mascota)
    {
        mascota.Jugar();
    }
}

