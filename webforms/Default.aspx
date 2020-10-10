<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ARTICULOS </h2>
    <hr />
    
        <div class="row">
            <div class="card-columns col-6">
                <%foreach (Dominio.Articulo item in listaArticulo)
                    { %>
            
                <div class="card  bg-light border-dark mb-3" style="max-width: 18rem;">
                    <img src="<% =item.UrlImagen%>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><% =item.Nombre%></h5>
                        <p class="card-text"><% =item.Descripcion%></p>
                        <a href="#" class="btn btn-primary">Agregar al carrito</a>
                    </div>
                </div>
                
                <%  } %>
            </div>
    </div>

    <asp:GridView CssClass="table" ID="dgvArticulo" runat="server"></asp:GridView>
</asp:Content>
