using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Verkoper
    {
        private Int32 verkoperid;
        private Int32 telefoonummer;
        private string winkelgegevens;
        private Int32 banknummer;
        private Int32 klantid;

        public Int32 Verkoperid { get { return verkoperid; } }
        public Int32 Telefoonummer { get { return telefoonummer; } }
        public string Winkelgegevens { get { return winkelgegevens; } }
        public Int32 Banknummer { get { return banknummer; } }
        public Int32 Klantid { get { return klantid; } }

        public Verkoper( Int32 verkoperid,Int32 telefoonummer,string winkelgegevens,Int32 banknummer,Int32 klantid)
        {
            this.verkoperid = verkoperid;
            this.telefoonummer = telefoonummer;
            this.winkelgegevens = winkelgegevens;
            this.banknummer = banknummer;
            this.klantid = klantid;
        }
    }
}