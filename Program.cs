using System;
using System.Collections.Generic;

namespace TiendaElectronicaPOO
{
    class Program
    {
        // Clase Producto dentro de Programa
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public string Categoria { get; set; }

            public Producto(string nombre, decimal precio, string categoria)
            {
                Nombre = nombre;
                Precio = precio;
                Categoria = categoria;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Producto: {Nombre}, Precio: {Precio:C}, Categoría: {Categoria}");
            }
        }
        //----------------------------------------------------------------------------------------

        // Clase derivada ProductoElectronico
        public class ProductoElectronico : Producto
        {
            public int GarantiaMeses { get; set; }

            public ProductoElectronico(string nombre, decimal precio, string categoria, int garantiaMeses)
                : base(nombre, precio, categoria)
            {
                GarantiaMeses = garantiaMeses;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Garantía: {GarantiaMeses} meses");
            }
        }
        //----------------------------------------------------------------------------------------

        // Clase Cliente
        public class Cliente
        {
            public string Nombre { get; set; }
            private List<Producto> carrito = new List<Producto>();

            public Cliente(string nombre)
            {
                Nombre = nombre;
            }

            public void AgregarProducto(Producto producto)
            {
                carrito.Add(producto);
                Console.WriteLine($"{producto.Nombre} agregado al carrito de {Nombre}.");
            }

            public void MostrarCarrito()
            {
                Console.WriteLine($"\nCarrito de {Nombre}:");
                foreach (var producto in carrito)
                {
                    producto.MostrarInformacion();
                }
            }
        }
        //----------------------------------------------------------------------------------------

        // Método principal
        static void Main(string[] args)
        {
            List<ProductoElectronico> productosDisponibles = new List<ProductoElectronico>()
            {
                new ProductoElectronico("Laptop Dell", 15000m, "Computadoras", 24),
                new ProductoElectronico("iPhone", 20000m, "Smartphones", 12),
                new ProductoElectronico("Televisor Samsung", 12000m, "Pantallas", 18),
                new ProductoElectronico("Tablet Lenovo", 8000m, "Tablets", 12)
            };

            Console.WriteLine("Bienvenido a la Tienda Electrónica");
            Console.Write("Ingrese su nombre: ");
            string nombreCliente = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombreCliente))
                nombreCliente = "Cliente";

            Cliente cliente = new Cliente(nombreCliente);

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Lista de productos disponibles ---");
                for (int i = 0; i < productosDisponibles.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    productosDisponibles[i].MostrarInformacion();
                }

                Console.Write("\nSeleccione el número del producto que desea agregar al carrito: ");
                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion) && opcion > 0 && opcion <= productosDisponibles.Count)
                {
                    cliente.AgregarProducto(productosDisponibles[opcion - 1]);
                }
                else
                {
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                }

                Console.Write("\n¿Desea agregar otro producto? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower() ?? "n";
                if (respuesta != "s") continuar = false;
            }

            Console.WriteLine("\n¿Desea confirmar la compra? (s/n): ");
            string confirmar = Console.ReadLine()?.ToLower() ?? "n";
            if (confirmar == "s")
            {
                Console.WriteLine("\n--- Ticket de compra ---");
                cliente.MostrarCarrito();
                Console.WriteLine($"\nGracias por su compra, {cliente.Nombre}!");
            }
            else
            {
                Console.WriteLine("\nCompra cancelada.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
