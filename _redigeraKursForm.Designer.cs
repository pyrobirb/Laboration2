namespace Laboration2
{
    partial class _redigeraKursForm
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
            this.kursIDlabel = new System.Windows.Forms.Label();
            this.kursIDtextBoxReadOnly = new System.Windows.Forms.TextBox();
            this.kursNamnLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kursNamnTextBox = new System.Windows.Forms.TextBox();
            this.startDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slutDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatumLabel = new System.Windows.Forms.Label();
            this.slutDatumLabel = new System.Windows.Forms.Label();
            this.DeltagandeStudenterlistbox = new System.Windows.Forms.ListBox();
            this.DeltagandeLärarelistbox = new System.Windows.Forms.ListBox();
            this.deltagandeStudenterlabel = new System.Windows.Forms.Label();
            this.deltagandeLärarelabel = new System.Windows.Forms.Label();
            this.möjligabetyglabel = new System.Windows.Forms.Label();
            this.möjligaBetygTextbox = new System.Windows.Forms.TextBox();
            this.väljaKursAttRedigera = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kursIDlabel
            // 
            this.kursIDlabel.AutoSize = true;
            this.kursIDlabel.Location = new System.Drawing.Point(38, 146);
            this.kursIDlabel.Name = "kursIDlabel";
            this.kursIDlabel.Size = new System.Drawing.Size(41, 13);
            this.kursIDlabel.TabIndex = 0;
            this.kursIDlabel.Text = "kursID:";
            // 
            // kursIDtextBoxReadOnly
            // 
            this.kursIDtextBoxReadOnly.Location = new System.Drawing.Point(90, 143);
            this.kursIDtextBoxReadOnly.Name = "kursIDtextBoxReadOnly";
            this.kursIDtextBoxReadOnly.ReadOnly = true;
            this.kursIDtextBoxReadOnly.Size = new System.Drawing.Size(72, 20);
            this.kursIDtextBoxReadOnly.TabIndex = 1;
            // 
            // kursNamnLabel
            // 
            this.kursNamnLabel.AutoSize = true;
            this.kursNamnLabel.Location = new System.Drawing.Point(22, 178);
            this.kursNamnLabel.Name = "kursNamnLabel";
            this.kursNamnLabel.Size = new System.Drawing.Size(57, 13);
            this.kursNamnLabel.TabIndex = 2;
            this.kursNamnLabel.Text = "Kursnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // kursNamnTextBox
            // 
            this.kursNamnTextBox.Location = new System.Drawing.Point(93, 171);
            this.kursNamnTextBox.Name = "kursNamnTextBox";
            this.kursNamnTextBox.Size = new System.Drawing.Size(100, 20);
            this.kursNamnTextBox.TabIndex = 4;
            this.kursNamnTextBox.TextChanged += new System.EventHandler(this.kursNamnTextBox_TextChanged);
            // 
            // startDatumDateTimePicker
            // 
            this.startDatumDateTimePicker.Location = new System.Drawing.Point(334, 80);
            this.startDatumDateTimePicker.Name = "startDatumDateTimePicker";
            this.startDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatumDateTimePicker.TabIndex = 5;
            // 
            // slutDatumDateTimePicker
            // 
            this.slutDatumDateTimePicker.Location = new System.Drawing.Point(334, 107);
            this.slutDatumDateTimePicker.Name = "slutDatumDateTimePicker";
            this.slutDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.slutDatumDateTimePicker.TabIndex = 6;
            // 
            // startDatumLabel
            // 
            this.startDatumLabel.AutoSize = true;
            this.startDatumLabel.Location = new System.Drawing.Point(268, 86);
            this.startDatumLabel.Name = "startDatumLabel";
            this.startDatumLabel.Size = new System.Drawing.Size(63, 13);
            this.startDatumLabel.TabIndex = 7;
            this.startDatumLabel.Text = "StartDatum:";
            // 
            // slutDatumLabel
            // 
            this.slutDatumLabel.AutoSize = true;
            this.slutDatumLabel.Location = new System.Drawing.Point(271, 113);
            this.slutDatumLabel.Name = "slutDatumLabel";
            this.slutDatumLabel.Size = new System.Drawing.Size(57, 13);
            this.slutDatumLabel.TabIndex = 8;
            this.slutDatumLabel.Text = "Slutdatum:";
            // 
            // DeltagandeStudenterlistbox
            // 
            this.DeltagandeStudenterlistbox.FormattingEnabled = true;
            this.DeltagandeStudenterlistbox.Location = new System.Drawing.Point(93, 272);
            this.DeltagandeStudenterlistbox.Name = "DeltagandeStudenterlistbox";
            this.DeltagandeStudenterlistbox.Size = new System.Drawing.Size(151, 95);
            this.DeltagandeStudenterlistbox.TabIndex = 9;
            this.DeltagandeStudenterlistbox.SelectedIndexChanged += new System.EventHandler(this.DeltagandeStudenterlistbox_SelectedIndexChanged);
            // 
            // DeltagandeLärarelistbox
            // 
            this.DeltagandeLärarelistbox.FormattingEnabled = true;
            this.DeltagandeLärarelistbox.Location = new System.Drawing.Point(325, 272);
            this.DeltagandeLärarelistbox.Name = "DeltagandeLärarelistbox";
            this.DeltagandeLärarelistbox.Size = new System.Drawing.Size(149, 95);
            this.DeltagandeLärarelistbox.TabIndex = 10;
            this.DeltagandeLärarelistbox.SelectedIndexChanged += new System.EventHandler(this.DeltagandeLärarelistbox_SelectedIndexChanged);
            // 
            // deltagandeStudenterlabel
            // 
            this.deltagandeStudenterlabel.AutoSize = true;
            this.deltagandeStudenterlabel.Location = new System.Drawing.Point(93, 239);
            this.deltagandeStudenterlabel.Name = "deltagandeStudenterlabel";
            this.deltagandeStudenterlabel.Size = new System.Drawing.Size(151, 13);
            this.deltagandeStudenterlabel.TabIndex = 11;
            this.deltagandeStudenterlabel.Text = "Deltagande Studenter i kursen";
            // 
            // deltagandeLärarelabel
            // 
            this.deltagandeLärarelabel.AutoSize = true;
            this.deltagandeLärarelabel.Location = new System.Drawing.Point(325, 239);
            this.deltagandeLärarelabel.Name = "deltagandeLärarelabel";
            this.deltagandeLärarelabel.Size = new System.Drawing.Size(135, 13);
            this.deltagandeLärarelabel.TabIndex = 12;
            this.deltagandeLärarelabel.Text = "Deltagande Lärare i kursen";
            // 
            // möjligabetyglabel
            // 
            this.möjligabetyglabel.AutoSize = true;
            this.möjligabetyglabel.Location = new System.Drawing.Point(258, 40);
            this.möjligabetyglabel.Name = "möjligabetyglabel";
            this.möjligabetyglabel.Size = new System.Drawing.Size(73, 13);
            this.möjligabetyglabel.TabIndex = 13;
            this.möjligabetyglabel.Text = "Möjliga Betyg:";
            // 
            // möjligaBetygTextbox
            // 
            this.möjligaBetygTextbox.Location = new System.Drawing.Point(334, 37);
            this.möjligaBetygTextbox.Name = "möjligaBetygTextbox";
            this.möjligaBetygTextbox.Size = new System.Drawing.Size(100, 20);
            this.möjligaBetygTextbox.TabIndex = 14;
            // 
            // väljaKursAttRedigera
            // 
            this.väljaKursAttRedigera.FormattingEnabled = true;
            this.väljaKursAttRedigera.Location = new System.Drawing.Point(41, 40);
            this.väljaKursAttRedigera.Name = "väljaKursAttRedigera";
            this.väljaKursAttRedigera.Size = new System.Drawing.Size(120, 95);
            this.väljaKursAttRedigera.TabIndex = 18;
            this.väljaKursAttRedigera.SelectedIndexChanged += new System.EventHandler(this.väljaKursAttRedigera_SelectedIndexChanged);
            // 
            // _redigeraKursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.väljaKursAttRedigera);
            this.Controls.Add(this.möjligaBetygTextbox);
            this.Controls.Add(this.möjligabetyglabel);
            this.Controls.Add(this.deltagandeLärarelabel);
            this.Controls.Add(this.deltagandeStudenterlabel);
            this.Controls.Add(this.DeltagandeLärarelistbox);
            this.Controls.Add(this.DeltagandeStudenterlistbox);
            this.Controls.Add(this.slutDatumLabel);
            this.Controls.Add(this.startDatumLabel);
            this.Controls.Add(this.slutDatumDateTimePicker);
            this.Controls.Add(this.startDatumDateTimePicker);
            this.Controls.Add(this.kursNamnTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kursNamnLabel);
            this.Controls.Add(this.kursIDtextBoxReadOnly);
            this.Controls.Add(this.kursIDlabel);
            this.Name = "_redigeraKursForm";
            this.Text = "Redigera Kurs";
            this.Load += new System.EventHandler(this._redigeraKursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kursIDlabel;
        private System.Windows.Forms.TextBox kursIDtextBoxReadOnly;
        private System.Windows.Forms.Label kursNamnLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kursNamnTextBox;
        private System.Windows.Forms.DateTimePicker startDatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker slutDatumDateTimePicker;
        private System.Windows.Forms.Label startDatumLabel;
        private System.Windows.Forms.Label slutDatumLabel;
        private System.Windows.Forms.ListBox DeltagandeStudenterlistbox;
        private System.Windows.Forms.ListBox DeltagandeLärarelistbox;
        private System.Windows.Forms.Label deltagandeStudenterlabel;
        private System.Windows.Forms.Label deltagandeLärarelabel;
        private System.Windows.Forms.Label möjligabetyglabel;
        private System.Windows.Forms.TextBox möjligaBetygTextbox;
        private System.Windows.Forms.ListBox väljaKursAttRedigera;
    }
}