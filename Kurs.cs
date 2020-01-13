using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {

        public string kursNamn { get; private set; }

        public DateTime startDatum { get; private set; }
        public DateTime slutDatum { get; private set; }
        public string betyg { get; private set; }
        public string kursID { get; private set; }
        public string lärarlagID { get; private set; }

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


        private static List<Kurs> pågåendeKurser = new List<Kurs>();


        public static List<Kurs> HämtaPågåendeKurser()
        {
            return pågåendeKurser;
        }

        public static void LäggTillPågåendeKurs(Kurs nyKurs)
        {
            pågåendeKurser.Add(nyKurs);
        }

        public static void TaBortPågåendeKurs(Kurs nyKurs)
        {
            pågåendeKurser.Remove(nyKurs);
        }

        public static List<Kurs> RedigeraKurs(Kurs kursAttRedigera, List<Kurs> listaAttRedigeraKurs)
        {

            foreach (var item in listaAttRedigeraKurs)
            {
                if (kursAttRedigera.kursID == item.kursID)
                {
                    item.kursNamn = kursAttRedigera.kursNamn;
                    item.startDatum = kursAttRedigera.startDatum;
                    item.slutDatum = kursAttRedigera.slutDatum;
                    item.betyg = kursAttRedigera.betyg;
                    item.kursID = kursAttRedigera.kursID;
                    item.lärarlagID = kursAttRedigera.lärarlagID;
                    item.Studenter = kursAttRedigera.Studenter;
                    item.Lärarlag = kursAttRedigera.Lärarlag;

                    return listaAttRedigeraKurs;
                }
            }
            return null; ;
        }
    
    }
}
