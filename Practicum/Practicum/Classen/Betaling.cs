using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Betaling
    {
        private Int32 betalingnummer;
        private string betalingmethode;
        private Int32 kortingcode;
        private Int32 factuurnummer;

        public Int32 Bestalingnummer { get { return betalingnummer; } set { value = betalingnummer; } }
        public string Betalingmethode { get { return betalingmethode; } }
        public Int32 Kortingcode { get { return kortingcode; } }
        public Int32 Factuurnummer { get { return factuurnummer; } set { value = factuurnummer; } }

        public Betaling( Int32 betalingnummer,string betalingmethode,Int32 kortingcode,Int32 factuurnummer)
        {
            this.betalingnummer = betalingnummer;
            this.betalingmethode = Betalingmethode;
            this.kortingcode = kortingcode;
            this.factuurnummer = factuurnummer;
        }
    }
}