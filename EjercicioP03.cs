using System; // Permite utilizar Console.
using System.Collections.Generic; // Permite utilizar Dictionary.

class Program // Creamos la clase principal.
{
    static void Main() // Método principal del programa.
    {
        // Creamos un diccionario donde el nombre es la clave
        // y el precio es el valor.
        Dictionary<string, double> productos = new Dictionary<string, double>();

        // Agregamos algunos productos iniciales.
        productos.Add("Arroz", 5000);
        productos.Add("Leche", 4000);
        productos.Add("Pan", 2500);

        // Creamos un ciclo infinito para mantener funcionando el menú.
        while (true)
        {
            // Mostramos las opciones del menú.
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Consultar precio");
            Console.WriteLine("3. Actualizar precio");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");

            // Pedimos al usuario que seleccione una opción.
            Console.Write("Seleccione una opción: ");

            // Guardamos la opción ingresada.
            string opcion = Console.ReadLine();

            // Comprobamos si eligió la opción 1.
            if (opcion == "1")
            {
                // Pedimos el nombre del producto.
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                // Pedimos el precio.
                Console.Write("Precio del producto: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                // Agregamos el producto al diccionario.
                productos[nombre] = precio;
                Console.WriteLine("Producto agregado.");
            }
            else if (opcion == "2")
            {
                // Pedimos el nombre del producto.
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                // Comprobamos si existe la clave.
                if (productos.ContainsKey(nombre))
                {
                    // Mostramos el precio correspondiente.
                    Console.WriteLine("Precio: " + productos[nombre]);
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
            else if (opcion == "3")
            {
                // Pedimos el nombre del producto.
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                // Comprobamos si el producto existe.
                if (productos.ContainsKey(nombre))
                {
                    // Pedimos el nuevo precio.
                    Console.Write("Nuevo precio: ");
                    double nuevoPrecio = Convert.ToDouble(Console.ReadLine());

                    // Actualizamos el precio.
                    productos[nombre] = nuevoPrecio;
                    Console.WriteLine("Precio actualizado.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
            else if (opcion == "4")
            {
                // Pedimos el producto que queremos eliminar.
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                // Comprobamos si existe.
                if (productos.ContainsKey(nombre))
                {
                    // Eliminamos el producto utilizando su clave.
                    productos.Remove(nombre);
                    Console.WriteLine("Producto eliminado.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }
            else if (opcion == "5")
            {
                // Mostramos un mensaje.
                Console.WriteLine("Programa finalizado.");

                // Terminamos el ciclo.
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
