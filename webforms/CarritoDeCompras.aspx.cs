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
                if (Session["carrito"] == null)
                {
                    Response.Write("<h2 style=margin-top:60px;text-align: center;>No hay articulos seleccionados</h2>");
                }
                else
                {
                    carr = (Carrito)Session["carrito"];
                    cart.DataSource = carr.Items;
                    cart.DataBind();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void btn_RemoverClick(object sender, EventArgs e)
        {
            var id = int.Parse((sender as LinkButton).CommandArgument);
            carr.RemoverItem(id);
            Session.Add("carrito", carr);
            Response.Redirect(Request.RawUrl);
        }

        public void btn_AgregarClick(object sender, EventArgs e)
        {
            var id = int.Parse((sender as LinkButton).CommandArgument);
            ItemCarrito item = carr.Items.Find(x => x.Id == id);
            carr.AgregarItem(item);
            Session.Add("carrito", carr);
            Response.Redirect(Request.RawUrl);
        }
    }
}