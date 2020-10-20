using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms
{
	public partial class Detalle : System.Web.UI.Page
	{
		public Articulo item = new Articulo();
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                if (Session["articuloSeleccionado"] == null)
                {
					Response.Redirect("Default.aspx");
				}
                else
                {
                    item = (Articulo)Session["articuloSeleccionado"];
                    imagen.Src = item.UrlImagen;
                }
			}
            catch (Exception)
            {
                throw;
            }
		}
	}
}