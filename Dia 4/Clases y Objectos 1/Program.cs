Coche c1 = new Coche("Toyota", "Corolla", 2020);
c1.SetColor("Rojo");
c1.NumeroDePuertas = 5;  
// Console.WriteLine(
//     $"Coche : {c1.marca} {c1.Modelo} {c1.Anyo} Color: {c1.GetColor()}");

Coche c2 = new Coche("Honda", "Civic", 2019);
c1.SetColor("Verde");
c2.NumeroDePuertas = 3;
// c2.ToString();

Coche c3 = new Coche("Ford", "Focus", 2018);
c3.SetColor("Azul");
c3.NumeroDePuertas = 5;
// c3.ToString();

Console.WriteLine($"Total de coches: {Coche.Count()}");
Coche.Dump();