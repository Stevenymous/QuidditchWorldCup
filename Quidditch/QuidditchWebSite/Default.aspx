<%@ Page Title="Qui Di Kitsch - Liste des matches" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1 class="center">Qui Di Kitsch - Manager de coupes du monde de Quidditch</h1>
        <br />
    </div>
    <div class="row">
        <asp:Label runat="server" ID="LbListMatch" Text="Liste des matches disponibles pour la réservation"></asp:Label>
        <br />
    </div>
    <div class="row">
        <asp:RadioButtonList ID="RbList" runat="server"></asp:RadioButtonList>
        <br />
    </div>
    <div class="row">
        <asp:Label runat="server" Text="Nombre de place(s) à réserver "></asp:Label>
        <asp:TextBox id="TxbPlace" TextMode="Number" runat="server" />
        <br />
    </div>
    <div class="row">
        <asp:Label runat="server" Text="Prix d'une place"></asp:Label>
        <asp:DropDownList ID="DdlPrix" runat="server"></asp:DropDownList>
        <br />
        <br />
    </div>
    <div class="row">
        <asp:Button ID="BtnReserver" OnClick="BtnReserver_Click" class="btn btn-primary btn-lg" runat="server" Text="Réserver" />
    </div>
    <div class="row">
        <asp:Label ID="LbResultAdd" runat="server" Text=" "></asp:Label>
    </div>
</asp:Content>
