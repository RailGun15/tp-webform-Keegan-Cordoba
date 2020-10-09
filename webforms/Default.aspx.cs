﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            
        }
    }
}