using Comercio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms
{
    public partial class SiteMaster : MasterPage
    {
        MarcaComercio mc = new MarcaComercio();
        CategoriaComercio cc = new CategoriaComercio();
        ArticuloComercio art = new ArticuloComercio();
        protected void Page_Load(object sender, EventArgs e)
        {
            marc.DataSource = mc.Listar();
            marc.DataBind();
            cat.DataSource = cc.Listar();
            cat.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string path = HttpContext.Current.Request.Url.AbsolutePath;
            var searchText = Server.UrlEncode(txtSearchMaster.Text); 
            Response.Redirect("~/Default.aspx?srch=" + searchText);
        }

        protected void marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca m = (Marca)marc.SelectedValue;
            marc.DataSource = art.BuscarMarca(m);
            marc.DataBind();
        }

        protected void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = cat.Items[cat.SelectedIndex];
            Categoria c = (Categoria)item.DataItem;
            cat.DataSource = art.BuscarCategoria(c);
            cat.DataBind();
        }

    }
}