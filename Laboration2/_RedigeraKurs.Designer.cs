namespace Laboration2
{
    partial class _RedigeraKurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VisaAllaKurserListBox = new System.Windows.Forms.ListBox();
            this.RedigeraKursText = new System.Windows.Forms.Label();
            this.RedigeraKursKnapp = new System.Windows.Forms.Button();
            this.TaBortKursKnapp = new System.Windows.Forms.Button();
            this.kursNamnTextBox = new System.Windows.Forms.TextBox();
            this.KursnamnText = new System.Windows.Forms.Label();
            this.StartdatumText = new System.Windows.Forms.Label();
            this.Slutdatum = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kursIDlabel = new System.Windows.Forms.Label();
            this.kursIDtextBox = new System.Windows.Forms.TextBox();
            this.studenterPåKurslistBox = new System.Windows.Forms.ListBox();
            this.lärarePåKurslistBox = new System.Windows.Forms.ListBox();
            this.studenterPåKurslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lärarLagIDlabel = new System.Windows.Forms.Label();
            this.lärarLagIDtextBox = new System.Windows.Forms.TextBox();
            this.allaStudenterlistBox = new System.Windows.Forms.ListBox();
            this.allaLärarelistBox = new System.Windows.Forms.ListBox();
            this.taBortStudentbutton = new System.Windows.Forms.Button();
            this.LäggTillLärarebutton = new System.Windows.Forms.Button();
            this.taBortLärarebutton = new System.Windows.Forms.Button();
            this.LäggTillStudentbutton = new System.Windows.Forms.Button();
            this.allaStudenterlabel = new System.Windows.Forms.Label();
            this.allaLärarelabel = new System.Windows.Forms.Label();
            this.allaLärarelabel2 = new System.Windows.Forms.Label();
            this.Klarbutton = new System.Windows.Forms.Button();
            this.Laborationlabel = new System.Windows.Forms.Label();
            this.labNamntextBox = new System.Windows.Forms.TextBox();
            this.Labinfolabel = new System.Windows.Forms.Label();
            this.labInfotextBox = new System.Windows.Forms.TextBox();
            this.tilldelaLablabel = new System.Windows.Forms.Label();
            this.labbLabel = new System.Windows.Forms.Label();
            this.allaLaborationerlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VisaAllaKurserListBox
            // 
            this.VisaAllaKurserListBox.FormattingEnabled = true;
            this.VisaAllaKurserListBox.Location = new System.Drawing.Point(54, 72);
            this.VisaAllaKurserListBox.Name = "VisaAllaKurserListBox";
            this.VisaAllaKurserListBox.Size = new System.Drawing.Size(284, 95);
            this.VisaAllaKurserListBox.TabIndex = 0;
            this.VisaAllaKurserListBox.SelectedIndexChanged += new System.EventHandler(this.VisaAllaKurserListBox_SelectedIndexChanged);
            // 
            // RedigeraKursText
            // 
            this.RedigeraKursText.AutoSize = true;
            this.RedigeraKursText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigeraKursText.Location = new System.Drawing.Point(51, 35);
            this.RedigeraKursText.Name = "RedigeraKursText";
            this.RedigeraKursText.Size = new System.Drawing.Size(212, 20);
            this.RedigeraKursText.TabIndex = 1;
            this.RedigeraKursText.Text = "Välj kurs som skall redigeras:";
            // 
            // RedigeraKursKnapp
            // 
            this.RedigeraKursKnapp.Location = new System.Drawing.Point(263, 173);
            this.RedigeraKursKnapp.Name = "RedigeraKursKnapp";
            this.RedigeraKursKnapp.Size = new System.Drawing.Size(75, 23);
            this.RedigeraKursKnapp.TabIndex = 2;
            this.RedigeraKursKnapp.Text = "Redigera";
            this.RedigeraKursKnapp.UseVisualStyleBackColor = true;
            this.RedigeraKursKnapp.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaBortKursKnapp
            // 
            this.TaBortKursKnapp.Location = new System.Drawing.Point(172, 173);
            this.TaBortKursKnapp.Name = "TaBortKursKnapp";
            this.TaBortKursKnapp.Size = new System.Drawing.Size(75, 23);
            this.TaBortKursKnapp.TabIndex = 3;
            this.TaBortKursKnapp.Text = "Ta bort";
            this.TaBortKursKnapp.UseVisualStyleBackColor = true;
            this.TaBortKursKnapp.Click += new System.EventHandler(this.TaBortKnapp);
            // 
            // kursNamnTextBox
            // 
            this.kursNamnTextBox.Location = new System.Drawing.Point(172, 253);
            this.kursNamnTextBox.Name = "kursNamnTextBox";
            this.kursNamnTextBox.Size = new System.Drawing.Size(166, 20);
            this.kursNamnTextBox.TabIndex = 4;
            // 
            // KursnamnText
            // 
            this.KursnamnText.AutoSize = true;
            this.KursnamnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KursnamnText.Location = new System.Drawing.Point(51, 253);
            this.KursnamnText.Name = "KursnamnText";
            this.KursnamnText.Size = new System.Drawing.Size(70, 16);
            this.KursnamnText.TabIndex = 5;
            this.KursnamnText.Text = "Kursnamn:";
            // 
            // StartdatumText
            // 
            this.StartdatumText.AutoSize = true;
            this.StartdatumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartdatumText.Location = new System.Drawing.Point(51, 307);
            this.StartdatumText.Name = "StartdatumText";
            this.StartdatumText.Size = new System.Drawing.Size(75, 16);
            this.StartdatumText.TabIndex = 6;
            this.StartdatumText.Text = "Startdatum:";
            // 
            // Slutdatum
            // 
            this.Slutdatum.AutoSize = true;
            this.Slutdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slutdatum.Location = new System.Drawing.Point(51, 362);
            this.Slutdatum.Name = "Slutdatum";
            this.Slutdatum.Size = new System.Drawing.Size(70, 16);
            this.Slutdatum.TabIndex = 7;
            this.Slutdatum.Text = "Slutdatum:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(138, 307);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // slutDateTimePicker
            // 
            this.slutDateTimePicker.Location = new System.Drawing.Point(138, 362);
            this.slutDateTimePicker.Name = "slutDateTimePicker";
            this.slutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.slutDateTimePicker.TabIndex = 9;
            // 
            // kursIDlabel
            // 
            this.kursIDlabel.AutoSize = true;
            this.kursIDlabel.Location = new System.Drawing.Point(52, 216);
            this.kursIDlabel.Name = "kursIDlabel";
            this.kursIDlabel.Size = new System.Drawing.Size(42, 13);
            this.kursIDlabel.TabIndex = 10;
            this.kursIDlabel.Text = "KursID:";
            // 
            // kursIDtextBox
            // 
            this.kursIDtextBox.Location = new System.Drawing.Point(172, 213);
            this.kursIDtextBox.Name = "kursIDtextBox";
            this.kursIDtextBox.ReadOnly = true;
            this.kursIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.kursIDtextBox.TabIndex = 11;
            // 
            // studenterPåKurslistBox
            // 
            this.studenterPåKurslistBox.FormattingEnabled = true;
            this.studenterPåKurslistBox.Location = new System.Drawing.Point(612, 72);
            this.studenterPåKurslistBox.Name = "studenterPåKurslistBox";
            this.studenterPåKurslistBox.Size = new System.Drawing.Size(164, 95);
            this.studenterPåKurslistBox.TabIndex = 12;
            this.studenterPåKurslistBox.SelectedIndexChanged += new System.EventHandler(this.StudenterPåKurslistbox_SelectedIndexChanged);
            // 
            // lärarePåKurslistBox
            // 
            this.lärarePåKurslistBox.FormattingEnabled = true;
            this.lärarePåKurslistBox.Location = new System.Drawing.Point(612, 283);
            this.lärarePåKurslistBox.Name = "lärarePåKurslistBox";
            this.lärarePåKurslistBox.Size = new System.Drawing.Size(154, 95);
            this.lärarePåKurslistBox.TabIndex = 13;
            this.lärarePåKurslistBox.SelectedIndexChanged += new System.EventHandler(this.LärarePåKurslistbox_SelectedIndexChanged);
            // 
            // studenterPåKurslabel
            // 
            this.studenterPåKurslabel.AutoSize = true;
            this.studenterPåKurslabel.Location = new System.Drawing.Point(609, 38);
            this.studenterPåKurslabel.Name = "studenterPåKurslabel";
            this.studenterPåKurslabel.Size = new System.Drawing.Size(91, 13);
            this.studenterPåKurslabel.TabIndex = 14;
            this.studenterPåKurslabel.Text = "Studenter på kurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // lärarLagIDlabel
            // 
            this.lärarLagIDlabel.AutoSize = true;
            this.lärarLagIDlabel.Location = new System.Drawing.Point(612, 221);
            this.lärarLagIDlabel.Name = "lärarLagIDlabel";
            this.lärarLagIDlabel.Size = new System.Drawing.Size(60, 13);
            this.lärarLagIDlabel.TabIndex = 20;
            this.lärarLagIDlabel.Text = "LärarLagID";
            // 
            // lärarLagIDtextBox
            // 
            this.lärarLagIDtextBox.Location = new System.Drawing.Point(678, 216);
            this.lärarLagIDtextBox.Name = "lärarLagIDtextBox";
            this.lärarLagIDtextBox.Size = new System.Drawing.Size(90, 20);
            this.lärarLagIDtextBox.TabIndex = 21;
            this.lärarLagIDtextBox.TextChanged += new System.EventHandler(this.lärarLagIDtextBox_TextChanged);
            // 
            // allaStudenterlistBox
            // 
            this.allaStudenterlistBox.FormattingEnabled = true;
            this.allaStudenterlistBox.Location = new System.Drawing.Point(405, 72);
            this.allaStudenterlistBox.Name = "allaStudenterlistBox";
            this.allaStudenterlistBox.Size = new System.Drawing.Size(147, 95);
            this.allaStudenterlistBox.TabIndex = 22;
            this.allaStudenterlistBox.SelectedIndexChanged += new System.EventHandler(this.allaStudenterlistBox_SelectedIndexChanged);
            // 
            // allaLärarelistBox
            // 
            this.allaLärarelistBox.FormattingEnabled = true;
            this.allaLärarelistBox.Location = new System.Drawing.Point(405, 283);
            this.allaLärarelistBox.Name = "allaLärarelistBox";
            this.allaLärarelistBox.Size = new System.Drawing.Size(147, 95);
            this.allaLärarelistBox.TabIndex = 23;
            this.allaLärarelistBox.SelectedIndexChanged += new System.EventHandler(this.allaLärarelistbox_SelectedIndexChanged);
            // 
            // taBortStudentbutton
            // 
            this.taBortStudentbutton.Location = new System.Drawing.Point(612, 173);
            this.taBortStudentbutton.Name = "taBortStudentbutton";
            this.taBortStudentbutton.Size = new System.Drawing.Size(164, 23);
            this.taBortStudentbutton.TabIndex = 25;
            this.taBortStudentbutton.Text = "Ta bort Student";
            this.taBortStudentbutton.UseVisualStyleBackColor = true;
            this.taBortStudentbutton.Click += new System.EventHandler(this.taBortStudentbutton_Click);
            // 
            // LäggTillLärarebutton
            // 
            this.LäggTillLärarebutton.Location = new System.Drawing.Point(405, 384);
            this.LäggTillLärarebutton.Name = "LäggTillLärarebutton";
            this.LäggTillLärarebutton.Size = new System.Drawing.Size(147, 23);
            this.LäggTillLärarebutton.TabIndex = 26;
            this.LäggTillLärarebutton.Text = "Lägg till Lärare ->";
            this.LäggTillLärarebutton.UseVisualStyleBackColor = true;
            this.LäggTillLärarebutton.Click += new System.EventHandler(this.LäggTillLärarebutton_Click);
            // 
            // taBortLärarebutton
            // 
            this.taBortLärarebutton.Location = new System.Drawing.Point(612, 384);
            this.taBortLärarebutton.Name = "taBortLärarebutton";
            this.taBortLärarebutton.Size = new System.Drawing.Size(154, 23);
            this.taBortLärarebutton.TabIndex = 27;
            this.taBortLärarebutton.Text = "Ta bort Lärare";
            this.taBortLärarebutton.UseVisualStyleBackColor = true;
            this.taBortLärarebutton.Click += new System.EventHandler(this.taBortLärarebutton_Click);
            // 
            // LäggTillStudentbutton
            // 
            this.LäggTillStudentbutton.Location = new System.Drawing.Point(405, 173);
            this.LäggTillStudentbutton.Name = "LäggTillStudentbutton";
            this.LäggTillStudentbutton.Size = new System.Drawing.Size(147, 23);
            this.LäggTillStudentbutton.TabIndex = 28;
            this.LäggTillStudentbutton.Text = "Lägg till Student ->";
            this.LäggTillStudentbutton.UseVisualStyleBackColor = true;
            this.LäggTillStudentbutton.Click += new System.EventHandler(this.LäggTillStudentbutton_Click);
            // 
            // allaStudenterlabel
            // 
            this.allaStudenterlabel.AutoSize = true;
            this.allaStudenterlabel.Location = new System.Drawing.Point(405, 38);
            this.allaStudenterlabel.Name = "allaStudenterlabel";
            this.allaStudenterlabel.Size = new System.Drawing.Size(73, 13);
            this.allaStudenterlabel.TabIndex = 29;
            this.allaStudenterlabel.Text = "Alla Studenter";
            // 
            // allaLärarelabel
            // 
            this.allaLärarelabel.AutoSize = true;
            this.allaLärarelabel.Location = new System.Drawing.Point(405, 253);
            this.allaLärarelabel.Name = "allaLärarelabel";
            this.allaLärarelabel.Size = new System.Drawing.Size(53, 13);
            this.allaLärarelabel.TabIndex = 30;
            this.allaLärarelabel.Text = "Alla lärare";
            // 
            // allaLärarelabel2
            // 
            this.allaLärarelabel2.AutoSize = true;
            this.allaLärarelabel2.Location = new System.Drawing.Point(612, 252);
            this.allaLärarelabel2.Name = "allaLärarelabel2";
            this.allaLärarelabel2.Size = new System.Drawing.Size(57, 13);
            this.allaLärarelabel2.TabIndex = 31;
            this.allaLärarelabel2.Text = "Alla Lärare";
            // 
            // Klarbutton
            // 
            this.Klarbutton.Location = new System.Drawing.Point(691, 606);
            this.Klarbutton.Name = "Klarbutton";
            this.Klarbutton.Size = new System.Drawing.Size(75, 23);
            this.Klarbutton.TabIndex = 32;
            this.Klarbutton.Text = "Klar";
            this.Klarbutton.UseVisualStyleBackColor = true;
            this.Klarbutton.Click += new System.EventHandler(this.Klarbutton_Click);
            // 
            // Laborationlabel
            // 
            this.Laborationlabel.AutoSize = true;
            this.Laborationlabel.Location = new System.Drawing.Point(51, 465);
            this.Laborationlabel.Name = "Laborationlabel";
            this.Laborationlabel.Size = new System.Drawing.Size(86, 13);
            this.Laborationlabel.TabIndex = 33;
            this.Laborationlabel.Text = "Laboration namn";
            // 
            // labNamntextBox
            // 
            this.labNamntextBox.Location = new System.Drawing.Point(138, 462);
            this.labNamntextBox.Name = "labNamntextBox";
            this.labNamntextBox.Size = new System.Drawing.Size(100, 20);
            this.labNamntextBox.TabIndex = 34;
            // 
            // Labinfolabel
            // 
            this.Labinfolabel.AutoSize = true;
            this.Labinfolabel.Location = new System.Drawing.Point(51, 498);
            this.Labinfolabel.Name = "Labinfolabel";
            this.Labinfolabel.Size = new System.Drawing.Size(42, 13);
            this.Labinfolabel.TabIndex = 35;
            this.Labinfolabel.Text = "Labinfo";
            // 
            // labInfotextBox
            // 
            this.labInfotextBox.Location = new System.Drawing.Point(95, 498);
            this.labInfotextBox.Multiline = true;
            this.labInfotextBox.Name = "labInfotextBox";
            this.labInfotextBox.Size = new System.Drawing.Size(143, 131);
            this.labInfotextBox.TabIndex = 36;
            this.labInfotextBox.TextChanged += new System.EventHandler(this.labInfotextBox_TextChanged);
            // 
            // tilldelaLablabel
            // 
            this.tilldelaLablabel.AutoSize = true;
            this.tilldelaLablabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilldelaLablabel.Location = new System.Drawing.Point(51, 434);
            this.tilldelaLablabel.Name = "tilldelaLablabel";
            this.tilldelaLablabel.Size = new System.Drawing.Size(142, 20);
            this.tilldelaLablabel.TabIndex = 37;
            this.tilldelaLablabel.Text = "Tilldela Lab till Kurs";
            // 
            // labbLabel
            // 
            this.labbLabel.AutoSize = true;
            this.labbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbLabel.Location = new System.Drawing.Point(282, 465);
            this.labbLabel.Name = "labbLabel";
            this.labbLabel.Size = new System.Drawing.Size(99, 20);
            this.labbLabel.TabIndex = 38;
            this.labbLabel.Text = "Laborationer";
            // 
            // allaLaborationerlistBox
            // 
            this.allaLaborationerlistBox.FormattingEnabled = true;
            this.allaLaborationerlistBox.Location = new System.Drawing.Point(276, 498);
            this.allaLaborationerlistBox.Name = "allaLaborationerlistBox";
            this.allaLaborationerlistBox.Size = new System.Drawing.Size(120, 134);
            this.allaLaborationerlistBox.TabIndex = 39;
            this.allaLaborationerlistBox.SelectedIndexChanged += new System.EventHandler(this.allaLaborationerlistBox_SelectedIndexChanged);
            // 
            // _RedigeraKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 646);
            this.Controls.Add(this.allaLaborationerlistBox);
            this.Controls.Add(this.labbLabel);
            this.Controls.Add(this.tilldelaLablabel);
            this.Controls.Add(this.labInfotextBox);
            this.Controls.Add(this.Labinfolabel);
            this.Controls.Add(this.labNamntextBox);
            this.Controls.Add(this.Laborationlabel);
            this.Controls.Add(this.Klarbutton);
            this.Controls.Add(this.allaLärarelabel2);
            this.Controls.Add(this.allaLärarelabel);
            this.Controls.Add(this.allaStudenterlabel);
            this.Controls.Add(this.LäggTillStudentbutton);
            this.Controls.Add(this.taBortLärarebutton);
            this.Controls.Add(this.LäggTillLärarebutton);
            this.Controls.Add(this.taBortStudentbutton);
            this.Controls.Add(this.allaLärarelistBox);
            this.Controls.Add(this.allaStudenterlistBox);
            this.Controls.Add(this.lärarLagIDtextBox);
            this.Controls.Add(this.lärarLagIDlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studenterPåKurslabel);
            this.Controls.Add(this.lärarePåKurslistBox);
            this.Controls.Add(this.studenterPåKurslistBox);
            this.Controls.Add(this.kursIDtextBox);
            this.Controls.Add(this.kursIDlabel);
            this.Controls.Add(this.slutDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.Slutdatum);
            this.Controls.Add(this.StartdatumText);
            this.Controls.Add(this.KursnamnText);
            this.Controls.Add(this.kursNamnTextBox);
            this.Controls.Add(this.TaBortKursKnapp);
            this.Controls.Add(this.RedigeraKursKnapp);
            this.Controls.Add(this.RedigeraKursText);
            this.Controls.Add(this.VisaAllaKurserListBox);
            this.Name = "_RedigeraKurs";
            this.Text = "RedigeraKurs";
            this.Load += new System.EventHandler(this._RedigeraKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VisaAllaKurserListBox;
        private System.Windows.Forms.Label RedigeraKursText;
        private System.Windows.Forms.Button RedigeraKursKnapp;
        private System.Windows.Forms.Button TaBortKursKnapp;
        private System.Windows.Forms.TextBox kursNamnTextBox;
        private System.Windows.Forms.Label KursnamnText;
        private System.Windows.Forms.Label StartdatumText;
        private System.Windows.Forms.Label Slutdatum;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker slutDateTimePicker;
        private System.Windows.Forms.Label kursIDlabel;
        private System.Windows.Forms.TextBox kursIDtextBox;
        private System.Windows.Forms.ListBox studenterPåKurslistBox;
        private System.Windows.Forms.ListBox lärarePåKurslistBox;
        private System.Windows.Forms.Label studenterPåKurslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lärarLagIDlabel;
        private System.Windows.Forms.TextBox lärarLagIDtextBox;
        private System.Windows.Forms.ListBox allaStudenterlistBox;
        private System.Windows.Forms.ListBox allaLärarelistBox;
        private System.Windows.Forms.Button taBortStudentbutton;
        private System.Windows.Forms.Button LäggTillLärarebutton;
        private System.Windows.Forms.Button taBortLärarebutton;
        private System.Windows.Forms.Button LäggTillStudentbutton;
        private System.Windows.Forms.Label allaStudenterlabel;
        private System.Windows.Forms.Label allaLärarelabel;
        private System.Windows.Forms.Label allaLärarelabel2;
        private System.Windows.Forms.Button Klarbutton;
        private System.Windows.Forms.Label Laborationlabel;
        private System.Windows.Forms.TextBox labNamntextBox;
        private System.Windows.Forms.Label Labinfolabel;
        private System.Windows.Forms.TextBox labInfotextBox;
        private System.Windows.Forms.Label tilldelaLablabel;
        private System.Windows.Forms.Label labbLabel;
        private System.Windows.Forms.ListBox allaLaborationerlistBox;
    }
}