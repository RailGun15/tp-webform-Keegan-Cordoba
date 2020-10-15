<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ARTICULOS </h2>
    <hr />

    <div class="row">
        <div class="card-columns col-6">
            <asp:Repeater runat="server" ID="list">
                <ItemTemplate>
                    <div class="card  bg-light border-dark mb-3" style="max-width: 18rem;">
                        <img src="<%# Eval("UrlImagen")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h4 class="card-title"><%# Eval("Nombre")%></h4>
                            <h5 class="card-title">$ <%# Eval("Precio")%></h5>
                            
                          <button type="button" class="btn btn-light btn-lg btn-block" data-toggle="collapse" data-target="#demo">Detalles</button>

                            <div id="demo" class="collapse">
                                <h5 class="card-text"><%# Eval("Marca")%></h5>
                                <p class="card-text"><%# Eval("Descripcion")%></p>
                                
                            </div>
                            <asp:LinkButton CssClass="btn btn-primary btn-lg btn-block" ID="btn" runat="server" Text='Agregar' OnClick="btn_Click" CommandArgument='<%# Eval("Id")%>'></asp:LinkButton>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
</asp:Content>
