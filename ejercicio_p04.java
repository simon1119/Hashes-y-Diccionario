import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ejercicio_p04 {
    public static void main(String[] args) {
        List<String[]> estudiantes = new ArrayList<>();

        estudiantes.add(new String[]{"Camila", "11A"});
        estudiantes.add(new String[]{"Julián", "11B"});
        estudiantes.add(new String[]{"Valentina", "11A"});
        estudiantes.add(new String[]{"Andrés", "11B"});
        estudiantes.add(new String[]{"Laura", "11C"});

        HashMap<String, List<String>> cursos = new HashMap<>();

        for (String[] estudiante : estudiantes) {
            String nombre = estudiante[0];
            String curso = estudiante[1];

            if (cursos.containsKey(curso)) {
                cursos.get(curso).add(nombre);
            } else {
                cursos.put(curso, new ArrayList<>());
                cursos.get(curso).add(nombre);
            }
        }

        System.out.println("Estudiantes por curso:");

        for (Map.Entry<String, List<String>> curso : cursos.entrySet()) {
            System.out.println(curso.getKey() + ":");

            for (String nombre : curso.getValue()) {
                System.out.println(" - " + nombre);
            }
        }
    }
}
