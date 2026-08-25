import java.util.HashMap;
import java.util.Scanner;

public class ejercicio_p01 {
    public static void main(String[] args) {
        HashMap<String, String> agenda = new HashMap<>();

        agenda.put("Carlos", "3001234567");
        agenda.put("Maria", "3109876543");
        agenda.put("Juan", "3204567890");

        Scanner entrada = new Scanner(System.in);

        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = entrada.nextLine();

        if (agenda.containsKey(nombre)) {
            System.out.println("Teléfono: " + agenda.get(nombre));
        } else {
            System.out.println("Contacto no encontrado");
        }

        entrada.close();
    }
}
