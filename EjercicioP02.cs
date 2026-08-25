using System; // Permite utilizar Console.
using System.Collections.Generic; // Permite utilizar Dictionary.
using System.Linq; // Permite utilizar métodos para ordenar los datos.

class Program // Creamos la clase principal.
{
    static void Main() // Método principal del programa.
    {
        // Pedimos al usuario que escriba una frase.
        Console.Write("Ingrese una frase: ");

        // Guardamos la frase escrita por el usuario.
        string texto = Console.ReadLine();

        // Convertimos todo el texto a minúsculas.
        texto = texto.ToLower();

        // Creamos un diccionario.
        // La clave será una letra y el valor será la cantidad de veces que aparece.
        Dictionary<char, int> frecuencia = new Dictionary<char, int>();

        // Recorremos cada carácter del texto.
        foreach (char letra in texto)
        {
            // Comprobamos que el carácter no sea un espacio.
            if (letra != ' ')
            {
                // Comprobamos si la letra ya existe en el diccionario.
                if (frecuencia.ContainsKey(letra))
                {
                    // Si existe, aumentamos su cantidad en 1.
                    frecuencia[letra]++;
                }
                else
                {
                    // Si no existe, la agregamos con una cantidad inicial de 1.
                    frecuencia.Add(letra, 1);
                }
            }
        }

        // Ordenamos el diccionario de mayor a menor según la cantidad.
        var resultado = frecuencia.OrderByDescending(elemento => elemento.Value);

        // Mostramos un título antes de los resultados.
        Console.WriteLine("\nFrecuencia de las letras:");

        // Recorremos cada elemento ordenado.
        foreach (var elemento in resultado)
        {
            // Mostramos la letra y la cantidad de veces que aparece.
            Console.WriteLine(elemento.Key + " : " + elemento.Value);
        }
    }
}
