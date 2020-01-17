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
    public partial class _BetygsättStudentLab : Form
    {
        public _BetygsättStudentLab()
        {
            InitializeComponent();
        }

        private void studenterBetyglistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void väljKurscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Kurs> kurser = Kurs.PågåendeKurser;
            Kurs selectedKurs = (Kurs)väljKurscomboBox.SelectedItem;

            väljLabbcomboBox.DataSource = selectedKurs.Laborationer;
            väljLabbcomboBox.DisplayMember = "LabNamn";
            väljLabbcomboBox.ValueMember = "LabNamn";





        }

        private void väljStudentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void väljLabbcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laboration selectedLab = (Laboration)väljLabbcomboBox.SelectedItem;

            väljStudentcomboBox.DataSource = selectedLab.ListaAllaDeltagandeStudenter();
            väljStudentcomboBox.DisplayMember = "StudentFullName";
            väljStudentcomboBox.ValueMember = "StudentID";


            studenterBetygdataGridView.DataSource = selectedLab.ListaAllaDeltagandeStudenter();
            //studenterBetygdataGridView.Columns
        }

        private void väljBetygcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void sparaButton_Click(object sender, EventArgs e)
        {
            Kurs selectedKurs = (Kurs)väljKurscomboBox.SelectedItem;


            DateTime Startdatum = selectedKurs.StartDatum;
            DateTime SlutDatum = selectedKurs.SlutDatum;
            string KursID = selectedKurs.KursID;
            string KursNamn = selectedKurs.KursNamn;
            string LärarLagID = selectedKurs.LärarLagID;
            List<Lärare> Lärare = selectedKurs.DeltagandeLärareISpecifikKurs_LärarLag;
            List<Student> Studenter = selectedKurs.DeltagandeStudenterISpecifikKurs;
            List<Laboration> Laborationer = selectedKurs.Laborationer;


            Student valdStudent = (Student)väljStudentcomboBox.SelectedItem;
            string valdStudentBetyg = väljBetygcomboBox.Text;

            foreach (var student in Studenter)
            {
                if (student.StudentID == valdStudent.StudentID)
                {
                    student.Betyg = valdStudentBetyg;
                    break;
                }
            }
            
            







        }

        private void _BetygsättStudentLab_Load(object sender, EventArgs e)
        {
            List<Kurs> kurser = Kurs.PågåendeKurser;

            väljKurscomboBox.DataSource = kurser;
            väljKurscomboBox.DisplayMember = "KursNamn";
            väljKurscomboBox.ValueMember = "KursID";



        }

        private void klarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
