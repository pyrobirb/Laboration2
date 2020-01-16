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
    public partial class _LäggTillNyLab : Form
    {
        public _LäggTillNyLab()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void _LäggTillNyLab_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Kurs.PågåendeKurser;
            comboBox1.DisplayMember = "KursNamn";
            comboBox1.ValueMember = "KursID";

        }

        private void sparaBtn_Click(object sender, EventArgs e)
        {
            Kurs selectedKurs = (Kurs)comboBox1.SelectedItem;

            var StartDatum = selectedKurs.StartDatum;
            var SlutDatum = selectedKurs.SlutDatum;
            var Betyg = selectedKurs.Betyg;
            var KursID = selectedKurs.KursID;
            var KursNamn = selectedKurs.KursNamn;
            var LärarLagID = selectedKurs.LärarLagID;
            var deltagandeLärareISpecifikKurs_LärarLag = selectedKurs.HämtaKursLärare();
            var deltagandeStudenterISpecifikKurs = selectedKurs.HämtaKursStudent();

            var LabNamn = textBox1.Text;
            var LabInfo = textBox2.Text;

            Laboration nyLab = new Laboration(LabNamn, LabInfo, deltagandeStudenterISpecifikKurs);
            List<Laboration> gamlaLabbar_plus_nyaLabbar = new List<Laboration>();
            var gamlaLabbar = selectedKurs.Laborationer;

            gamlaLabbar_plus_nyaLabbar = gamlaLabbar;
            gamlaLabbar_plus_nyaLabbar.Add(nyLab);


            Kurs nyKurs = new Kurs(StartDatum, SlutDatum, Betyg, KursID, KursNamn, LärarLagID, deltagandeLärareISpecifikKurs_LärarLag, deltagandeStudenterISpecifikKurs, gamlaLabbar_plus_nyaLabbar);

            Kurs.LäggTillKurs_SkrivÖverKursMedSammaKursID(nyKurs);


            this.Close();
        }
    }
}
