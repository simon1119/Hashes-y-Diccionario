import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class ejercicio_p02 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        System.out.print("Ingrese una frase: ");
        String texto = entrada.nextLine().toLowerCase();

        HashMap<Character, Integer> frecuencia = new HashMap<>();

        for (char letra : texto.toCharArray()) {
            if (letra != ' ') {
                if (frecuencia.containsKey(letra)) {
                    frecuencia.put(letra, frecuencia.get(letra) + 1);
                } else {
                    frecuencia.put(letra, 1);
                }
            }
        }

        System.out.println("\nFrecuencia de las letras:");

        frecuencia.entrySet()
                .stream()
                .sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                .forEach(elemento ->
                        System.out.println(elemento.getKey() + " : " + elemento.getValue()));

        entrada.close();
    }
}
