using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Boek
    {
        private Int64 isbnnummer;
        private string titel;
        private decimal prijs;
        private string status;

        public Int64 Isbnnummer { get { return isbnnummer; } }
        public string Titel { get { return titel; } }
        public decimal Prijs { get { return prijs; } set { value = prijs; } }
        public string Status { get { return status; } }

        public Boek( Int64 isbnnummer,string titel,decimal prijs,string status)
        {
            this.isbnnummer = isbnnummer;
            this.titel = titel;
            this.prijs = prijs;
            this.status = status;
        }
    }
}