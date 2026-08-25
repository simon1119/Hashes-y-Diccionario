using System; // Permite utilizar funciones básicas como Console.
using System.Collections.Generic; // Permite utilizar el tipo Dictionary.

class Program // Creamos la clase principal del programa.
{
    static void Main() // Este es el método donde comienza a ejecutarse el programa.
    {
        // Creamos un diccionario llamado agenda.
        // string = texto para las claves y string = texto para los valores.
        Dictionary<string, string> agenda = new Dictionary<string, string>();

        // Agregamos el primer contacto al diccionario.
        agenda.Add("Carlos", "3001234567");

        // Agregamos el segundo contacto.
        agenda.Add("Maria", "3109876543");

        // Agregamos el tercer contacto.
        agenda.Add("Juan", "3204567890");

        // Le pedimos al usuario que escriba el nombre que quiere buscar.
        Console.Write("Ingrese el nombre del contacto: ");

        // Guardamos lo que escriba el usuario en la variable nombre.
        string nombre = Console.ReadLine();

        // Comprobamos si el nombre existe dentro del diccionario.
        if (agenda.ContainsKey(nombre))
        {
            // Si existe, mostramos el teléfono asociado a ese nombre.
            Console.WriteLine("Teléfono: " + agenda[nombre]);
        }
        else
        {
            // Si no existe, mostramos el mensaje correspondiente.
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}
