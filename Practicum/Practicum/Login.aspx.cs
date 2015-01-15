using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practicum.Classen;

namespace Practicum
{
    public partial class Login : System.Web.UI.Page
    {
        Uitvoering uitvoering = new Uitvoering();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// deze click event word gebruikt voor het inloggen. 
        /// er worden bepaalde gegeve opgeslagen. 
        /// en de begin pagina wordt weer geopend.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void B_Log_Click(object sender, EventArgs e)
        {
            Klant k = null;
            Int32 klantid = 0;
            string status = "";
            if(TB_GN.Text == "")
            {
                Label1.Text = "Vull een usernaam in";
                return;
            }
            if(TB_WW.Text == "")
            {
                Label1.Text = "Vull een password in";
                return;
            }
            k = uitvoering.Checklogin(TB_GN.Text, TB_WW.Text);
            if(k != null)
            {
                status = k.Klantstatus;
                klantid = k.Klantid;
                Session.Add("KlantID", klantid);
                Session.Add("Status", status);
                Server.Transfer("index.aspx", true);
            }
            else
            {
                Label1.Text = "Vull een geldige gegevens in";
            }
        }
        /// <summary>
        /// deze click event is voor het navigeren naar de pagina account aanmakn.
        /// de email wordt mee gegeven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TB_E.Text;
            string check = "";
            if(TB_E.Text == "")
            {
                Label1.Text = "Vull een email in";
            }
            check = uitvoering.Checkemail(TB_E.Text);
            if(check == "")
            {
                Session.Add("Email", email);
                Server.Transfer("AccountMaken.aspx", true);
            }
            else
            {
                Label1.Text = "De email bestaat al";
            }
        }

    }
}