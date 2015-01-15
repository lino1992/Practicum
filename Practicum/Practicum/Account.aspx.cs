using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practicum.Classen;

namespace Practicum
{
    public partial class Account : System.Web.UI.Page
    {
        Int32 klantid = 0;
        Klant k = null;
        string status = "";
        private Uitvoering uitvoering = new Uitvoering();
        //bij deze page_load regel ik de interface van de account.aspx wat wil wordt aan getoont en wat niet;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Klantid"] != null)
            {
                Lb_login.InnerText = "Log Out";
                klantid = (Int32)Session["Klantid"];
            }
            status = (string)Session["Status"];
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
        /// bij deze methode laad ik de sqldatasource voor alle gridview die worden gebruikt in deze pagina
        /// </summary>
        private void load()
        {
            Gegevens_GD.DataSource = uitvoering.GetKlantGegevens(klantid);
            GD_Factuur.DataSource =  uitvoering.Getfactuur(klantid);
            GD_Verlanglijst.DataSource = uitvoering.Getverlanglijst(klantid);
            Gekochte_boeken.DataSource = uitvoering.GetGekochte(klantid);
            Gegevens_GD.DataBind();
            Gekochte_boeken.DataBind();
            GD_Factuur.DataBind();
            GD_Verlanglijst.DataBind();

         }
        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
    }
}