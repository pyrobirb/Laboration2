namespace Laboration2
{
    partial class _SkapaKursForm
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
            this.components = new System.ComponentModel.Container();
            this.VisaStudenterlistBox = new System.Windows.Forms.ListBox();
            this.VisaLärarelistBox = new System.Windows.Forms.ListBox();
            this.kursNamnInputTextBox = new System.Windows.Forms.TextBox();
            this.kursNamn = new System.Windows.Forms.Label();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SlutdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatumtext = new System.Windows.Forms.Label();
            this.slutDatumtext = new System.Windows.Forms.Label();
            this.FinishedButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VisaStudenterlistBox
            // 
            this.VisaStudenterlistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "studentID", true));
            this.VisaStudenterlistBox.FormattingEnabled = true;
            this.VisaStudenterlistBox.Location = new System.Drawing.Point(68, 262);
            this.VisaStudenterlistBox.Name = "VisaStudenterlistBox";
            this.VisaStudenterlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.VisaStudenterlistBox.Size = new System.Drawing.Size(207, 95);
            this.VisaStudenterlistBox.TabIndex = 0;
            this.VisaStudenterlistBox.SelectedIndexChanged += new System.EventHandler(this.VisaStudenterlistBox_SelectedIndexChanged);
            // 
            // VisaLärarelistBox
            // 
            this.VisaLärarelistBox.FormattingEnabled = true;
            this.VisaLärarelistBox.Location = new System.Drawing.Point(466, 262);
            this.VisaLärarelistBox.Name = "VisaLärarelistBox";
            this.VisaLärarelistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.VisaLärarelistBox.Size = new System.Drawing.Size(269, 82);
            this.VisaLärarelistBox.TabIndex = 1;
            this.VisaLärarelistBox.SelectedIndexChanged += new System.EventHandler(this.VisaLärarelistBox_SelectedIndexChanged);
            // 
            // kursNamnInputTextBox
            // 
            this.kursNamnInputTextBox.Location = new System.Drawing.Point(151, 49);
            this.kursNamnInputTextBox.Name = "kursNamnInputTextBox";
            this.kursNamnInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.kursNamnInputTextBox.TabIndex = 2;
            this.kursNamnInputTextBox.TextChanged += new System.EventHandler(this.KursNamnInputTextBox_TextChanged);
            // 
            // kursNamn
            // 
            this.kursNamn.AutoSize = true;
            this.kursNamn.Location = new System.Drawing.Point(91, 52);
            this.kursNamn.Name = "kursNamn";
            this.kursNamn.Size = new System.Drawing.Size(54, 13);
            this.kursNamn.TabIndex = 3;
            this.kursNamn.Text = "Kursnamn";
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(151, 118);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartdateTimePicker.TabIndex = 4;
            this.StartdateTimePicker.ValueChanged += new System.EventHandler(this.StartdateTimePicker_ValueChanged);
            // 
            // SlutdateTimePicker
            // 
            this.SlutdateTimePicker.Location = new System.Drawing.Point(151, 144);
            this.SlutdateTimePicker.Name = "SlutdateTimePicker";
            this.SlutdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.SlutdateTimePicker.TabIndex = 5;
            this.SlutdateTimePicker.ValueChanged += new System.EventHandler(this.SlutdateTimePicker_ValueChanged);
            // 
            // startdatumtext
            // 
            this.startdatumtext.AutoSize = true;
            this.startdatumtext.Location = new System.Drawing.Point(91, 124);
            this.startdatumtext.Name = "startdatumtext";
            this.startdatumtext.Size = new System.Drawing.Size(58, 13);
            this.startdatumtext.TabIndex = 6;
            this.startdatumtext.Text = "Startdatum";
            // 
            // slutDatumtext
            // 
            this.slutDatumtext.AutoSize = true;
            this.slutDatumtext.Location = new System.Drawing.Point(91, 150);
            this.slutDatumtext.Name = "slutDatumtext";
            this.slutDatumtext.Size = new System.Drawing.Size(54, 13);
            this.slutDatumtext.TabIndex = 7;
            this.slutDatumtext.Text = "Slutdatum";
            // 
            // FinishedButton
            // 
            this.FinishedButton.Location = new System.Drawing.Point(700, 403);
            this.FinishedButton.Name = "FinishedButton";
            this.FinishedButton.Size = new System.Drawing.Size(75, 23);
            this.FinishedButton.TabIndex = 8;
            this.FinishedButton.Text = "Skapa Kurs";
            this.FinishedButton.UseVisualStyleBackColor = true;
            this.FinishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.betygtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Möjliga betyg";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Laboration2.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FinishedButton);
            this.Controls.Add(this.slutDatumtext);
            this.Controls.Add(this.startdatumtext);
            this.Controls.Add(this.SlutdateTimePicker);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.kursNamn);
            this.Controls.Add(this.kursNamnInputTextBox);
            this.Controls.Add(this.VisaLärarelistBox);
            this.Controls.Add(this.VisaStudenterlistBox);
            this.Name = "Form1";
            this.Text = "Ç";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VisaStudenterlistBox;
        private System.Windows.Forms.ListBox VisaLärarelistBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox kursNamnInputTextBox;
        private System.Windows.Forms.Label kursNamn;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.DateTimePicker SlutdateTimePicker;
        private System.Windows.Forms.Label startdatumtext;
        private System.Windows.Forms.Label slutDatumtext;
        private System.Windows.Forms.Button FinishedButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

