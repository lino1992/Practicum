using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicum.Classen
{
    public class Klant
    {
        private Int32 klantid;
        private string naam;
        private string achternaam;
        private string geboortedatum;
        private string adres;
        private string postcode;
        private string plaats;
        private string land;
        private string klantstatus;
        private string username;
        private string password;
        private string email;

        public Int32 Klantid { get { return klantid; } }
        public string Naam { get { return naam; } set { value = naam; } }
        public string Achternaam { get { return achternaam; } set { value = achternaam; } }
        public string Geboortedatum { get { return geboortedatum; } set { value = geboortedatum; } }
        public string Adres { get { return adres; } set { value = adres; } }
        public string Postcode { get { return postcode; } set { value = postcode; } }
        public string Plaats { get { return plaats; } set { value = plaats; } }
        public string Land { get { return land; } set { value = land; } }
        public string Klantstatus { get { return klantstatus; } set { value = klantstatus; } }
        public string Username { get { return username; } set { value = username; } }
        public string Password { get { return password; } set { value = password; } }
        public string Email { get { return email; } set { value = email; } }

        public Klant(Int32 klantid, string naam, string achternaam, string geboortedatum, string adres, string postcode, string plaats, string land, string klantstatus, string username, string password, string email)
        {
            this.klantid = klantid;
            this.naam = naam;
            this.achternaam = achternaam;
            this.geboortedatum = geboortedatum;
            this.adres = adres;
            this.postcode = postcode;
            this.plaats = plaats;
            this.postcode = postcode;
            this.klantstatus = klantstatus;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public Klant()
        {

        }
    }
}