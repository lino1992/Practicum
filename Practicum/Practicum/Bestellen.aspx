<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bestellen.aspx.cs" Inherits="Practicum.Bestellen" %>

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
                <a href="Verkooplijst.aspx"><button type="button" class="btn btn-default btn-lg active" id="Lb_Ver" runat="server">Verkooplijst</button></a>
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
                 <a href="Bestellen.aspx"><img src="Shopping.png" Width="25px" /></a>
             </button>
         </div>
         <div class="Tekst">
             Gratis verzending vanaf 20 euro, gratis retourneren en 30 dagen bedenktijd
         </div>
            <div class="BestellingInfor">
                <div class="Gekozenboek">
                     <h4>Gekozen Boeken</h4>
                    <br />
                    <asp:Label ID="Isbnnummer" runat="server" Text="Isbnnummer"></asp:Label>
                    <asp:TextBox ID="TB_Isbnnummer" runat="server" Enabled="false"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Titel"></asp:Label>
                    <br />
                    <asp:TextBox ID="TB_Titel" runat="server" Enabled="false"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
                    <br />
                    <asp:TextBox ID="TB_Status" runat="server" Enabled="false"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Prijs"></asp:Label>
                    <br />
                    <asp:TextBox ID="TB_prijs" runat="server"></asp:TextBox>
                </div>
                <div class="Mijngegevens">
                    <h4>Mijn gegevens</h4>
                     <asp:GridView ID="GD_Mijngegevens" runat="server" AutoGenerateColumns="False" CssClass="Mijngegevens_GD" Width="526px" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="NAAM" HeaderText="NAAM" SortExpression="NAAM" />
                                <asp:BoundField DataField="ACHTERNAAM" HeaderText="ACHTERNAAM" SortExpression="ACHTERNAAM" />
                                <asp:BoundField DataField="ADRES" HeaderText="ADRES" SortExpression="ADRES" />
                                <asp:BoundField DataField="POSTCODE" HeaderText="POSTCODE" SortExpression="POSTCODE"/>
                                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                            </Columns>
                        </asp:GridView>
                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" ></asp:SqlDataSource>
                    
                </div>
                <div class="Bestelling_betaling">
                    <h4>Betaling</h4>
                    <div class="betaling">
                     <asp:Label ID="Label1" runat="server" Text="Kortingcode" CssClass="kortingcode"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Betalngmetode" CssClass="betalingmethode"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Betaald" CssClass="betaald"></asp:Label>
                    </div>
                    <div class="Betaling2">
                        <asp:TextBox ID="TB_korting" runat="server"></asp:TextBox>
                        <asp:CheckBox ID="Cb_betaling_Ideal" Text="Ideal" runat="server" CssClass="betaling_ja"/>
                        <asp:CheckBox ID="Cb_betaling_Achteraf" Text="Achteraf" runat="server" CssClass="betaling_nee" />
                        <asp:CheckBox ID="Cb_betaald_ja" runat="server" Text="Ja" CssClass="betaald_ja" />
                        <asp:CheckBox ID="Cb_betaald_nee" runat="server" Text="Nee" CssClass="betaald_nee" />
                    </div>
                </div>
                <asp:Button ID="Tb_bevestig" runat="server" Text="Besvestig" CssClass="Tb_bevestig" OnClick="Tb_bevestig_Click"/>
            </div>
        </div> 
        <div class="Footer">
            <h4>Made by Lino</h4>
        </div>
    </form>
</body>
</html>
