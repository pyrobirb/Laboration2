using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Laboration : IKurs
    {


        public List<Lärare> HämtaKursLärare()
        {
            throw new NotImplementedException();
        }

        public List<Student> HämtaKursStudent()
        {
            throw new NotImplementedException();
        }



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

        public Laboration(string labNamn, string labinfo, List<Student> students)
        {
            LabNamn = labNamn;
            LabInfo = labinfo;
            studenterPåLabb = students;
        }
        
    }
}
