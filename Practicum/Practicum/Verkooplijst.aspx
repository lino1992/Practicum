<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verkooplijst.aspx.cs" Inherits="Practicum.Verlanglijst" %>

<!DOCTYPE html>

<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel= "stylesheet" type="text/css" 
    href="StyleSheet1.css" />
    <title>Practicum</title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="balk">
        <div class="menubalk">
            <div class="Verlanglijst">
                <a href="Login.aspx"><button type="button" class="btn btn-default btn-lg active" id="Lb_login" runat="server">Login</button></a>
            </div>
            <div class="Bestelstatus">
                <a href="Verkooplijst.aspx"><button type="button" class="btn btn-default btn-lg active">Verkooplijst</button></a>
            </div>
            <div class="account">
                <a href="Account.aspx"><button type="button" class="btn btn-default btn-lg active">Account</button></a>
            </div>
        </div>
    </div>
        <div class="Home">
             <div class="Logo">
                 <a href ="index.aspx" ><img src="Bol-logo_big.jpg" /></a>
            </div>
             <div class="Zoekbar">
             <asp:TextBox ID="TB_Zoek" runat="server" Width="462px"></asp:TextBox>
             <asp:Button ID="BT_Zoek" runat="server" Text="Zoek" Width="57px" />
             <button type="button" class="btn btn-default btn-lg active">
                 <a href="Bestellen"><img src="Shopping.png" Width="25px" /></a>
             </button>
         </div>
         <div class="Tekst">
             Gratis verzending vanaf 20 euro, gratis retourneren en 30 dagen bedenktijd
         </div>
            <div class="Verkooplijst">
                <div class="Verkooplijst_tekst"><h4>Jouw aangeboden Boeken</h4></div>
                        <asp:GridView ID="GD_Verkooplijst" runat="server" AutoGenerateColumns="False" CssClass="Verkooplijst_GD" DataSourceID="SqlDataSourceAangeboden">
                            <Columns>
                                <asp:BoundField DataField="TITEL" HeaderText="TITEL" SortExpression="TITEL" />
                                <asp:BoundField DataField="PRIJS" HeaderText="PRIJS" SortExpression="PRIJS" />
                                <asp:BoundField DataField="OMSCHRIJVING" HeaderText="OMSCHRIJVING" SortExpression="OMSCHRIJVING"  />
                                <asp:BoundField DataField="ISBNNUMMER" HeaderText="ISBNNUMMER" SortExpression="ISBNNUMMER"  />
                                </Columns>
                        </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSourceAangeboden" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" ></asp:SqlDataSource>
                </div>
            <div class="VerkoopGegevens">
                <div class="VerkoopTekst"><h4>Nieuwe boek toevoegen</h4></div>
                <div class="VerkoopGegevenL">
                    <asp:Label ID="LTitel" runat="server" Text="Titel" CssClass="LTitel"></asp:Label>
                    <asp:Label ID="LPrijs" runat="server" Text="Prijs" CssClass="Lprijs"></asp:Label>
                    <asp:Label ID="LOmschrijving" runat="server" Text="Omschrijnving" CssClass="Lomschrijving"></asp:Label>
                    <asp:Label ID="LIsbnmmer" runat="server" Text="Isbnnummer" CssClass="Lisbnnummer"></asp:Label>
                    <asp:Label ID="LVerkoopNummer" runat="server" Text="Verkoopnummer" CssClass="LVerkoopNummer"></asp:Label>
                </div>
                <div class="VerkoopGegevenR">
                    <asp:TextBox ID="Tb_Ver_T" runat="server" CssClass="Tb_Ver_T"></asp:TextBox>
                    <asp:TextBox ID="Tb_Ver_P" runat="server" CssClass="Tb_Ver_P"></asp:TextBox>
                    <asp:TextBox ID="Tb_Ver_O" runat="server" CssClass="Tb_Ver_O"></asp:TextBox>
                    <asp:TextBox ID="Tb_Ver_I" runat="server" CssClass="Tb_Ver_I"></asp:TextBox>
                    <asp:TextBox ID="Tb_Ver_V" runat="server" CssClass="Tb_Ver_V" Enabled="false"></asp:TextBox>
                </div>
                <asp:Button ID="Tb_toevoegen" runat="server" Text="Toevoegen" CssClass="Tb_toevoegen" OnClick="Tb_toevoegen_Click" />
            </div>
            </div>
        <div class="Footer">
            <h4>Made by Lino</h4>
        </div>
    </form>
</body>
</html>
