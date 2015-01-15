using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Overzicht
    {
        private Int32 besteloverzicht;
        private Int32 totaal;
        private string bestelstatus;
        private string verzending;
        private string artikel;
        private decimal totaalprijs;
        private string extrainfor;
        private Int32 factuurnummer;
        private string date;
        private Int32 bestelnummer;

        public Int32 Besteloverzicht { get { return besteloverzicht; } }
        public Int32 Totaal { get { return totaal; } }
        public string Bestelstatus { get { return bestelstatus; } }
        public string Verzending { get { return verzending; } }
        public string Artikel { get { return artikel; } }
        public decimal Totaalprijs { get { return totaalprijs; } }
        public string Extrainfor { get { return extrainfor; } }
        public Int32 Factuurnummer { get { return factuurnummer; } }
        public string Date { get { return date; } }
        public Int32 Bestelnummer { get { return bestelnummer; } }

        public Overzicht( Int32 besteloverzicht,Int32 totaal,string bestelstatus,string verzending,string artikel,decimal totaalprijs,string extrainfor,Int32 factuurnummer,string date,Int32 bestelnummer)
        {
            this.besteloverzicht = besteloverzicht;
            this.totaal = totaal;
            this.bestelstatus = bestelstatus;
            this.verzending = verzending;
            this.artikel = artikel;
            this.totaalprijs = totaalprijs;
            this.extrainfor = extrainfor;
            this.factuurnummer = factuurnummer;
            this.date = date;
            this.bestelnummer = bestelnummer;
        }
    }
}