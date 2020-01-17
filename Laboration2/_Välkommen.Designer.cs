namespace Laboration2
{
    partial class _Välkommen
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
            this.SkapaKurs = new System.Windows.Forms.Button();
            this.VälkommenKnapp = new System.Windows.Forms.Label();
            this.RedigeraKurs = new System.Windows.Forms.Button();
            this.TilldelaLab = new System.Windows.Forms.Button();
            this.BetygsättLab = new System.Windows.Forms.Button();
            this.Avsluta = new System.Windows.Forms.Button();
            this.sökPersUppgbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkapaKurs
            // 
            this.SkapaKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SkapaKurs.Location = new System.Drawing.Point(19, 116);
            this.SkapaKurs.Name = "SkapaKurs";
            this.SkapaKurs.Size = new System.Drawing.Size(152, 78);
            this.SkapaKurs.TabIndex = 0;
            this.SkapaKurs.Text = "Skapa kurs";
            this.SkapaKurs.UseVisualStyleBackColor = false;
            this.SkapaKurs.Click += new System.EventHandler(this.SkapaKurs_Click);
            // 
            // VälkommenKnapp
            // 
            this.VälkommenKnapp.AutoSize = true;
            this.VälkommenKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VälkommenKnapp.Location = new System.Drawing.Point(12, 26);
            this.VälkommenKnapp.Name = "VälkommenKnapp";
            this.VälkommenKnapp.Size = new System.Drawing.Size(326, 74);
            this.VälkommenKnapp.TabIndex = 1;
            this.VälkommenKnapp.Text = "Välkommen admin! \r\nVad vill du göra idag?";
            this.VälkommenKnapp.Click += new System.EventHandler(this.VälkommenKnapp_Click);
            // 
            // RedigeraKurs
            // 
            this.RedigeraKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RedigeraKurs.Location = new System.Drawing.Point(177, 116);
            this.RedigeraKurs.Name = "RedigeraKurs";
            this.RedigeraKurs.Size = new System.Drawing.Size(156, 78);
            this.RedigeraKurs.TabIndex = 2;
            this.RedigeraKurs.Text = "Redigera kurs";
            this.RedigeraKurs.UseVisualStyleBackColor = false;
            this.RedigeraKurs.Click += new System.EventHandler(this.RedigeraKurs_Click);
            // 
            // TilldelaLab
            // 
            this.TilldelaLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TilldelaLab.Location = new System.Drawing.Point(19, 200);
            this.TilldelaLab.Name = "TilldelaLab";
            this.TilldelaLab.Size = new System.Drawing.Size(152, 78);
            this.TilldelaLab.TabIndex = 3;
            this.TilldelaLab.Text = "Tilldela Labbuppgift till kurs";
            this.TilldelaLab.UseVisualStyleBackColor = false;
            this.TilldelaLab.Click += new System.EventHandler(this.TilldelaLab_Click);
            // 
            // BetygsättLab
            // 
            this.BetygsättLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BetygsättLab.Location = new System.Drawing.Point(177, 200);
            this.BetygsättLab.Name = "BetygsättLab";
            this.BetygsättLab.Size = new System.Drawing.Size(161, 78);
            this.BetygsättLab.TabIndex = 4;
            this.BetygsättLab.Text = "Betygsätt student i Labuppgift";
            this.BetygsättLab.UseVisualStyleBackColor = false;
            this.BetygsättLab.Click += new System.EventHandler(this.BetygsättLab_Click);
            // 
            // Avsluta
            // 
            this.Avsluta.BackColor = System.Drawing.Color.Silver;
            this.Avsluta.Location = new System.Drawing.Point(177, 304);
            this.Avsluta.Name = "Avsluta";
            this.Avsluta.Size = new System.Drawing.Size(156, 31);
            this.Avsluta.TabIndex = 6;
            this.Avsluta.Text = "Avsluta";
            this.Avsluta.UseVisualStyleBackColor = false;
            this.Avsluta.Click += new System.EventHandler(this.Avsluta_Click);
            // 
            // sökPersUppgbutton
            // 
            this.sökPersUppgbutton.Location = new System.Drawing.Point(19, 304);
            this.sökPersUppgbutton.Name = "sökPersUppgbutton";
            this.sökPersUppgbutton.Size = new System.Drawing.Size(152, 31);
            this.sökPersUppgbutton.TabIndex = 7;
            this.sökPersUppgbutton.Text = "Sök personuppgifter";
            this.sökPersUppgbutton.UseVisualStyleBackColor = true;
            this.sökPersUppgbutton.Click += new System.EventHandler(this.sökPersUppgbutton_Click);
            // 
            // _Välkommen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 352);
            this.Controls.Add(this.sökPersUppgbutton);
            this.Controls.Add(this.Avsluta);
            this.Controls.Add(this.BetygsättLab);
            this.Controls.Add(this.TilldelaLab);
            this.Controls.Add(this.RedigeraKurs);
            this.Controls.Add(this.VälkommenKnapp);
            this.Controls.Add(this.SkapaKurs);
            this.Name = "_Välkommen";
            this.Text = "Välkommen";
            this.Load += new System.EventHandler(this._Välkommen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SkapaKurs;
        private System.Windows.Forms.Label VälkommenKnapp;
        private System.Windows.Forms.Button RedigeraKurs;
        private System.Windows.Forms.Button TilldelaLab;
        private System.Windows.Forms.Button BetygsättLab;
        private System.Windows.Forms.Button Avsluta;
        private System.Windows.Forms.Button sökPersUppgbutton;
    }
}

