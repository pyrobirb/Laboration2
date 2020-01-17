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
    public partial class _SökPersUppg : Form
    {
        public _SökPersUppg()
        {
            InitializeComponent();
        }

        private void _SökPersUppg_Load(object sender, EventArgs e)
        {
            List<Kurs> allaKurser = Kurs.PågåendeKurser;

            valdStudentKurscomboBox.DataSource = allaKurser;
            valdStudentKurscomboBox.DisplayMember = "KursNamn";
            valdStudentKurscomboBox.ValueMember = "KursID";


            valdLärareKurscomboBox.DataSource = allaKurser;
            valdLärareKurscomboBox.DisplayMember = "KursNamn";
            valdLärareKurscomboBox.ValueMember = "KursID";

        }

        private void allaStudentercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)allaStudentercomboBox.SelectedItem;

            studentUppgifterLabel.Text = selectedStudent.HämtaPersonuppgifter(selectedStudent.Personnummer);
        }

        private void allaLärarecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lärare selectedLärare = (Lärare)allaLärarecomboBox.SelectedItem;

            lärareUppgifterlabel.Text = selectedLärare.HämtaPersonuppgifter(selectedLärare.Personnummer);
        }

        private void valdStudentKurscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurs selectedStudentKurs = (Kurs)valdStudentKurscomboBox.SelectedItem;

            allaStudentercomboBox.DataSource = selectedStudentKurs.ListaAllaDeltagandeStudenter();
            allaStudentercomboBox.DisplayMember = "StudentFullName";
            allaStudentercomboBox.ValueMember = "StudentID";

            
        }

        private void valdLärareKurscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurs selectedLärareKurs = (Kurs)valdLärareKurscomboBox.SelectedItem;

            allaLärarecomboBox.DataSource = selectedLärareKurs.ListaAllaDeltagandeLärare();
            allaLärarecomboBox.DisplayMember = "LärareFullName";
            allaLärarecomboBox.ValueMember = "LärarID";

        }
    }
}
