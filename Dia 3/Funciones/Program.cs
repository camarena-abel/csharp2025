// // // Ejemplo de funcion sin parametros y que no devuelve nada
// void Saludar()
// {
//     string x = "adios";
//     Console.WriteLine("Hola, mundo!");
// }
// Saludar();

// // Ejemplo de funcion con parametros y que devuelve un valor
// int Sumar(int a, int b)
// {
//     return a + b;
// }
// int x = 3;
// int y = 5;
// Console.WriteLine(Sumar(x, y));
// Console.WriteLine(x);

// // Ejemplo de una funcion que devuelve un valor y tiene parametros nombrados
// int Restar(int a, int b)
// {
//     return a - b;
// }
// Console.WriteLine(Restar(10, 5));
// Console.WriteLine(Restar(b:10, a:5));

// // Ejemplo de funcion con parametro con valor por defecto
// void Saludar(string nombre = "alumno")
// {
//     Console.WriteLine($"Hola, {nombre}!");
// }
// Saludar();
// Saludar("Pepe");

// // Ejemplo de funcion con varios parametros, uno con valor por defecto
// void SaludarEstiloJapones(string nombre, int edad = 18)
// {
//     if (edad >= 18) {
//         Console.WriteLine($"Konnichiwa, {nombre}-san!");
//     } else {
//         Console.WriteLine($"Konnichiwa, {nombre}-chan!");
//     }
// }
// SaludarEstiloJapones("Ana");
// SaludarEstiloJapones("Pepe", 10);
// SaludarEstiloJapones(edad:30, nombre:"Luis");

// // Ejemplo de funcion con parametro por referencia
// void ModificarNumero(ref int numero)
// {
//     numero += 10;
// }

// int n = 10;
// Console.WriteLine($"Fuera de la funcion ANTES: {n}");
// ModificarNumero(ref n);
// Console.WriteLine($"Fuera de la funcion DESPUES: {n}");

// // Parametros out: son parametros a los que la funcion les asignará un valor (no es necesario inicializarlos fuera de la funcion)
// void Operaciones(int a, int b, out int suma, out int resta, out int multiplicacion, out int division)
// {
//     suma = a + b;
//     resta = a - b;
//     multiplicacion = a * b;
//     division = 0;
//     if (b != 0)
//     {
//         division = a / b;
//     }
// }
// int suma, resta, multiplicacion, division;
// Operaciones(10, 20, out suma, out resta, out multiplicacion, out division);
// Console.WriteLine($"Suma: {suma}, Resta: {resta}, Multiplicacion: {multiplicacion}, Division: {division}");

// // Diferencias entre ref y out:
// // ref es una referencia a una variable ya inicializada, out es una referencia a una variable que no necesita estar inicializada
// // ref necesita que la variable esté inicializada antes de pasarla a la funcion, out no
// // ref puede ser usado para pasar un valor a la funcion y devolverlo modificado, out solo puede ser usado para devolver valores desde la funcion

// // Ejemplo de funciones flecha (lambda) y uso de LINQ
// // Hay que usar using System.Linq; para el .Select y el .Where
// bool Filtro(int x)
// {
//     return x > 25;
// }

// Console.WriteLine("Filtrados:");
// int[] numeros = new int[] {10,20,30,40,50};
// var filtrados = numeros.Where(Filtro); // var filtrados = numeros.Where(x => x > 25);
// int[] numFiltrados = filtrados.ToArray();
// foreach (var n in numFiltrados)
// {
//     Console.WriteLine(n);
// }

// int MultiplicaPor2(int x)
// {
//     return x * 2;
// }

// Console.WriteLine("Modificados:");
// var modificados = numeros.Select(MultiplicaPor2); // var modificados = numeros.Select(x => x * 2);
// int[] numModificados = modificados.ToArray();
// foreach (var n in numModificados)
// {
//     Console.WriteLine(n);
// }

// Delegados por defecto
// - Action (si no devuelve nada) 
//     >  Action<string> imprimir = mensaje => Console.WriteLine(mensaje);
// - Predicate (si devuelve un bool)
//     >  Predicate<int> esPar = n => n % 2 == 0;
// - Func (si devuelve otra cosa)
//     >  Func<int, int, int> sumar = (a, b) => a + b;

// Ejemplo de uso de Func como parametro de otra funcion
// float Operacion(Func<float, float, float> callback, float a, float b)
// {    
//     return callback(a, b);
// }

// float Sumar(float a, float b) => a + b;
// float Restar(float a, float b) => a - b;

// Console.WriteLine(Operacion(Sumar, 10f, 20f));
// Console.WriteLine(Operacion(Restar, 10f, 20f));
// Console.WriteLine(Operacion((a,b) => a*b, 10f, 20f));