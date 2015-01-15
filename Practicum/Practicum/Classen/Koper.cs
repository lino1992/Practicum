using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Koper
    {
        private Int32 koperid;
        private string leveradres;
        private Int32 klantid;

        public Int32 Koperid { get { return koperid; } }
        public string Leveradres { get { return leveradres; } }
        public Int32 Klantid { get { return klantid; } }

        public Koper( Int32 koperid,string leveradres,Int32 klantid)
        {
            this.koperid = koperid;
            this.leveradres = leveradres;
            this.klantid = klantid;
        }
    }
}