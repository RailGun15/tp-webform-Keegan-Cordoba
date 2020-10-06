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

        public ItemCarrito(int id)
        {
            this.Id = id;
        }

        public decimal PrecioTotal()
        {
            return Precio * Cantidad;
        }

        public bool Equals(ItemCarrito item)
        {
            return item.Id == this.Id;
        }

    }
}
