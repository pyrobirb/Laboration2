using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {

        public string kursNamn { get; set; }

        public DateTime startDatum { get ; set; }
        public DateTime slutDatum { get; set; }
        public string möjligaBetyg { get; set; }
        public string kursID { get; set; }
        public string lärarlagID { get; set; }
        public string slutbetyg { get; set; }

        private List<Lärare> Lärare = new List<Lärare>();

        public List<Lärare> HämtaLärare() 
        {
            return Lärare;
        }

        private List<Student> Studenter = new List<Student>();

        public List<Student> HämtaStudent()
        {
            return Studenter;
        }


        public Kurs(string kursNamn, DateTime startdatum, DateTime slutdatum, string möjligabetyg, string kursID, string lärarlagID, string slutBetyg, List<Lärare> lärare, List<Student> studenter)
        {
            this.kursNamn = kursNamn;
            this.startDatum = startdatum;
            this.slutDatum = slutdatum;
            this.möjligaBetyg = möjligabetyg;
            this.kursID = kursID;
            this.lärarlagID = lärarlagID;
            this.slutbetyg = slutBetyg;
            this.Lärare = lärare;
            this.Studenter = studenter;

        }
    
    }
}
