using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Nieuwsbrief
    {
        private Int32 nieuwsbriefnummer;
        private string omschrijving;
        private string datum;

        public Int32 Nieuwsbriefnummer { get { return nieuwsbriefnummer; } }
        public string Omschrijving { get { return omschrijving; } }
        public string Datum { get { return datum; } }

        public Nieuwsbrief( Int32 nieuwsbriefnummer,string omschrijving,string datum)
        {
            this.nieuwsbriefnummer = nieuwsbriefnummer;
            this.omschrijving = omschrijving;
            this.datum = datum;
        }
    }
}