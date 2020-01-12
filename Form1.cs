using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListBox VisaStudenterlistBox = new ListBox();
            VisaStudenterlistBox.Items.Clear();

            VisaStudenterlistBox.DisplayMember = "förnamn";
            VisaStudenterlistBox.ValueMember = "studentID";


            ListBox VisaLärarelistBox = new ListBox();
            VisaLärarelistBox.Items.Clear();

            VisaLärarelistBox.DisplayMember = "förnamn";
            VisaLärarelistBox.ValueMember = "lärarID";

        }

        private void VisaStudenterlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Studentlista
            var studentLista = Student.StudentLista();

            foreach (var item in studentLista)
            {
                VisaStudenterlistBox.Items.Add(String.Format("{0} {1} {2}", item.studentID.ToUpper(), item.förnamn, item.efternamn));

            }

            VisaStudenterlistBox.Sorted = true;
            VisaStudenterlistBox.TopIndex = 0;



            //Lärarelista


            var lärareLista = Lärare.LärareLista();

            foreach (var item in lärareLista)
            {
                VisaLärarelistBox.Items.Add(String.Format("{0} {1} {2}", item.LärarID.ToUpper(), item.förnamn, item.efternamn));

            }

            VisaLärarelistBox.Sorted = true;
            VisaLärarelistBox.TopIndex = 0;


            //Kursnamn







        }

        private void VisaLärarelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KursNamnInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SlutdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            string KursNamn = kursNamnInputTextBox.Text;
            DateTime StartDateTime = StartdateTimePicker.Value;
            DateTime SlutDateTime = StartdateTimePicker.Value;
            string betyg = "U, G, VG";
            string KursID = "12345";
            string LärarlagID = "999";
            var lärarlag = VisaLärarelistBox.SelectedItems;
            var studentlag = VisaStudenterlistBox.SelectedItems;

            var lärareLista = Lärare.LärareLista();


            List<Lärare> LärarLag = new List<Lärare>();

            foreach (var item in lärareLista)
            {
                foreach (var item2 in lärarlag)
                {
                    if (item2.ToString().ToUpper().Contains(item.LärarID.ToString().ToUpper()))
                    {
                        LärarLag.Add(item);
                    }
                }
            }


            var studentListan = Student.StudentLista();

            List<Student> DeltagandeStudenter = new List<Student>();

            foreach (var item in studentListan)
            {
                foreach (var item2 in DeltagandeStudenter)
                {
                    if (item2.ToString().ToUpper().Contains(item.studentID.ToUpper().ToString()))
                    {
                        DeltagandeStudenter.Add(item);
                    }
                }


            }


            Kurs nyKurs = new Kurs(KursNamn, StartDateTime, SlutDateTime, betyg, KursID, LärarlagID, LärarLag, DeltagandeStudenter);




            DeltagandeStudenter.ForEach(i => Console.WriteLine("{0}\t", i));
            foreach (var item in DeltagandeStudenter)
            {
                Console.WriteLine(string.Join("\t", item));
            }
        }

        private void betygtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
