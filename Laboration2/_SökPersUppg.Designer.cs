namespace Laboration2
{
    partial class _SökPersUppg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentUppgifterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lärareUppgifterlabel = new System.Windows.Forms.Label();
            this.allaStudentercomboBox = new System.Windows.Forms.ComboBox();
            this.allaLärarecomboBox = new System.Windows.Forms.ComboBox();
            this.valdStudentKurscomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valdLärareKurscomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Välj namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uppgifter för den valda Studenten:";
            // 
            // studentUppgifterLabel
            // 
            this.studentUppgifterLabel.AutoSize = true;
            this.studentUppgifterLabel.Location = new System.Drawing.Point(189, 110);
            this.studentUppgifterLabel.Name = "studentUppgifterLabel";
            this.studentUppgifterLabel.Size = new System.Drawing.Size(10, 13);
            this.studentUppgifterLabel.TabIndex = 4;
            this.studentUppgifterLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lärare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Välj namn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Uppgifter för den valda Läraren: ";
            // 
            // lärareUppgifterlabel
            // 
            this.lärareUppgifterlabel.AutoSize = true;
            this.lärareUppgifterlabel.Location = new System.Drawing.Point(184, 231);
            this.lärareUppgifterlabel.Name = "lärareUppgifterlabel";
            this.lärareUppgifterlabel.Size = new System.Drawing.Size(10, 13);
            this.lärareUppgifterlabel.TabIndex = 9;
            this.lärareUppgifterlabel.Text = "-";
            // 
            // allaStudentercomboBox
            // 
            this.allaStudentercomboBox.FormattingEnabled = true;
            this.allaStudentercomboBox.Location = new System.Drawing.Point(73, 72);
            this.allaStudentercomboBox.Name = "allaStudentercomboBox";
            this.allaStudentercomboBox.Size = new System.Drawing.Size(121, 21);
            this.allaStudentercomboBox.TabIndex = 10;
            this.allaStudentercomboBox.SelectedIndexChanged += new System.EventHandler(this.allaStudentercomboBox_SelectedIndexChanged);
            // 
            // allaLärarecomboBox
            // 
            this.allaLärarecomboBox.FormattingEnabled = true;
            this.allaLärarecomboBox.Location = new System.Drawing.Point(73, 202);
            this.allaLärarecomboBox.Name = "allaLärarecomboBox";
            this.allaLärarecomboBox.Size = new System.Drawing.Size(121, 21);
            this.allaLärarecomboBox.TabIndex = 11;
            this.allaLärarecomboBox.SelectedIndexChanged += new System.EventHandler(this.allaLärarecomboBox_SelectedIndexChanged);
            // 
            // VäljStudentKurscomboBox
            // 
            this.valdStudentKurscomboBox.FormattingEnabled = true;
            this.valdStudentKurscomboBox.Location = new System.Drawing.Point(73, 45);
            this.valdStudentKurscomboBox.Name = "VäljStudentKurscomboBox";
            this.valdStudentKurscomboBox.Size = new System.Drawing.Size(121, 21);
            this.valdStudentKurscomboBox.TabIndex = 12;
            this.valdStudentKurscomboBox.SelectedIndexChanged += new System.EventHandler(this.valdStudentKurscomboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Välj kurs";
            // 
            // valdLärareKurscomboBox
            // 
            this.valdLärareKurscomboBox.FormattingEnabled = true;
            this.valdLärareKurscomboBox.Location = new System.Drawing.Point(73, 180);
            this.valdLärareKurscomboBox.Name = "valdLärareKurscomboBox";
            this.valdLärareKurscomboBox.Size = new System.Drawing.Size(121, 21);
            this.valdLärareKurscomboBox.TabIndex = 14;
            this.valdLärareKurscomboBox.SelectedIndexChanged += new System.EventHandler(this.valdLärareKurscomboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Välj kurs";
            // 
            // _SökPersUppg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valdLärareKurscomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valdStudentKurscomboBox);
            this.Controls.Add(this.allaLärarecomboBox);
            this.Controls.Add(this.allaStudentercomboBox);
            this.Controls.Add(this.lärareUppgifterlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentUppgifterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_SökPersUppg";
            this.Text = "_SökPersUppg";
            this.Load += new System.EventHandler(this._SökPersUppg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentUppgifterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lärareUppgifterlabel;
        private System.Windows.Forms.ComboBox allaStudentercomboBox;
        private System.Windows.Forms.ComboBox allaLärarecomboBox;
        private System.Windows.Forms.ComboBox valdStudentKurscomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox valdLärareKurscomboBox;
        private System.Windows.Forms.Label label8;
    }
}