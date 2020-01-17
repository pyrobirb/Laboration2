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
    public partial class _RedigeraKurs : Form
    {
        public _RedigeraKurs()
        {
            InitializeComponent(); 
        }

        private void TaBortKnapp(object sender, EventArgs e)
        {
            var valdKurs = VisaAllaKurserListBox.SelectedItem;

            var kursLista = Kurs.PågåendeKurser;
            foreach (var item in kursLista)
            {
                if (valdKurs == item)
                {

                    Kurs.TaBortKurs(item);

                    VisaAllaKurserListBox.DataSource = null;
                    VisaAllaKurserListBox.DataSource = kursLista;

                    VisaAllaKurserListBox.DisplayMember = "Kursnamn";
                    VisaAllaKurserListBox.ValueMember = "KursID";

                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _RedigeraKurs_Load(object sender, EventArgs e)
        {
            var kursLista = Kurs.PågåendeKurser;

            VisaAllaKurserListBox.DataSource = kursLista;

            VisaAllaKurserListBox.DisplayMember = "Kursnamn";
            VisaAllaKurserListBox.ValueMember = "KursID";


        }

        private void VisaAllaKurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurs selected = (Kurs)VisaAllaKurserListBox.SelectedItem;

            
            allaLaborationerlistBox.DataSource = selected.Laborationer;
            allaLaborationerlistBox.DisplayMember = "LabNamn";
            allaLaborationerlistBox.ValueMember = "LabNamn";

            Laboration selectedLab = (Laboration)allaLaborationerlistBox.SelectedItem;

            labNamntextBox.Text = selectedLab.LabNamn;
            labInfotextBox.Text = selectedLab.LabInfo;

            kursNamnTextBox.Text = selected.KursNamn;
            kursIDtextBox.Text = selected.KursID;
            startDateTimePicker.Value = selected.StartDatum;
            slutDateTimePicker.Value = selected.SlutDatum;
            lärarLagIDtextBox.Text = selected.LärarLagID;
            lärarePåKurslistBox.DataSource = selected.DeltagandeLärareISpecifikKurs_LärarLag;
            studenterPåKurslistBox.DataSource = selected.DeltagandeStudenterISpecifikKurs;



            var allaStudenter = Student.StudentLista;
            List<Student> nyAllaStudenterMinusKursStudenter = new List<Student>();

            foreach (var student in allaStudenter)
            {
                if (!selected.DeltagandeStudenterISpecifikKurs.Contains(student))
                {
                    nyAllaStudenterMinusKursStudenter.Add(student);
                }
            }


            allaStudenterlistBox.DataSource = nyAllaStudenterMinusKursStudenter;


            List<Lärare> nyAllaLärareMinusKursLärare = new List<Lärare>();
            var allaLärare = Lärare.LärareLista;

            foreach (var lärare in allaLärare)
            {
                if (!selected.DeltagandeLärareISpecifikKurs_LärarLag.Contains(lärare))
                {
                    nyAllaLärareMinusKursLärare.Add(lärare);
                }
            }


            allaLärarelistBox.DataSource = nyAllaLärareMinusKursLärare;


            studenterPåKurslistBox.ClearSelected();
            lärarePåKurslistBox.ClearSelected();
            allaLärarelistBox.ClearSelected();
            allaStudenterlistBox.ClearSelected();

            studenterPåKurslistBox.DisplayMember = "StudentFullName";
            studenterPåKurslistBox.ValueMember = "StudentID";
            allaStudenterlistBox.DisplayMember = "StudentFullName";
            allaStudenterlistBox.ValueMember = "StudentID";

            allaLärarelistBox.DisplayMember = "LärareFullName";
            allaLärarelistBox.ValueMember = "LärarID";
            lärarePåKurslistBox.DisplayMember = "LärareFullName";
            lärarePåKurslistBox.ValueMember = "LärarID";

        }

        private void StudenterPåKurslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LärarePåKurslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lärarLagIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void allaStudenterlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allaLärarelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LäggTillStudentbutton_Click(object sender, EventArgs e)
        {
            Kurs selected = (Kurs)VisaAllaKurserListBox.SelectedItem;
            Student selectedStudent = (Student)allaStudenterlistBox.SelectedItem;

            //Student
            var allaStudenter = allaStudenterlistBox.Items.Cast<Student>().ToList();
            var studenterKvarPåKurs = studenterPåKurslistBox.Items.Cast<Student>().ToList();

            List<Student> nyAllaStudenterMinusKursStudenter = new List<Student>();
            List<Student> nyStudenterPåKurs = new List<Student>();

            //Lägg till student (1 åt höger)
            nyStudenterPåKurs = studenterKvarPåKurs;


            nyStudenterPåKurs.Add(selectedStudent);



            //Ta bort student (flytta en åt vänster)
            nyAllaStudenterMinusKursStudenter = allaStudenter;

            foreach (var student in nyAllaStudenterMinusKursStudenter)
            {
                if (student == selectedStudent)
                {
                    nyAllaStudenterMinusKursStudenter.Remove(selectedStudent);
                    break;
                }
            }


            studenterPåKurslistBox.DataSource = nyStudenterPåKurs;
            allaStudenterlistBox.DataSource = nyAllaStudenterMinusKursStudenter;
            
        }

        private void taBortStudentbutton_Click(object sender, EventArgs e)
        {

            Kurs selected = (Kurs)VisaAllaKurserListBox.SelectedItem;
            Student selectedStudent = (Student)studenterPåKurslistBox.SelectedItem;

            //Student
            var allaStudenter = allaStudenterlistBox.Items.Cast<Student>().ToList();
            var studenterKvarPåKurs = studenterPåKurslistBox.Items.Cast<Student>().ToList();

            List<Student> nyAllaStudenterMinusKursStudenter = new List<Student>();
            List<Student> nyStudenterPåKurs = new List<Student>();



            //Lägg till student (1 åt vänster)
            nyAllaStudenterMinusKursStudenter = allaStudenter;
            nyAllaStudenterMinusKursStudenter.Add(selectedStudent);


            //Ta bort student (tabort)


            nyStudenterPåKurs = studenterKvarPåKurs;

            foreach (var student in nyStudenterPåKurs)
            {
                if (student == selectedStudent)
                {
                    nyStudenterPåKurs.Remove(selectedStudent);
                    break;
                }
            }
            //nyAllaStudenterMinusKursStudenter = allaStudenter;



            studenterPåKurslistBox.DataSource = nyStudenterPåKurs;
            allaStudenterlistBox.DataSource = nyAllaStudenterMinusKursStudenter;

        }

        private void LäggTillLärarebutton_Click(object sender, EventArgs e)
        {
            Kurs selected = (Kurs)VisaAllaKurserListBox.SelectedItem;
            Lärare selectedLärare = (Lärare)allaLärarelistBox.SelectedItem;

            //Student
            var allaLärare = allaLärarelistBox.Items.Cast<Lärare>().ToList();
            var lärareKvarPåKurs = lärarePåKurslistBox.Items.Cast<Lärare>().ToList();

            List<Lärare> nyAllaLärareMinusKursLärare = new List<Lärare>();
            List<Lärare> nyLärarePåKurs = new List<Lärare>();

            //Lägg till lärare (1 åt höger)
            nyLärarePåKurs = lärareKvarPåKurs;
            nyLärarePåKurs.Add(selectedLärare);


            //Ta bort lärare (flytta en åt vänster)
            nyAllaLärareMinusKursLärare = allaLärare;

            foreach (var student in nyAllaLärareMinusKursLärare)
            {
                if (student == selectedLärare)
                {
                    nyAllaLärareMinusKursLärare.Remove(selectedLärare);
                    break;
                }
            }

            lärarePåKurslistBox.DataSource = nyLärarePåKurs;
            allaLärarelistBox.DataSource = nyAllaLärareMinusKursLärare;

        }

        private void taBortLärarebutton_Click(object sender, EventArgs e)
        {
            Kurs selected = (Kurs)VisaAllaKurserListBox.SelectedItem;
            Lärare selectedLärare = (Lärare)lärarePåKurslistBox.SelectedItem;

            //Student
            var allaLärare = allaLärarelistBox.Items.Cast<Lärare>().ToList();
            var lärareKvarPåKurs = lärarePåKurslistBox.Items.Cast<Lärare>().ToList();

            List<Lärare> nyAllaLärareMinusKursLärare = new List<Lärare>();
            List<Lärare> nyLärarePåKurs = new List<Lärare>();



            //Lägg till student (1 åt vänster)
            nyAllaLärareMinusKursLärare = allaLärare;
            nyAllaLärareMinusKursLärare.Add(selectedLärare);


            //Ta bort student (tabort)


            nyLärarePåKurs = lärareKvarPåKurs;

            foreach (var student in nyLärarePåKurs)
            {
                if (student == selectedLärare)
                {
                    nyLärarePåKurs.Remove(selectedLärare);
                    break;
                }
            }



            lärarePåKurslistBox.DataSource = nyLärarePåKurs;
            allaLärarelistBox.DataSource = nyAllaLärareMinusKursLärare;
        }

        private void Klarbutton_Click(object sender, EventArgs e)
        {
            string kursnamn = kursNamnTextBox.Text;
            DateTime startDatum = startDateTimePicker.Value;
            DateTime slutDatum = slutDateTimePicker.Value;
            string kursID = kursIDtextBox.Text;
            string lärarlagID = lärarLagIDtextBox.Text;
            var lärarlag = allaLärarelistBox.Items;
            var studentlag = studenterPåKurslistBox.Items;

            //LÄRARMATCHNING
            var lärareLista = Lärare.LärareLista;
            List<Lärare> Lärarlag = new List<Lärare>();

            foreach (var item in lärareLista)
            {
                foreach (var item2 in lärarlag)
                {
                    if (item2 == item)
                    {
                        Lärarlag.Add(item);
                    }
                }
            }

            //STUDENTMATCHNING
            var studentLista = Student.StudentLista;
            List<Student> Studentlag = new List<Student>();

            foreach (var item in studentLista)
            {
                foreach (var item2 in studentlag)
                {
                    if (item2 == item)
                    {
                        Studentlag.Add(item);
                    }

                }
            }


            var LabNamn = labNamntextBox.Text;
            var LabInfo = labInfotextBox.Text;
            List<Student> LabStudenter = studenterPåKurslistBox.Items.Cast<Student>().ToList();
            List<Lärare> LabLärare = lärarePåKurslistBox.Items.Cast<Lärare>().ToList();

            Laboration nyLab = new Laboration(LabNamn, LabInfo, LabStudenter, LabLärare) ;

            List<Laboration> nyLabLista = new List<Laboration>();
            List<Laboration> gammalLabLista = new List<Laboration>();

            Laboration selectedLab = (Laboration)allaLaborationerlistBox.SelectedItem;
            gammalLabLista = allaLaborationerlistBox.Items.Cast<Laboration>().ToList(); ;

            nyLabLista = gammalLabLista;

            nyLabLista.Add(nyLab);

            foreach (var lab in nyLabLista)
            {
                if (lab == selectedLab)
                {
                    nyLabLista.Remove(selectedLab);
                    break;
                }  
            }


            Kurs nyKurs = new Kurs(startDatum, slutDatum, kursID, kursnamn, lärarlagID, Lärarlag, Studentlag, nyLabLista);


            Kurs.LäggTillKurs_SkrivÖverKursMedSammaKursID(nyKurs);

            this.Close();


        }

        private void allaLaborationerlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laboration selectedLab = (Laboration)allaLaborationerlistBox.SelectedItem;

            labNamntextBox.Text = selectedLab.LabNamn;
            labInfotextBox.Text = selectedLab.LabInfo;

            List<Student> selectedLabStudents = selectedLab.ListaAllaDeltagandeStudenter();
            studenterPåLablistBox.DataSource = selectedLabStudents;
            studenterPåLablistBox.DisplayMember = "StudentFullName";
            studenterPåLablistBox.ValueMember = "StudentID";
            lärarePåLablistBox.DataSource = selectedLab.ListaAllaDeltagandeLärare();
            lärarePåLablistBox.DisplayMember = "LärareFullName";
            lärarePåLablistBox.ValueMember = "LärarID";


        }

        private void labInfotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studenterPåLablistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
