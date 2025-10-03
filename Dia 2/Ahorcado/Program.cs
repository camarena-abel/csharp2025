// palabras disponibles
string[] palabras = { "manzana", "banana", "cereza", "durazno", "uva" };

// el ordenador elige una palabra al azar
Random rand = new Random();
int posicion = rand.Next(0, palabras.Length); // 0 a 4
string palabra = palabras[posicion];

// preparamos el placeholder
char[] placeholder = new char[palabra.Length];
for (int i = 0; i < placeholder.Length; i++)
{
    placeholder[i] = '_';
}

// el usuario tiene que adivinar la palabra
string palabraAdivinada;
do
{
    Console.WriteLine("Dime una letra");
    string texto = Console.ReadLine();
    char letra = texto[0]; // obtenemos la primera letra de lo que escriba el usuario

    // comprobamos si la letra está en la palabra
    for (int i = 0; i < palabra.Length; i++)
    {
        // por cada letra de la palabra, comprobamos si es la letra que ha escrito el usuario
        if (palabra[i] == letra)
        {
            // si es así, la ponemos en el placeholder
            placeholder[i] = letra;
        }
    }

    // mostramos el placeholder
    Console.WriteLine(placeholder);

    // el juego termina cuando la palabra del ordenador coincide con el placeholder
    // recuerda que el placeholder es un array de char, asi que hay que convertirlo a string!
    palabraAdivinada = new String(placeholder);
} while (palabra != palabraAdivinada);


