agenda = {
    "Carlos": "3001234567",
    "Maria": "3109876543",
    "Juan": "3204567890"
}

nombre = input("Ingrese el nombre del contacto: ")

if nombre in agenda:
    print("Teléfono:", agenda[nombre])
else:
    print("Contacto no encontrado")
