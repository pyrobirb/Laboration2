using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Student : Person
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


        private string studentID;
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string betyg;
        public string Betyg
        {
            get { return betyg; }
            set { betyg = value; }
        }

        public string StudentFullName
        {
            get { return Förnamn + " " + Efternamn; }
        }


        //Detta är konstruktor
        public Student(string personnummer, string förnamn, string efternamn, string adress, string telefonnummer, string epostadress, string lösenord, string studentID, string betyg)
        {
            this.Personnummer = personnummer;
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Adress = adress;
            this.Telefonnummer = telefonnummer;
            this.Epostadress = epostadress;
            this.Lösenord = lösenord;
            this.StudentID = studentID;
            this.Betyg = betyg;
        }

        private static List<Student> studentLista = new List<Student>();

        public static List<Student> StudentLista
        {
            get { return studentLista; }
            set { studentLista = value; }
        }


        public override string HämtaPersonuppgifter(string personnummer)
        {
            throw new NotImplementedException();
        }
    }
}
