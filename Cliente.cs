
namespace TiendaElectronicaPOO
{
    internal class Cliente
    {
        private string? nombreCliente;

        public Cliente(string? nombreCliente)
        {
            this.nombreCliente = nombreCliente;
        }

        public string Nombre { get; internal set; }

        internal void AgregarProducto(ProductoElectronico productoElectronico)
        {
            throw new NotImplementedException();
        }

        internal void MostrarCarrito()
        {
            throw new NotImplementedException();
        }
    }
}