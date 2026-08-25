productos = {
    "Arroz": 5000,
    "Leche": 4000,
    "Pan": 2500
}

while True:
    print("\n--- MENÚ ---")
    print("1. Agregar producto")
    print("2. Consultar precio")
    print("3. Actualizar precio")
    print("4. Eliminar producto")
    print("5. Salir")

    opcion = input("Seleccione una opción: ")

    if opcion == "1":
        nombre = input("Nombre del producto: ")
        precio = float(input("Precio del producto: "))
        productos[nombre] = precio
        print("Producto agregado.")

    elif opcion == "2":
        nombre = input("Nombre del producto: ")
        if nombre in productos:
            print("Precio:", productos[nombre])
        else:
            print("Producto no encontrado.")

    elif opcion == "3":
        nombre = input("Nombre del producto: ")
        if nombre in productos:
            nuevo_precio = float(input("Nuevo precio: "))
            productos[nombre] = nuevo_precio
            print("Precio actualizado.")
        else:
            print("Producto no encontrado.")

    elif opcion == "4":
        nombre = input("Nombre del producto: ")
        if nombre in productos:
            del productos[nombre]
            print("Producto eliminado.")
        else:
            print("Producto no encontrado.")

    elif opcion == "5":
        print("Programa finalizado.")
        break

    else:
        print("Opción no válida.")
