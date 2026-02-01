#  Tienda Electrónica (POO en C#)

Proyecto de consola en **C#** que simula una tienda electrónica utilizando **Programación Orientada a Objetos (POO)**.  
El usuario puede seleccionar productos, agregarlos a su carrito y generar un ticket de compra.
![logo c#](https://desarrolloweb.com/storage/tag_images/actual/BzOL16MEqsKOe0VThjF6FXPBi0uyK16lkTety9Wz.png)

---

## Características principales
- Interfaz de consola interactiva.
- Lista de productos electrónicos predefinidos.
- Carrito de compras por cliente.
- Confirmación de compra con ticket detallado.
- Aplicación de conceptos de POO:
  - **Encapsulamiento**: propiedades y listas privadas.
  - **Herencia**: ProductoElectronico hereda de Producto.
  - **Polimorfismo**: sobrescritura de métodos (MostrarInformacion).
  - **Abstracción**: separación de responsabilidades entre clases.

---

## Herramientas utilizadas
- **Lenguaje:** C#  
- **Framework:** .NET (ejecución en consola)  
- **Paradigma:** Programación Orientada a Objetos (POO)  
- **Colecciones:** List<T> para manejar productos y carrito.  
- **Validaciones:** int.TryParse para entradas seguras.  

---

## Estructura del código
- **Clase Producto**
  - Propiedades: Nombre, Precio, Categoria.
  - Método virtual: MostrarInformacion().

- **Clase ProductoElectronico (derivada)**
  - Propiedad adicional: GarantiaMeses.
  - Sobrescribe MostrarInformacion().

- **Clase Cliente**
  - Propiedad: Nombre.
  - Carrito (List<Producto>).
  - Métodos: AgregarProducto(), MostrarCarrito().

- **Método Main**
  - Lista de productos disponibles.
  - Interacción con el usuario (nombre, selección de productos).
  - Confirmación de compra y ticket final.
