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
    public partial class _Välkommen : Form
    {
        public _Välkommen()
        {
            InitializeComponent();
        }

        private void SkapaKurs_Click(object sender, EventArgs e)
        {
            _SkapaKurs Form2 = new _SkapaKurs();
            Form2.Show();
            
        }

        private void SkapaKursPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void VälkommenKnapp_Click(object sender, EventArgs e)
        {

        }


        private void Avsluta_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void _Välkommen_Load(object sender, EventArgs e)
        {

        }

        private void RedigeraKurs_Click(object sender, EventArgs e)
        {
            _RedigeraKurs Form = new _RedigeraKurs();
            Form.Show();
        }

        private void TilldelaLab_Click(object sender, EventArgs e)
        {
            _LäggTillNyLab Form = new _LäggTillNyLab();
            Form.Show();
        }

        private void BetygsättLab_Click(object sender, EventArgs e)
        {
            _BetygsättStudentLab Form = new _BetygsättStudentLab();
            Form.Show();
        }

        private void antalPersonerlabel_Click(object sender, EventArgs e)
        {

        }

        private void sökPersUppgbutton_Click(object sender, EventArgs e)
        {
            _SökPersUppg Form = new _SökPersUppg();
            Form.Show();
        }
    }
}
