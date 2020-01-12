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
        public string betyg { get; set; }
        public string kursID { get; set; }
        public string lärarlagID { get; set; }

        private List<Lärare> Lärarlag = new List<Lärare>();

        public List<Lärare> HämtaLärare() 
        {
            return Lärarlag;
        }

        private List<Student> Studenter = new List<Student>();

        public List<Student> HämtaStudent()
        {
            return Studenter;
        }


        public Kurs(string kursNamn, DateTime startdatum, DateTime slutdatum, string betyg, string kursID, string lärarlagID, List<Lärare> lärarlag, List<Student> studenter)
        {
            this.kursNamn = kursNamn;
            this.startDatum = startdatum;
            this.slutDatum = slutdatum;
            this.betyg = betyg;
            this.kursID = kursID;
            this.lärarlagID = lärarlagID;
            this.Lärarlag = lärarlag;
            this.Studenter = studenter;

        }
    
    }
}
