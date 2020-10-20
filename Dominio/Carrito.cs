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

        public Carrito()
        {
            Items = new List<ItemCarrito>();
        }
        
        public void AgregarItem(ItemCarrito item)
        {
            if (Items.Any(i => item.Id == i.Id))
            {
                foreach (ItemCarrito i in Items)
                {
                    if (i.Id == item.Id)
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
            foreach (ItemCarrito i in Items)
            {
                if (i.Id == id)
                {
                    Items.Remove(i);
                    return;
                }
            }
        }
            
        public decimal Total()
        {
            decimal total = 0;
            foreach (ItemCarrito i in Items)
                total += i.PrecioTotal;
            return total;
        }
    }
}
