using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Comercio;

namespace webforms
{
    public partial class CarritoDeCompras : System.Web.UI.Page
    {
        Articulo art = new Articulo();
        protected Carrito carr = new Carrito();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["articuloSeleccionado"] == null)
                {
                    Response.Write("<h2 style=margin-top:60px;text-align: center;>No hay articulos seleccionados</h2>");
                }
                else
                {
                    art = (Articulo)Session["articuloSeleccionado"];
                    ItemCarrito i = new ItemCarrito(art);
                    if ((Carrito)Session["carrito"] == null)
                    {
                        carr.AgregarItem(i);
                    }
                    else
                    {
                        carr = (Carrito)Session["carrito"];
                        carr.AgregarItem(i);
                    }
                    Session.Add("carrito", carr);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}