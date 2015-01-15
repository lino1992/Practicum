using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Factuur
    {
        private Int32 factuurnummer;
        private string datum;
        private decimal bedrag;
        private string vervaldatum;
        private string betaald;

        public Int32 Factuurnummer { get { return factuurnummer; } }
        public string Datum { get { return datum; } }
        public decimal Bedrag { get { return bedrag; } }
        public string Vervaldatum { get { return vervaldatum; } }
        public string Betaald { get { return betaald; } }

        public Factuur( Int32 factuurnummer,string datum,decimal bedrag,string vervaldatum,string betaald)
        {
            this.factuurnummer = factuurnummer;
            this.datum = datum;
            this.bedrag = bedrag;
            this.vervaldatum = vervaldatum;
        }
    }
}