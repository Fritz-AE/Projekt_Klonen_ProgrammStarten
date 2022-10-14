
namespace Projekt_Klonen_ProgrammStarten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calc = new System.Windows.Forms.Button();
            this.ProgrammAusführung = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Textausgabe = new System.Windows.Forms.Label();
            this.Texteingabe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(12, 12);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Calc";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // ProgrammAusführung
            // 
            this.ProgrammAusführung.Location = new System.Drawing.Point(93, 12);
            this.ProgrammAusführung.Name = "ProgrammAusführung";
            this.ProgrammAusführung.Size = new System.Drawing.Size(129, 23);
            this.ProgrammAusführung.TabIndex = 1;
            this.ProgrammAusführung.Text = "Copy Prog. Starten";
            this.ProgrammAusführung.UseVisualStyleBackColor = true;
            this.ProgrammAusführung.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© Praktikant 2022 CSD Marcel Fritz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Textausgabe
            // 
            this.Textausgabe.AutoSize = true;
            this.Textausgabe.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textausgabe.Location = new System.Drawing.Point(391, 175);
            this.Textausgabe.Name = "Textausgabe";
            this.Textausgabe.Size = new System.Drawing.Size(222, 28);
            this.Textausgabe.TabIndex = 3;
            this.Textausgabe.Text = "<< Gib einen Text ein!";
            this.Textausgabe.Click += new System.EventHandler(this.label1_Click);
            // 
            // Texteingabe
            // 
            this.Texteingabe.Location = new System.Drawing.Point(153, 175);
            this.Texteingabe.Name = "Texteingabe";
            this.Texteingabe.Size = new System.Drawing.Size(187, 20);
            this.Texteingabe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Texteingabe);
            this.Controls.Add(this.Textausgabe);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ProgrammAusführung);
            this.Controls.Add(this.Calc);
            this.Name = "Form1";
            this.Text = "FreitagsAufgabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button ProgrammAusführung;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Textausgabe;
        private System.Windows.Forms.TextBox Texteingabe;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.Process process1;
    }
}

