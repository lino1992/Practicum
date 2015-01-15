using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practicum.Classen;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace PracticumTest
{
    [TestClass]
    public class UnitTest1
    {
        Uitvoering uitvoering = new Uitvoering();
        [TestInitialize]
        public void Initalize()
        {
            Klant klant = new Klant(12345, "lino", "thaencharun", "19-10-1990", "kavinksbosch", "4443ap", "eindhoven", "nederland", "verkoper", "linoth", "test1", "55@hotmail.com");
            Boek boek = new Boek(242342, "rode kpaje", 45, "nieuw");
            Betaling betaling = new Betaling(323232, "Ideal", 23423, 23432543);
            Factuur factuur = new Factuur(324234, "19-10-1990", 22, "14-1-2015", "voldaan");
            
        }
        [TestMethod]
        public void InsertAccount(Klant klant)
        {
            klant = new Klant(12345, "lino", "thaencharun", "19-10-1990", "kavinksbosch", "4443ap", "eindhoven", "nederland", "VERKOPER", "linoth", "test1", "55@hotmail.com");
            OracleCommand c = Database.storedprocedure("NewAccount");
            c.Parameters.Add("naam", OracleDbType.Varchar2).Value = klant.Naam;
            c.Parameters.Add("achternaam", OracleDbType.Varchar2).Value = klant.Achternaam;
            c.Parameters.Add("geboortedatum", OracleDbType.Varchar2).Value = klant.Geboortedatum;
            c.Parameters.Add("adres", OracleDbType.Varchar2).Value = klant.Adres;
            c.Parameters.Add("postcode", OracleDbType.Varchar2).Value = klant.Postcode;
            c.Parameters.Add("plaats", OracleDbType.Varchar2).Value = klant.Plaats;
            c.Parameters.Add("land", OracleDbType.Varchar2).Value = klant.Land;
            c.Parameters.Add("klantstatus", OracleDbType.Varchar2).Value = klant.Klantstatus;
            c.Parameters.Add("pasword", OracleDbType.Varchar2).Value = klant.Password;
            c.Parameters.Add("email", OracleDbType.Varchar2).Value = klant.Email;
            c.ExecuteNonQuery();

        }
        [TestMethod]
        public List<Boek> Getboeken()
        {
            List<Boek> b = new List<Boek>();
            OracleDataReader r = Database.readdata("SELECT ISBNNUMMER, TITEL, PRIJS, STATUS FROM DB21_BOEK");
            while (r.Read())
            {
                Int64 id = Convert.ToInt64(r["ISBNNUMMER"].ToString());
                string titel = r["TITEL"].ToString();
                decimal prijs = Convert.ToDecimal(r["PRIJS"].ToString());
                string status = r["STATUS"].ToString();
                b.Add(new Boek(id, titel, prijs, status));
            }
            return b;
        }
        [TestMethod]
        public List<Boek> Getboekgegeven1(string booeknaam)
        {
            List<Boek> b = new List<Boek>();
            OracleDataReader r = Database.readdata("SELECT ISBNNUMMER, TITEL, PRIJS, STATUS FROM DB21_BOEK WHERE (TITEL ='" + booeknaam + "')");
            while (r.Read())
            {
                Int64 id = Convert.ToInt64(r["ISBNNUMMER"].ToString());
                string titel = r["TITEL"].ToString();
                decimal prijs = Convert.ToDecimal(r["PRIJS"].ToString());
                string status = r["STATUS"].ToString();
                b.Add(new Boek(id, titel, prijs, status));
            }
            return b;
        }
        [TestMethod]
        public List<Boek> GetGekochte(int klantid)
        {
            List<Boek> b = new List<Boek>();
            OracleDataReader r = Database.readdata("SELECT bo.TITEL, bo.ISBNNUMMER, bo.PRIJS, bo.STATUS FROM DB21_BESTELLING b, DB21_BOEK bo WHERE b.ISBNNUMMER = bo.ISBNNUMMER AND (b.KLANTID = " + klantid + ")");
            while (r.Read())
            {
                Int64 id = Convert.ToInt64(r["bo.ISBNNUMMER"].ToString());
                string titel = r["bo.TITEL"].ToString();
                decimal prijs = Convert.ToDecimal(r["bo.PRIJS"].ToString());
                string status = r["bo.STATUS"].ToString();
                b.Add(new Boek(id, titel, prijs, status));
            }
            return b;
        }

        [TestMethod]
        public Boek GetBoekinfor(Int64 boekid)
        {
            Boek b = null;
            OracleDataReader r = Database.readdata("select * from DB21_BOEK where ISBNNUMMER =" + boekid);
            while (r.Read())
            {
                Int64 id = Convert.ToInt64(r["isbnnummer"].ToString());
                string titel = r["titel"].ToString();
                decimal prijs = Convert.ToDecimal(r["prijs"].ToString());
                string status = r["status"].ToString();
                b = new Boek(id, titel, prijs, status);
            }
            return b;
        }
        [TestMethod]
        private void VulGrudview()
        {
            Practicum.index index = new Practicum.index();
            Boeklijst_GD.DataSource = uitvoering.Getboeken();
            Boeklijst_GD.DataBind();
        }
    }
}
