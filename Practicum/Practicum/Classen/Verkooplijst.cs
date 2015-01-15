using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Verkooplijst
    {
        private int verkoopnummer;
        private decimal prijs;
        private string omschrijving;
        private Int32 verkoperid;

        public int Verkoopnummer { get { return verkoopnummer; } }
        public decimal Prijs { get { return prijs; } }
        public string Omschrijving { get { return omschrijving; } }
        public Int32 Verkoperid { get { return verkoperid; } }

        public Verkooplijst( int verkoopnummer,decimal prijs,string omschrijving,Int32 verkoperid)
        {
            this.verkoopnummer = verkoopnummer;
            this.prijs = prijs;
            this.omschrijving = omschrijving;
            this.verkoperid = verkoperid;
        }
        
    }
}