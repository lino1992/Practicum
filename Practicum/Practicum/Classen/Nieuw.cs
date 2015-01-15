using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Nieuw
    {
        private Int32 boekid;
        private string titel;
        private decimal prijs;
        private string omschrijving;
        private string korting;
        private string beschikbaar;
        private Int64 isbnummer;

        public Int32 Boekid { get { return boekid; } }
        public string Titel { get { return titel; } }
        public decimal Prijs { get { return prijs; } }
        public string Omschrijving { get { return omschrijving; } }
        public string Korting { get { return korting; } }
        public string Beschikbaar { get { return beschikbaar; } }
        public Int64 Isbnummer { get { return isbnummer; } }

        public Nieuw( Int32 boekid,string titel,decimal prijs,string omschrijving,string korting,string beschikbaar,Int64 isbnummer)
        {
            this.boekid = boekid;
            this.titel = titel;
            this.prijs = prijs;
            this.omschrijving = omschrijving;
            this.korting = korting;
            this.beschikbaar = beschikbaar;
            this.isbnummer = isbnummer;
        }
    }
}