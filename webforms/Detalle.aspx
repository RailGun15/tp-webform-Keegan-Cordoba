<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="webforms.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="container">
        <img id="imagen" runat="server" src ="<%= item.UrlImagen %>" alt="..." />
        <h3 style="border-bottom:thin;font-size:25px" runat ="server"> <%= item.Nombre %></h3>
        <hr />
        <p style="border-bottom:thin;font-size:15px" runat ="server">Marca: <%= item.Marca.Nombre %> </p>
        <p style="border-bottom:thin;font-size:15px" runat ="server">Categoria: <%= item.Categoria.Nombre %> </p>
        <hr />
        <p style="border-bottom:thin;font-size:15px" runat ="server">Precio: <%= item.Precio %> </p>
        <hr />
        <p style ="font-size:15px" runat ="server" >Descripcion: <%= item.Descripcion %> </p>
        
    </div>
</asp:Content>
