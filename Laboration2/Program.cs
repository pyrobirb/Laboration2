using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Student.StudentLista.Add(new Student("198502069999", "Lisa", "Svensson", "Fiskarevägen 8b", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s148820", ""));
            Student.StudentLista.Add(new Student("199001011111", "Korvi", "Sveni", "Rönngatan 4", "0721489696", "svenssonian@gmail.com", "hbvjujhgjkk", "s168880", ""));
            Student.StudentLista.Add(new Student("195862304878", "Nyr", "Lostuio", "Tistelvägen 4", "0721584696", "nsson@gmail.com", "hbvju68", "s181820", ""));
            Student.StudentLista.Add(new Student("198508256969", "Vera", "Vol", "Tistelvägen 4", "0721584696", "nsson@gmail.com", "hbvju68", "s181220", ""));
            Student.StudentLista.Add(new Student("199906066666", "Olof", "Malmberg", "Holberg 8", "0721584696", "nsson@gmail.com", "hbvju68", "s191820", ""));
            Student.StudentLista.Add(new Student("198502062085", "Nombi", "Komf", "Tistelvägen 4", "0721584696", "nsson@gmail.com", "hbvju68", "s138820", ""));



            Lärare.LärareLista.Add(new Lärare("199001011111", "Sisa", "Evensson", "Rögatan 56", "0721489696", "huhhuhson@gmail.com", "hbvjucyghu68", "L168820"));
            Lärare.LärareLista.Add(new Lärare("196005036936", "Göran", "Vertsson", "Rösegatan 3", "0721489696", "nnnnnnson@gmail.com", "hbvjucyghu68", "L12222"));
            Lärare.LärareLista.Add(new Lärare("194205084747", "Fílippi", "Conolip", "Bilgatan 5", "0721489696", "lasvensson@gmail.com", "hbvjucyghu68", "L18888"));
            Lärare.LärareLista.Add(new Lärare("196605085555", "Sissian", "Zonol", "Wistberg 9", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L16666"));
            

            

            var kursLista = Kurs.PågåendeKurser;
            var tidNu = DateTime.Today;
            
            List<Lärare> lärarlag1 = new List<Lärare>();
            lärarlag1.Add(new Lärare("196605085555", "Sissian", "Zonol", "Wistberg 9", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L16666"));
            lärarlag1.Add(new Lärare("194205084747", "Fílippi", "Conolip", "Bilgatan 5", "0721489696", "lasvensson@gmail.com", "hbvjucyghu68", "L18888"));

            List<Student> studentlag1 = new List<Student>();
            studentlag1.Add(new Student("198502069999", "Lisa", "Svensson", "Fiskarevägen 8b", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s148820", ""));
            studentlag1.Add(new Student("199001011111", "Korvi", "Sveni", "Rönngatan 4", "0721489696", "svenssonian@gmail.com", "hbvjujhgjkk", "s168880", ""));
            studentlag1.Add(new Student("195862304878", "Nyr", "Lostuio", "Tistelvägen 4", "0721584696", "nsson@gmail.com", "hbvju68", "s181820", ""));
            studentlag1.Add(new Student("198502062085", "Nombi", "Komf", "Tistelvägen 4", "0721584696", "nsson@gmail.com", "hbvju68", "s138820", ""));


            var lab = new Laboration("Lab1", "Information om lab1", studentlag1);
            var lab2 = new Laboration("Lab2", "Information om lab2", studentlag1);
            List<Laboration> labbar = new List<Laboration>();
            labbar.Add(lab);
            labbar.Add(lab2);



            kursLista.Add(new Kurs(tidNu, tidNu, "-", "SYKUN1", "Sykunskap 1", "kjuy769", lärarlag1, studentlag1, labbar));

            kursLista.Add(new Kurs(tidNu, tidNu, "-", "SYKUN2", "Sykunskap 2", "kjuy769", lärarlag1, studentlag1, labbar));






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _Välkommen());


            //List<Student> studentLista = new List<Student>();
            //Student Student = new Student("199001011111", "Lisa", "Svensson", "Rönngatan 4", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s168820");

            //studentLista = a;
            
        }

        
    }
}
