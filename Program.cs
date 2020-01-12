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
            
            Lärare.lärareLista.Add(new Lärare("199001011111", "Sisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L188820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Hisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L148820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Pisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L158820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Sisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L118820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Zisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L108820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Gisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L188820"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Hisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L163320"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Uisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L164420"));
            Lärare.lärareLista.Add(new Lärare("199001011111", "Kisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "L165520"));

            Student.studentLista.Add(new Student("199001011111", "Lisa", "Svensson", "Rönngatan 10", "0721423496", "lisasvensson@gmail.com", "hbvjucyghu68", "s168820"));
            Student.studentLista.Add(new Student("199001011111", "Misa", "Fvensson", "Röngatan 40", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s168824"));
            Student.studentLista.Add(new Student("199001011111", "Sisa", "Evensson", "Rögatan 56", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s168823"));
            Student.studentLista.Add(new Student("199001011111", "Kisa", "Avensson", "Lönngatan 4", "0721243696", "lisasvensson@gmail.com", "hbvjucyghu68", "s168821"));
            Student.studentLista.Add(new Student("199001011111", "Pisa", "Savensson", "Lonngatan 4", "0721654396", "lisasvensson@gmail.com", "hbvjucyghu68", "s168825"));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            


        }
    }
}
