using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practicum.Classen;

namespace Practicum
{
    public partial class AccountMaken : System.Web.UI.Page
    {
        private Uitvoering uitvoering = new Uitvoering();
        /// <summary>
        /// hierbij check ik of de email is niet gelijk is aan null wanneer dat het geval niet is dan laad ik textbox email met de mee gekregen email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Email"] != null)
            {
                TB_Email.Text = (string)Session["Email"];
            }
        }
        /// <summary>
        /// dit is button click om een account aan te maken.
        /// allerst check ik eerst welk textbox is gecheckd
        /// daarna check ik of alle textbox zijn ingevuld;
        /// daarna check ik of de wacht zijn correct ingevuld
        /// als alles zijn ingevuld dan want een  account aan gemaakt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Int32 klantid = 0;
            bool klantstatus = false;
            bool check = false;
            if(CB_Koper.Checked == true)
            {
                klantstatus = true;
            }
            if(Tb_achternaam.Text == "" && Tb_adres.Text == "" && TB_Email.Text == "" && Tb_geboortedatum.Text == "" && Tb_land.Text == "" && Tb_naam.Text == "" && Tb_plaats.Text == "" && Tb_postcode.Text == "" && TB_Wachtwoord.Text == "" && TB_Wachtwoord1.Text == "")
            {
                Label1.Text = "Niet alle benodigde vaktjes zijn ingevuld";
            }
            else
            {
                if(TB_Wachtwoord.Text == TB_Wachtwoord1.Text)
                {
                    check = uitvoering.InsertAccount(Tb_naam.Text, Tb_achternaam.Text, Tb_geboortedatum.Text, Tb_adres.Text, Tb_postcode.Text, Tb_plaats.Text, Tb_land.Text, klantstatus, TB_Wachtwoord.Text, TB_Email.Text);
                    Session.Add("KlantID", klantid);
                    string script = "alert(\"Accout is aan gemaakt\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
                    Server.Transfer("index.aspx", true);
                }
                else
                {
                    Label1.Text = "Wacht komt niet overeens";
                }
            }
        }
    }
}