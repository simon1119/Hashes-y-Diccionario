using System; // Permite utilizar Console.
using System.Collections.Generic; // Permite utilizar Dictionary y List.

class Program // Creamos la clase principal.
{
    static void Main() // Método principal del programa.
    {
        // Creamos una lista de estudiantes.
        // Cada estudiante tendrá un nombre y un curso.
        List<(string nombre, string curso)> estudiantes =
            new List<(string nombre, string curso)>();

        // Agregamos el primer estudiante.
        estudiantes.Add(("Camila", "11A"));

        // Agregamos el segundo estudiante.
        estudiantes.Add(("Julián", "11B"));

        // Agregamos el tercer estudiante.
        estudiantes.Add(("Valentina", "11A"));

        // Agregamos el cuarto estudiante.
        estudiantes.Add(("Andrés", "11B"));

        // Agregamos el quinto estudiante.
        estudiantes.Add(("Laura", "11C"));

        // Creamos un diccionario.
        // La clave será el curso y el valor será una lista de nombres.
        Dictionary<string, List<string>> cursos =
            new Dictionary<string, List<string>>();

        // Recorremos todos los estudiantes de la lista.
        foreach (var estudiante in estudiantes)
        {
            // Guardamos el curso del estudiante en una variable.
            string curso = estudiante.curso;

            // Guardamos el nombre del estudiante.
            string nombre = estudiante.nombre;

            // Comprobamos si el curso ya existe en el diccionario.
            if (cursos.ContainsKey(curso))
            {
                // Si existe, agregamos el nombre a la lista de ese curso.
                cursos[curso].Add(nombre);
            }
            else
            {
                // Si no existe, creamos una nueva lista.
                cursos[curso] = new List<string>();

                // Agregamos el primer estudiante de ese curso.
                cursos[curso].Add(nombre);
            }
        }

        // Mostramos un título.
        Console.WriteLine("Estudiantes por curso:");

        // Recorremos cada curso del diccionario.
        foreach (var curso in cursos)
        {
            // Mostramos el nombre del curso.
            Console.WriteLine(curso.Key + ":");

            // Recorremos la lista de estudiantes de ese curso.
            foreach (string nombre in curso.Value)
            {
                // Mostramos el nombre del estudiante.
                Console.WriteLine(" - " + nombre);
            }
        }
    }
}
