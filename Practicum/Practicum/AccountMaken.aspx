<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountMaken.aspx.cs" Inherits="Practicum.AccountMaken" %>

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
                <a href="Login.aspx"><button type="button" class="btn btn-default btn-lg active">Login</button></a>
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
            <div class="Top">
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
                </div>
            <div class="Pers_gegevens">
                <div class="Pers_gegevens_h1">
                    <h2> Nieuw bij bol.com</h2> 
                    Als je nieuw bent bij bol.com, kun je hier een account aanmaken.
                    <h4> Account gegevens</h4> 
                </div>
                <div class="Pers_left">
                        <h5> Persoonlijke gegevens</h5> 

                    <div class="Pers_left_l">
                        <div class="P_l_N">
                            <asp:Label ID="L_Naam"  runat="server" Text="Naam:"></asp:Label>
                        </div>
                        <div class="P_l_A">
                            <asp:Label ID="L_Achternaam"  runat="server" Text="Achternaam:"></asp:Label>
                        </div>
                        <div class="P_l_G">
                            <asp:Label ID="L_GB" runat="server"  Text="Geboortedatum:"></asp:Label> 
                        </div>
                        <div class="P_l_AD">
                            <asp:Label ID="L_Adres" runat="server"  Text="Adres:"></asp:Label>
                        </div>
                        <div class="P_l_P">
                            <asp:Label ID="L_Postcode" runat="server"  Text="Postcode:"></asp:Label>
                        </div>                      
                        <div class="P_l_Pl">
                            <asp:Label ID="L_Plaats" runat="server" Text="Plaats:"></asp:Label>
                        </div> 
                        <div class="P_l_L">
                            <asp:Label ID="L_Land" runat="server" Text="Land:"></asp:Label>
                        </div> 
                        <div class="P_l_K">
                            <asp:Label ID="L_Klant" runat="server" Text="Klantstatus:"></asp:Label>
                        </div>
                    </div>
                    <div class="Pers_left_r">

                        <asp:TextBox ID="Tb_naam" runat="server" Width="195px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="Tb_achternaam" runat="server" Width="194px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="Tb_geboortedatum" runat="server" Width="103px"></asp:TextBox>
                        dd-mon-yyyy<br />
                        <br />
                        <asp:TextBox ID="Tb_adres" runat="server" Width="191px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="Tb_postcode" runat="server" Width="194px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="Tb_plaats" runat="server" Width="195px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="Tb_land" runat="server" Width="186px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:CheckBox ID="CB_Koper" runat="server" Text="Koper" />
                        <asp:CheckBox ID="CB_Verkoper" runat="server" Text="Verkoper" />

                        <br />
                        <br />

                    </div>
                </div>
                <div class="Pers_right">
                    <h5> Inloggegevens</h5> 
                    <p>Het e-mailadres en wachtwoord zijn nodig om toegang te krijgen tot de gegevens. Ook zullen we je via dit e-mailadres op de hoogte houden van de status van bestellingen.</p>
                    <div class="Pers_r_l">
                        <div class="P_R_E">
                            <asp:Label ID="P_R_E" runat="server" Text="E-mail:"></asp:Label>
                        </div>
                        <div class="P_R_W">
                            <asp:Label ID="P_R_W" runat="server" Text="Wachtwoord:"></asp:Label>
                        </div>
                        <div class="P_R_WA">
                            <asp:Label ID="P_R_WA" runat="server" Text="Wachtwoord bevestigd:"></asp:Label>
                        </div>
                    </div>
                    <div class="Pers_r_r">
                        <asp:TextBox ID="TB_Email" runat="server" Width="182px" Enabled="False"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="TB_Wachtwoord" runat="server" Width="181px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="TB_Wachtwoord1" runat="server" Width="178px"></asp:TextBox>
                    </div>
                    <div class="P_r_b">
                        <h5>Nieuwsbrief</h5>
                        <p>Blijf op de hoogte van alle acties en voordelen via de bol.com Nieuwsbrief. Je ontvangt het laatste nieuws direct in je mailbox. Uitschrijven kan op ieder gewenst moment.</p>
                        <div class="Cb_Nieuws">
                            <asp:CheckBox ID="CB_nieuws" runat="server" Text="Ja, ik profiteer graag van alle voordelen en acties en schrijf me in voor de bol.com Nieuwsbrief." Font-Size="10px" />
                        </div>
                    </div>
                    <div class="TB_verzend">
                        <asp:Button ID="Button1" runat="server" Text="Verzend" OnClick="Button1_Click" />
                    </div>
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="Pers_tekst">
                <h5>Privacy Policy</h5> 

             <p>Persoonlijke gegevens worden veilig opgeslagen en alleen gebruikt volgens onze Privacy Policy . 

              Bol.com respecteert de privacy van alle gebruikers van zijn site en behandelt persoonlijke informatie vertrouwelijk. Wij gebruiken deze gegevens om de bestellingen zo snel en gemakkelijk mogelijk te laten verlopen. Voor het overige zullen wij deze gegevens uitsluitend gebruiken na toestemming. Bol.com zal persoonlijke gegevens niet aan derden verkopen en zal deze uitsluitend aan derden ter beschikking stellen die zijn betrokken bij het uitvoeren van deze bestelling.</p>
            </div>
        </div>
        <div class="Footer">
            <h4>Made by Lino</h4>
        </div>
    </form>
</body>
</html>
