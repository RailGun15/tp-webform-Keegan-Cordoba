<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ARTICULOS </h2>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col">
                <%foreach (Dominio.Articulo item in listaArticulo)
                    { %>
                <div class="card-columns">
                    <div class="card">
                        <img src="<% = item.UrlImagen%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%  =item.Nombre %></h5>
                            <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                        </div>
                    </div>
                </div>
                <%  } %>
            </div>
        </div>




    </div>

    <asp:GridView CssClass="table" ID="dgvArticulo" runat="server"></asp:GridView>
</asp:Content>
