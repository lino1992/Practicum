using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practicum.Classen;

namespace Practicum
{

    public partial class Verlanglijst : System.Web.UI.Page
    {
        Int32 klant = 0;
        Uitvoering uitvoering = new Uitvoering();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Klantid"] != null)
            {
                Lb_login.InnerText = "Log Out";
                klant = (Int32)Session["Klantid"];
            }
            load();

        }
        /// <summary>
        /// hier wordt de sqlsource geladen voor de gridview op het pagina.
        /// </summary>
        private void load()
        {
            SqlDataSourceAangeboden.SelectCommand = uitvoering.Getverkooplijst(klant);
        }
        /// <summary>
        /// deze click event word gebruikt om de verkooplijst aan te maken op de database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Tb_toevoegen_Click(object sender, EventArgs e)
        {
            if(Tb_Ver_I.Text != "" && Tb_Ver_O.Text != "" && Tb_Ver_P.Text != "" && Tb_Ver_T.Text != "")
            {
                uitvoering.NieuwBoek(Tb_Ver_T.Text, Convert.ToInt32(Tb_Ver_P.Text), Tb_Ver_O.Text, Convert.ToInt64(Tb_Ver_I.Text), Convert.ToInt32(klant));
                string script = "alert(\"Boek is toegevoegd\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Niet alle textbox zijn ingevuld\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                "ServerControlScript", script, true);
            }
            
        }
    }
}