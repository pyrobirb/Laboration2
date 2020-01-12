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
            string Möjligabetyg = "U, G, VG";
            string KursID = "12345";
            string LärarlagID = "999";
            string Slutbetyg = "Ej satt";
            List<Lärare> DeltagandeLärare = null; // Ändra till selecteditems i lärarlistan
            List<Student> DeltagandeStudenter = null; // Ändra till selecteditems i Studentlistan



            Kurs nyKurs = new Kurs(KursNamn, StartDateTime, SlutDateTime, Möjligabetyg, KursID, LärarlagID, Slutbetyg, DeltagandeLärare, DeltagandeStudenter);

            
        }

       
    }
}
