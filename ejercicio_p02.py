texto = input("Ingrese una frase: ")
texto = texto.lower()

frecuencia = {}

for letra in texto:
    if letra != " ":
        if letra in frecuencia:
            frecuencia[letra] += 1
        else:
            frecuencia[letra] = 1

resultado = sorted(frecuencia.items(), key=lambda elemento: elemento[1], reverse=True)

print("\nFrecuencia de las letras:")

for letra, cantidad in resultado:
    print(letra, ":", cantidad)
