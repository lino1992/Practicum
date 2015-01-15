<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practicum.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel= "stylesheet" type="text/css" 
    href="Login.css" />
    <title>Practicum</title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="balk">
        <div class="menubalk">
            
        </div>
    </div>
        <div class="Home">
             <div class="Logo">
            <a href ="index.aspx" ><img src="Bol-logo_big.jpg" /></a>           
            </div>
         <div class="Tekst">
             Gratis verzending vanaf 20 euro, gratis retourneren en 30 dagen bedenktijd
         </div>
            <div class="LPhoto">
                <img src="Foto.png" />
            </div>
            <div class="DLogin">
                <div class="RLogin">
                    <br />
                    <asp:Label ID="Rtekst" runat="server" Text="Nieuw bij bol.com" Font-Size="Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="RE" runat="server" Text="E-mailadres"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TB_E" runat="server" Width="215px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Account Maken" Width="108px" OnClick="Button1_Click" />
                    <br />
                    <br />

                </div>
                <div class="LLogin">
                    <br />
                    <asp:Label ID="Ltekst" runat="server" Text="Bestaande klant" Font-Size="Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="LGN" runat="server" Text="Gebruikersnaam:" Font-Size="Medium"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TB_GN" runat="server" Width="221px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="LWW" runat="server" Text="Wachtwoord:"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TB_WW" runat="server" Width="224px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="B_Log" runat="server" Text="Inloggen" Width="69px" OnClick="B_Log_Click" />
                    <asp:Label ID="Label1" runat="server" CssClass="Errorlabel"></asp:Label>
                    <br />
                </div>
            </div>
        </div>
        <div class="Footer">
            <h4>Made by Lino</h4>
        </div>
    </form>
</body>
</html>
