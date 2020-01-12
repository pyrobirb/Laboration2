using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    interface IPerson
    {
        string personnummer { get; set; }
        string förnamn { get; set; }
        string efternamn { get; set; }
        string adress { get; set; }
        string telefonnummer { get; set; }
        string epostadress { get; set; }
        string lösenord { get; set; }

        string HämtaPersonuppgifter(string personID);
    }
}
