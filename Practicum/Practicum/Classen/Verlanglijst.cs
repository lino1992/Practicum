using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Verlanglijst
    {
        private string titel;
        private string datum;
        private Int32 klantid;
        private Int64 isbnnummer;

        private string Titel { get { return titel; } }
        private string Datum { get { return datum; } }
        private Int32 Klantid { get { return klantid; } }
        private Int64 Isbnnummer { get { return isbnnummer; } }

        public Verlanglijst ( string titel,string datum,Int32 klantid,Int64 isbnnummer)
        {
            this.titel = titel;
            this.datum = datum;
            this.klantid = klantid;
            this.isbnnummer = isbnnummer;
        }
    }
}