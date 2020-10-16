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
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string path = HttpContext.Current.Request.Url.AbsolutePath;
            var searchText = Server.UrlEncode(txtSearchMaster.Text); 
            Response.Redirect("~/Default.aspx?srch=" + searchText);
        }

    }
}