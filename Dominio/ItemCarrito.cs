using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemCarrito : Articulo
    {
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get => (Precio * Cantidad);}

        public ItemCarrito(int id)
        {
            this.Id = id;
            Cantidad = 0;
        }

        public ItemCarrito(Articulo art)
        {
            Id = art.Id;
            Nombre = art.Nombre;
            Precio = art.Precio;
            UrlImagen = art.UrlImagen;
            Cantidad = 0;
        }

    }
}
