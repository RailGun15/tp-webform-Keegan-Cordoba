using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using Comercio;
using Dominio;

namespace webforms
{
    public partial class _Default : Page
    {
        public List<Articulo> listaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloComercio comercio = new ArticuloComercio();
            listaArticulo = comercio.Listar();
            if (!String.IsNullOrEmpty(Request.QueryString["srch"]))
            {
                string find = Request.QueryString["srch"];
                List<Articulo> selected = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(find.ToUpper()));
                list.DataSource = selected;
                list.DataBind();
                return;
            }
            if (!Page.IsPostBack)
            {
                list.DataSource = listaArticulo;
                list.DataBind();
            }
        }

        public void btn_Click(object sender, EventArgs e)
        {
            var id = int.Parse((sender as LinkButton).CommandArgument);
            Articulo a = listaArticulo.Find(x => x.Id == id);
            Session.Add("articuloSeleccionado", a);
            Response.Redirect(ResolveUrl("CarritoDeCompras.aspx"));
        }


     }
}