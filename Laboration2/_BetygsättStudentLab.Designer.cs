namespace Laboration2
{
    partial class _BetygsättStudentLab
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
            this.väljKurscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.väljStudentcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.väljLabbcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.väljBetygcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sparaButton = new System.Windows.Forms.Button();
            this.studenterBetygdataGridView = new System.Windows.Forms.DataGridView();
            this.klarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studenterBetygdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // väljKurscomboBox
            // 
            this.väljKurscomboBox.FormattingEnabled = true;
            this.väljKurscomboBox.Location = new System.Drawing.Point(107, 20);
            this.väljKurscomboBox.Name = "väljKurscomboBox";
            this.väljKurscomboBox.Size = new System.Drawing.Size(150, 21);
            this.väljKurscomboBox.TabIndex = 0;
            this.väljKurscomboBox.SelectedIndexChanged += new System.EventHandler(this.väljKurscomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj kurs:";
            // 
            // väljStudentcomboBox
            // 
            this.väljStudentcomboBox.FormattingEnabled = true;
            this.väljStudentcomboBox.Location = new System.Drawing.Point(107, 74);
            this.väljStudentcomboBox.Name = "väljStudentcomboBox";
            this.väljStudentcomboBox.Size = new System.Drawing.Size(150, 21);
            this.väljStudentcomboBox.TabIndex = 2;
            this.väljStudentcomboBox.SelectedIndexChanged += new System.EventHandler(this.väljStudentcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Välj Student:";
            // 
            // väljLabbcomboBox
            // 
            this.väljLabbcomboBox.FormattingEnabled = true;
            this.väljLabbcomboBox.Location = new System.Drawing.Point(107, 47);
            this.väljLabbcomboBox.Name = "väljLabbcomboBox";
            this.väljLabbcomboBox.Size = new System.Drawing.Size(150, 21);
            this.väljLabbcomboBox.TabIndex = 4;
            this.väljLabbcomboBox.SelectedIndexChanged += new System.EventHandler(this.väljLabbcomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Välj Labbuppg.:";
            // 
            // väljBetygcomboBox
            // 
            this.väljBetygcomboBox.FormattingEnabled = true;
            this.väljBetygcomboBox.Items.AddRange(new object[] {
            "U",
            "G",
            "VG"});
            this.väljBetygcomboBox.Location = new System.Drawing.Point(107, 100);
            this.väljBetygcomboBox.Name = "väljBetygcomboBox";
            this.väljBetygcomboBox.Size = new System.Drawing.Size(121, 21);
            this.väljBetygcomboBox.TabIndex = 6;
            this.väljBetygcomboBox.SelectedIndexChanged += new System.EventHandler(this.väljBetygcomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Välj Betyg";
            // 
            // sparaButton
            // 
            this.sparaButton.Location = new System.Drawing.Point(455, 468);
            this.sparaButton.Name = "sparaButton";
            this.sparaButton.Size = new System.Drawing.Size(75, 23);
            this.sparaButton.TabIndex = 9;
            this.sparaButton.Text = "Spara";
            this.sparaButton.UseVisualStyleBackColor = true;
            this.sparaButton.Click += new System.EventHandler(this.sparaButton_Click);
            // 
            // studenterBetygdataGridView
            // 
            this.studenterBetygdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studenterBetygdataGridView.Location = new System.Drawing.Point(17, 141);
            this.studenterBetygdataGridView.Name = "studenterBetygdataGridView";
            this.studenterBetygdataGridView.Size = new System.Drawing.Size(948, 299);
            this.studenterBetygdataGridView.TabIndex = 10;
            // 
            // klarButton
            // 
            this.klarButton.Location = new System.Drawing.Point(861, 468);
            this.klarButton.Name = "klarButton";
            this.klarButton.Size = new System.Drawing.Size(75, 23);
            this.klarButton.TabIndex = 11;
            this.klarButton.Text = "Klar";
            this.klarButton.UseVisualStyleBackColor = true;
            this.klarButton.Click += new System.EventHandler(this.klarButton_Click);
            // 
            // _BetygsättStudentLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 503);
            this.Controls.Add(this.klarButton);
            this.Controls.Add(this.studenterBetygdataGridView);
            this.Controls.Add(this.sparaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.väljBetygcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.väljLabbcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.väljStudentcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.väljKurscomboBox);
            this.Name = "_BetygsättStudentLab";
            this.Text = "_BetygsättStudentLab";
            this.Load += new System.EventHandler(this._BetygsättStudentLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studenterBetygdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox väljKurscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox väljStudentcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox väljLabbcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox väljBetygcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sparaButton;
        private System.Windows.Forms.DataGridView studenterBetygdataGridView;
        private System.Windows.Forms.Button klarButton;
    }
}