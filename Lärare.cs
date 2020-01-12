using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Lärare : Person
    {
        

        public override string personnummer { get; set; }
        public override string förnamn { get; set; }
        public override string efternamn { get; set; }
        public override string adress { get; set; }
        public override string telefonnummer { get; set; }
        public override string epostadress { get; set; }
        public override string lösenord { get; set; }

        public string LärarID { get; set; }

        public override string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
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
            this.LärarID = lärarID;
        }


        public static List<Lärare> lärareLista { get; set; } = new List<Lärare>();

        public static List<Lärare> LärareLista()
        {
            
            return lärareLista;
        }
    }
}
