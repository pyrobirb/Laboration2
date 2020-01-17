using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Laboration : IKurs
    {

        private string labNamn;

        public string LabNamn
        {
            get { return labNamn; }
            set { labNamn = value; }
        }

        private string labInfo;

        public string LabInfo
        {
            get { return labInfo; }
            set { labInfo = value; }
        }



        private static List<Laboration> laborationer = new List<Laboration>();

        public static List<Laboration> Laborationer
        {
            get { return laborationer; }
            set { laborationer = value; }
        }


        private List<Student> studenterPåLabb;

        public List<Student> StudenterPåLabb
        {
            get { return studenterPåLabb; }
            set { studenterPåLabb = value; }
        }

        private List<Lärare> lärarePåLabb;

        public List<Lärare> LärarePåLabb
        {
            get { return lärarePåLabb; }
            set { lärarePåLabb = value; }
        }

        public List<Student> ListaAllaDeltagandeStudenter()
        {
            return studenterPåLabb;
        }

        public List<Lärare> ListaAllaDeltagandeLärare()
        {
            return LärarePåLabb;
        }

        public Laboration(string labNamn, string labinfo, List<Student> students, List<Lärare> lärare)
        {
            LabNamn = labNamn;
            LabInfo = labinfo;
            studenterPåLabb = students;
            LärarePåLabb = lärare;
        }
        
    }
}
