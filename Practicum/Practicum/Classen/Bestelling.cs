using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Bestelling
    {
        private Int64 bestelnummer;
        private string artikel;
        private Int32 aantal;
        private string levering;
        private decimal totaalprijs;
        private decimal verzendkosten;
        private Int32 klantid;
        private Int64 isbnnummer;

        public Int64 Bestelnummer { get { return bestelnummer; } }
        public string Artikel { get { return artikel; } }
        public Int32 Aantal { get { return aantal; } }
        public string Levering { get { return levering; } }
        public decimal Totaalprijs { get { return totaalprijs; } }
        public decimal Verzendkosten { get { return verzendkosten; } }
        public Int32 Klantid { get { return klantid; } }
        public Int64 Isbnnummer { get { return isbnnummer; } }

        public Bestelling( Int64 bestelnummer,string artikel,Int32 aantal,string levering,decimal totaalprijs,decimal verzendkosten,Int32 klantid,Int64 isbnnummer)
        {
            this.bestelnummer = bestelnummer;
            this.artikel = artikel;
            this.levering = levering;
            this.totaalprijs = totaalprijs;
            this.verzendkosten = verzendkosten;
            this.klantid = klantid;
            this.isbnnummer = isbnnummer;
        }
    }
}