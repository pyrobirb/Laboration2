using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {
        private string kursNamn;

        public string KursNamn
        {
            get { return kursNamn; }
            set { kursNamn = value; }
        }


        private DateTime startDatum;

        public DateTime StartDatum
        {
            get { return startDatum; }
            set { startDatum = value; }
        }
        private DateTime slutDatum;

        public DateTime SlutDatum
        {
            get { return slutDatum; }
            set { slutDatum = value; }
        }
       
        private string kursID;

        public string KursID
        {
            get { return kursID; }
            set { kursID = value; }
        }

        private string lärarLagID;

        public string LärarLagID
        {
            get { return lärarLagID; }
            set { lärarLagID = value; }
        }


        private List<Lärare> deltagandeLärareISpecifikKurs_LärarLag;

        public List<Lärare> DeltagandeLärareISpecifikKurs_LärarLag
        {
            get { return deltagandeLärareISpecifikKurs_LärarLag; }
            set { deltagandeLärareISpecifikKurs_LärarLag = value; }
        }

        private List<Student> deltagandeStudenterISpecifikKurs;

        public List<Student> DeltagandeStudenterISpecifikKurs
        {
            get { return deltagandeStudenterISpecifikKurs; }
            set { deltagandeStudenterISpecifikKurs = value; }
        }



        public Kurs(DateTime startdatum, DateTime slutdatum, string kursID, string kursnamn, string lärarlagID, List<Lärare> lärare, List<Student> studenter, List<Laboration> nylaborationLista)
        {
            this.StartDatum = startdatum;
            this.SlutDatum = slutdatum;
            this.KursID = kursID;
            this.KursNamn = kursnamn;
            this.LärarLagID = lärarlagID;
            this.deltagandeLärareISpecifikKurs_LärarLag = lärare;
            this.deltagandeStudenterISpecifikKurs = studenter;
            this.Laborationer = nylaborationLista;
            
        }

        

        public static void LäggTillKurs_SkrivÖverKursMedSammaKursID(Kurs nyKurs)
        {

            var aktivLista = PågåendeKurser;
            foreach (var kurs in aktivLista)
            {
                if (kurs.kursID == nyKurs.kursID)
                {
                    for (int i = 0; i < aktivLista.Count; i++)
                    {
                        aktivLista.Remove(kurs);
                        
                        PågåendeKurser = aktivLista;
                        break;
                    }
                    break;
                }
            }
            aktivLista.Add(nyKurs);

        }
        public static void TaBortKurs(Kurs kursAttTaBort)
        {
            PågåendeKurser.Remove(kursAttTaBort);
        }

        
        

        public List<Student> ListaAllaDeltagandeStudenter()
        {
            return DeltagandeStudenterISpecifikKurs;
        }

        public List<Lärare> ListaAllaDeltagandeLärare()
        {
            return DeltagandeLärareISpecifikKurs_LärarLag;
        }

        private static List<Kurs> pågåendeKurser = new List<Kurs>();

        public static List<Kurs> PågåendeKurser
        {
            get { return pågåendeKurser; }
            set { pågåendeKurser = value; }
        }

        private List<Laboration> laborationer = new List<Laboration>();

        public List<Laboration> Laborationer
        {
            get { return laborationer; }
            set { laborationer = value; }
        }

    }

}
