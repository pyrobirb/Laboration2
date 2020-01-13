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
    public partial class _redigeraKursForm : Form
    {
        public _redigeraKursForm()
        {
            InitializeComponent();


            ListBox väljaKursAttRedigera = new ListBox();
            väljaKursAttRedigera.Items.Clear();

            väljaKursAttRedigera.DisplayMember = "kursnamn";
            väljaKursAttRedigera.ValueMember = "kursID";


        }

        private void DeltagandeStudenterlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentLista = Student.HämtaStudentLista();

            foreach (var item in studentLista)
            {
                DeltagandeLärarelistbox.Items.Add(String.Format("{0} {1} {2}", item.studentID.ToUpper(), item.förnamn, item.efternamn));

            }

            DeltagandeLärarelistbox.Sorted = true;
            DeltagandeLärarelistbox.TopIndex = 0;


        }

        private void DeltagandeLärarelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kursNamnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void _redigeraKursForm_Load(object sender, EventArgs e)
        {
            //Väljakurs att redigera index
            var kursLista = Kurs.HämtaPågåendeKurser();

            foreach (var item in kursLista)
            {
                väljaKursAttRedigera.Items.Add(String.Format("{0} {1}", item.kursID.ToUpper(), item.kursNamn));

            }

            väljaKursAttRedigera.Sorted = true;
        }

        private void väljaKursAttRedigera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
