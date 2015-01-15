using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practicum.Classen;

namespace Practicum
{
    public partial class Bestellen : System.Web.UI.Page
    {
        Int32 klant = 0;
        Int64 boekid = 0;
        string status = "";
        Boek b = null;
        Uitvoering uitvoering = new Uitvoering();
        /// <summary>
        /// hierbij check ik of de session is leeg zijn als dat niet het geval is dan wordt de interface verandert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Klantid"] != null)
            {
                Lb_login.InnerText = "Log Out";
                klant = (Int32)Session["Klantid"];
            }
            if(Session["Boekid"] != null)
            {
                
                boekid = (Int64)Session["Boekid"];
                b = uitvoering.GetBoekinfor(boekid);
                TB_Isbnnummer.Text = "" + boekid;
                TB_Status.Text = b.Status;
                TB_Titel.Text = b.Titel;
                TB_prijs.Text = Convert.ToString(b.Prijs);
            }

            if (status == "KOPER")
            {
                Lb_Ver.Visible = false;
            }
            if (status == "VERKOPER")
            {
                Lb_Ver.Visible = true;
            }
            load();
        }
        /// <summary>
        /// deze methode laad de gridview die in de interface staan
        /// </summary>
        private void load()
        {
            SqlDataSource1.SelectCommand = uitvoering.GetKlantgegevens(klant);
            
        }
        /// <summary>
        /// hier worden de bestellng aan gemaakt op het database
        /// en ook wordt er meteen nieuw factuur gemaakt
        /// ook de betaling gegevens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Tb_bevestig_Click(object sender, EventArgs e)
        {
            bool check = false;
            int betaald = 0;
            int levering = 0;
            int korting = 0;
            string betaling = "";
            b = uitvoering.GetBoekinfor(boekid);
            if(b.Status == "NIEUWE BOEK")
            {
                levering = 1;
            }
            if(Cb_betaald_ja.Checked == true)
            {
                betaald = 1;
            }
            if(Cb_betaling_Ideal.Checked)
            {
                betaling = "IDEAL";
            }
            else
            {
                betaling = "ACHTERAF BETALEN";
            }
            if(TB_korting.Text != "")
            {
                korting = Convert.ToInt32(TB_korting.Text);
            }
            check = uitvoering.NieuwBestelling(levering, Convert.ToInt32(TB_prijs.Text), klant, Convert.ToInt64(TB_Isbnnummer.Text));
            check = uitvoering.NieuwFactuur(Convert.ToInt32(TB_prijs.Text), betaald);
            check = uitvoering.NieuwBetaling(betaling, korting);
            string script = "alert(\"Bestelling is geplaats\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
            "ServerControlScript", script, true);
        }
    }
}