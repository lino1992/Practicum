<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Practicum.index" %>

<!DOCTYPE html>

<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel= "stylesheet" type="text/css" 
    href="StyleSheet1.css" />
    <title>Practicum</title>
    <style type="text/css">
        .Boeklijst_GD {}
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div class="balk">
        <div class="menubalk">
            <div class="Login">
                <a href="Login.aspx"><button type="button" class="btn btn-default btn-lg active" id="Lb_login" runat="server">Login</button></a>
            </div>
            <div class="Verlanglijst">
                <a href="Verkooplijst.aspx"><button type="button" class="btn btn-default btn-lg active" id="Lb_Ver" runat="server">Verkooplijst</button></a>
            </div>
      
            <div class="account">
                <a href="Account.aspx"><button type="button" class="btn btn-default btn-lg active" id="Lb_AC" runat="server">Account</button></a>
            </div>
        </div>
    </div>
     <div class="Home">
        <div class="Logo">
            <a href ="index.aspx" ><img src="Bol-logo_big.jpg" /></a>           
        </div>
         <div class="Zoekbar">
             <asp:TextBox ID="TB_Zoek" runat="server" Width="462px"></asp:TextBox>
             <asp:Button ID="BT_Zoek" runat="server" Text="Zoek" Width="57px" OnClick="BT_Zoek_Click" />
             <button type="button" class="btn btn-default btn-lg active" id="Bestellen" runat="server">
                 <a href="Bestellen.aspx"><img src="Shopping.png" Width="25px" /></a>
             </button>
         </div>
         <div class="Tekst">
             Gratis verzending vanaf 20 euro, gratis retourneren en 30 dagen bedenktijd
         </div>
         <div class="Zoekresultaat">

             <asp:GridView ID="Gevonden_GD" runat="server" CssClass="Gevonden_GD" AutoGenerateColumns="True" DataKeyNames="ISBNNUMMER" Width="596px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Gevonden_GD_SelectedIndexChanged">
                 <AlternatingRowStyle BackColor="White" />
                 <EditRowStyle BackColor="#7C6F57" />
                 <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#E3EAEB" />
                 <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#F8FAFA" />
                 <SortedAscendingHeaderStyle BackColor="#246B61" />
                 <SortedDescendingCellStyle BackColor="#D4DFE1" />
                 <SortedDescendingHeaderStyle BackColor="#15524A" />
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSourceGevonden" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" ></asp:SqlDataSource>
         </div>
         <div class="Foto">
             <img src="studieboeken.jpg" />
             <br />
         </div>

             <asp:GridView ID="Boeklijst_GD" CssClass="Boeklijst_GD" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="598px" Height="292px" OnSelectedIndexChanged="Boeklijst_GD_SelectedIndexChanged">
                 <FooterStyle BackColor="White" ForeColor="#333333" />
                 <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="White" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#487575" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#275353" />
             </asp:GridView>
       </div>
        
        <div class="Footer">
            <h4>Made by Lino</h4>
        </div>
    </form>
</body>
</html>
