<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ej4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Selecciona el producto a registrar</h1>
    <asp:Panel ID="Panel1" runat="server">
        <asp:RadioButton ID="BondDeal" runat="server" GroupName="Select" Text="BondDeal"/>
        <asp:RadioButton ID="RepoDeal" runat="server" GroupName="Select" Text="RepoDeal" />
        <asp:RadioButton ID="Otro" runat="server" GroupName="Select" Text="Otro" />
    
    </asp:Panel>

    <div id="Bond" class="container hidden">
        <div class="row">
            <asp:Label ID="LocalId" runat="server" Text="LocalId"></asp:Label>
            <asp:TextBox ID="txt_locId" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Titulos" runat="server" Text="Titulos"></asp:Label>
            <asp:TextBox ID="txt_titulos" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Precio" runat="server" Text="Precio"></asp:Label>
            <asp:TextBox ID="txt_precio" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Contraparte" runat="server" Text="Contraparte"></asp:Label>
            <asp:TextBox ID="txt_cont" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="SettlementDate" runat="server" Text="SettlementDate"></asp:Label>
            <asp:TextBox ID="txt_Sett" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="DealName" runat="server" Text="DealName"></asp:Label>
            <asp:TextBox ID="txt_dealnameB" runat="server" Enabled="False" Text="BondDeal"></asp:TextBox>
        </div>
    </div>
    <div id="Repo" class="container hidden" >
        <div class="row">
            <asp:Label ID="LocalIDR" runat="server" Text="LocalIDR"></asp:Label>
            <asp:TextBox ID="txt_locId2" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Titles" runat="server" Text="Titles"></asp:Label>
            <asp:TextBox ID="txt_titles" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Price" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Counterparty" runat="server" Text="Counterparty"></asp:Label>
            <asp:TextBox ID="txt_conter" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="StartDate" runat="server" Text="StartDate"></asp:Label>
            <asp:TextBox ID="txt_stard" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="EndDate" runat="server" Text="EndDate"></asp:Label>
            <asp:TextBox ID="txt_endD" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="DealNameR" runat="server" Text="DealNameR"></asp:Label>
            <asp:TextBox ID="txt_dealnameR" runat="server" Enabled="False">RepoDeal</asp:TextBox>
        </div>
    </div>
    <div id="Other" class="container hidden">
        <div class="row">
            <asp:Label ID="LocalIDO" runat="server" Text="OtherLocalId"></asp:Label>
            <asp:TextBox ID="txt_locIdO" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="DealNameO" runat="server" Text="OtherDealNme"></asp:Label>
            <asp:TextBox ID="txt_dealnameO" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="OtherTitles" runat="server" Text="OtherTitles"></asp:Label>
            <asp:TextBox ID="txt_O_tit" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="OtherStartDate" runat="server" Text="OtherStartDate"></asp:Label>
            <asp:TextBox ID="txt_OthStart" runat="server"></asp:TextBox>
        </div>
    </div>

    <div id="Btn" class="container">
        <div class="row">
        <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
        </div>
    </div>
    
    <script>
        $(document).ready(function () {

            $("input[type=radio]").click(function (event) {
                var valor = $(this).attr("id");

                if (valor == "MainContent_BondDeal") {
                    $("#Bond").removeClass("hidden");
                    $("#Repo").addClass("hidden");
                    $("#Other").addClass("hidden");

                } else if (valor == "MainContent_RepoDeal") {
                    $("#Repo").removeClass("hidden");
                    $("#Bond").addClass("hidden");
                    $("#Other").addClass("hidden");

                } else {
                    $("#Other").removeClass("hidden");
                    $("#Repo").addClass("hidden");
                    $("#Bond").addClass("hidden");
                }
            });
        });

    </script>
</asp:Content>


