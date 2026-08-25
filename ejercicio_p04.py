estudiantes = [
    ("Camila", "11A"),
    ("Julián", "11B"),
    ("Valentina", "11A"),
    ("Andrés", "11B"),
    ("Laura", "11C")
]

cursos = {}

for nombre, curso in estudiantes:
    if curso in cursos:
        cursos[curso].append(nombre)
    else:
        cursos[curso] = [nombre]

print("Estudiantes por curso:")

for curso, lista_estudiantes in cursos.items():
    print(curso, ":", lista_estudiantes)
