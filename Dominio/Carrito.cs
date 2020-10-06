using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public List<ItemCarrito> Items { get; set; }

        public static readonly Carrito Instance;
        static Carrito()
        {
            Instance = new Carrito();
            Instance.Items = new List<ItemCarrito>();
        }
        
        public void AgregarItem(int id)
        {
            ItemCarrito item = new ItemCarrito(id);
            if (Items.Contains(item))
            {
                foreach (ItemCarrito i in Items)
                {
                    if (i.Equals(item))
                    {
                        i.Cantidad++;
                        return;
                    }
                }
            }
            else
            {
                item.Cantidad = 1;
                Items.Add(item);
            }
  
        }

        public void setCantidad(int id,int cant)
        {
            if (cant == 0)
            {
                RemoverItem(id);
                return;
            }

            ItemCarrito item = new ItemCarrito(id);

            foreach (ItemCarrito i in Items)
            {
                if (i.Equals(item))
                {
                    i.Cantidad = cant;
                    return;
                }
            }
        }

        public void RemoverItem(int id)
        {
            ItemCarrito item = new ItemCarrito(id);
            Items.Remove(item);
        }
            
        public decimal Total()
        {
            decimal total = 0;
            foreach (ItemCarrito i in Items)
                total += i.PrecioTotal();
            return total;
        }
    }
}
