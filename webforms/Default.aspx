<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ARTICULOS </h2>
    <hr />
    
        
        <div class="row">
            <div class="card-columns col-9">
                <div class="col-lg col-md col-sm">
                    <asp:Repeater runat="server" ID="list">
                        <ItemTemplate>
                            <div class="card" style="width: 18rem;border: 3px solid black;">
                              <img src="<%# Eval("UrlImagen")%>" class="card-img-top" alt="...">
                              <div class="card-body text-center">
                                <h5 class="card-title"><%# Eval("Nombre")%></h5>
                                <p class="card-text"><%# Eval("Descripcion")%></p>
                              </div>
                              <ul class="list-group list-group-flush">
                                <asp:LinkButton CssClass="btn btn-primary" ID = "LinkButton2" runat="server" Text='Detalle' OnClick ="btn_Click" CommandArgument=<%# Eval("Id")%>></asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-primary" ID = "LinkButton1" runat="server" Text='Agregar' OnClick ="btn_Click" CommandArgument=<%# Eval("Id")%>></asp:LinkButton>
                              </ul>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
           </div>
                <div class ="col-md border-left" >
                   <div>
                        <div class="pt-4">
                          <h5 class="mb-3">Total</h5>

                          <ul class="list-group list-group-flush">
                            <li class="list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0">
                              SubTotal
                              <span>$<% =carr.Total()%></span>
                            </li>
                            <li class="list-group-item d-flex justify-content-between align-items-center px-0">
                              Envio
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
                          <asp:LinkButton CssClass="btn btn-primary btn-block" ID = "LinkButton1" runat="server" Text='Checkout' OnClick ="btnCheckout_Click"></asp:LinkButton>

                        </div>
                      </div>       
                    </div>
        </div>
</asp:Content>
