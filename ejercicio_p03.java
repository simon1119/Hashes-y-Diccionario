import java.util.HashMap;
import java.util.Scanner;

public class ejercicio_p03 {
    public static void main(String[] args) {
        HashMap<String, Double> productos = new HashMap<>();

        productos.put("Arroz", 5000.0);
        productos.put("Leche", 4000.0);
        productos.put("Pan", 2500.0);

        Scanner entrada = new Scanner(System.in);

        while (true) {
            System.out.println("\n--- MENÚ ---");
            System.out.println("1. Agregar producto");
            System.out.println("2. Consultar precio");
            System.out.println("3. Actualizar precio");
            System.out.println("4. Eliminar producto");
            System.out.println("5. Salir");

            System.out.print("Seleccione una opción: ");
            String opcion = entrada.nextLine();

            if (opcion.equals("1")) {
                System.out.print("Nombre del producto: ");
                String nombre = entrada.nextLine();

                System.out.print("Precio del producto: ");
                double precio = Double.parseDouble(entrada.nextLine());

                productos.put(nombre, precio);

                System.out.println("Producto agregado.");

            } else if (opcion.equals("2")) {
                System.out.print("Nombre del producto: ");
                String nombre = entrada.nextLine();

                if (productos.containsKey(nombre)) {
                    System.out.println("Precio: " + productos.get(nombre));
                } else {
                    System.out.println("Producto no encontrado.");
                }

            } else if (opcion.equals("3")) {
                System.out.print("Nombre del producto: ");
                String nombre = entrada.nextLine();

                if (productos.containsKey(nombre)) {
                    System.out.print("Nuevo precio: ");
                    double nuevoPrecio = Double.parseDouble(entrada.nextLine());

                    productos.put(nombre, nuevoPrecio);

                    System.out.println("Precio actualizado.");
                } else {
                    System.out.println("Producto no encontrado.");
                }

            } else if (opcion.equals("4")) {
                System.out.print("Nombre del producto: ");
                String nombre = entrada.nextLine();

                if (productos.containsKey(nombre)) {
                    productos.remove(nombre);
                    System.out.println("Producto eliminado.");
                } else {
                    System.out.println("Producto no encontrado.");
                }

            } else if (opcion.equals("5")) {
                System.out.println("Programa finalizado.");
                break;

            } else {
                System.out.println("Opción no válida.");
            }
        }

        entrada.close();
    }
}
