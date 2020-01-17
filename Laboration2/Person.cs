using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Person : IPerson
    {
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



        public virtual string HämtaPersonuppgifter(string personnnummer)
        {
            return Personnummer + " " + Förnamn + " " + Efternamn + "    " + "Adress:" + Adress + "    " + "Telnr:" + Telefonnummer + "    " + "Epost:" + Epostadress;
        }


    }
}
