<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ARTICULOS </h2>
    <hr />


    <div class="row">
        <div class="card-columns col-9">
            <div class="col-lg col-md col-sm">
                <asp:Repeater runat="server" ID="list">
                    <ItemTemplate>
                        <div class="card" style="width: 18rem; border: 2px solid solid;">
                            <img src="<%# Eval("UrlImagen")%>" class="card-img-top" alt="...">
                            <div class="card-body text-center">
                                <h4 class="card-title"><%# Eval("Nombre")%></h4>
                                <h5 class="card-text">$ <%# Eval("Precio")%></h5>
                            </div>
                            <ul class="list-group list-group-flush">
                                <button type="button" class="btn btn-light btn-lg btn-block" data-toggle="collapse" data-target="#demo">Detalles</button>

                                <div id="demo" class="collapse">
                                    <h5 class="card-text">Categoria: <%# Eval("Categoria")%></h5>
                                    <h5 class="card-text">Marca: <%# Eval("Marca")%></h5>
                                    <p class="card-text">Descripcion: <%# Eval("Descripcion")%></p>

                                </div>
                                <asp:LinkButton CssClass="btn btn-primary btn-lg" ID="LinkButton1" runat="server" Text='Agregar' OnClick="btn_Click" CommandArgument='<%# Eval("Id")%>'></asp:LinkButton>
                            </ul>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="col-md border-left">
            <div>
                <div class="pt-4">
                    <h5 class="mb-3">Total</h5>

                    <ul class="list-group list-group-flush">
                        <li class="list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0">SubTotal
                              <span>$<% =carr.Total()%></span>
                        </li>
                        <li class="list-group-item d-flex justify-content-between align-items-center px-0">Envio
                              <span>Gratis</span>
                        </li>
                        <li class="list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3">
                            <div>
                                <strong>Total</strong>
                                <strong>
                                    <p class="mb-0">(Incluyendo IVA)</p>
                                </strong>
                            </div>
                            <span><strong>$<% =carr.Total()%></strong></span>
                        </li>
                    </ul>
                    <asp:LinkButton CssClass="btn btn-primary btn-lg btn-block" ID="LinkButton1" runat="server" Text='Checkout' OnClick="btnCheckout_Click"></asp:LinkButton>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
