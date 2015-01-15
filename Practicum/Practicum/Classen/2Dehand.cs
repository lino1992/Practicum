using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class _2Dehand
    {
        private Int32 productcode;
        private string titel;
        private decimal prijs;
        private string omschrijving;
        private Int32 isbnnummer;
        private Int32 verkoopnummer;

        public Int32 Productcode { get { return productcode; } }
        public string Titel { get { return titel; } }
        public decimal Prijs { get { return prijs; } }
        public string Omschrijving { get { return omschrijving; } }
        public Int32 Isbnnummer { get { return isbnnummer; } }
        public Int32 Verkoopnummer { get { return verkoopnummer; } }

        public _2Dehand ( Int32 productcode, string titel,decimal prijs,string omschrijving,Int32 isbnnummer,Int32 verkoopnummer)
        {
            this.productcode = productcode;
            this.titel = titel;
            this.prijs = prijs;
            this.omschrijving = omschrijving;
            this.isbnnummer = isbnnummer;
            this.verkoopnummer = verkoopnummer;
        }
        public string to_string()
        {
            string s = Convert.ToString(productcode) + titel + Convert.ToString(prijs) + omschrijving + isbnnummer + verkoopnummer;
            return s;
        }
    }
}