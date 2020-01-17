using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Lärare : Person
    {


        private static List<Lärare> lärareLista = new List<Lärare>();

        public static List<Lärare> LärareLista
        {
            get { return lärareLista; }
            set { lärareLista = value; }
        }



        private string personnummer;

        public string Personnummer
        {
            get { return personnummer; }
            set { personnummer = value; }
        }


        private string förnamn;

        public string Förnamn
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        private string efternamn;

        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }


        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private string telefonnummer;

        public string Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }

        private string epostadress;

        public string Epostadress
        {
            get { return epostadress; }
            set { epostadress = value; }
        }

        private string lösenord;

        public string Lösenord
        {
            get { return lösenord; }
            set { lösenord = value; }
        }


        private string lärarID;

        public string LärarID
        {
            get { return lärarID; }
            set { lärarID = value; }
        }

        public string LärareFullName
        {
            get { return Förnamn + " " + Efternamn; }
        }

        public override string HämtaPersonuppgifter(string personnnummer)
        {
            return Personnummer + " " + Förnamn + " " + Efternamn + "    " + "Adress:" + Adress + "    " + "Telnr:" + Telefonnummer + "    " + "Epost:" + Epostadress;
        }

        public Lärare(string personnummer, string förnamn, string efternamn, string adress, string telefonnummer, string epostadress, string lösenord, string lärarID)
        {
            this.personnummer = personnummer;
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.adress = adress;
            this.telefonnummer = telefonnummer;
            this.epostadress = epostadress;
            this.lösenord = lösenord;
            this.lärarID = lärarID;
        }

    }
}
