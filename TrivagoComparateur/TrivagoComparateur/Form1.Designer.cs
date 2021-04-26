
namespace TrivagoComparateur
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxDateDebut = new System.Windows.Forms.TextBox();
            this.textBoxDateFin = new System.Windows.Forms.TextBox();
            this.textBoxNombrePersonne = new System.Windows.Forms.TextBox();
            this.textBoxNombreEtoile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxDateDebut);
            this.groupBox1.Controls.Add(this.textBoxVille);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDateFin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNombrePersonne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombreEtoile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 450);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(12, 119);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 1;
            this.textBoxVille.Text = "Montpellier";
            // 
            // textBoxDateDebut
            // 
            this.textBoxDateDebut.Location = new System.Drawing.Point(12, 145);
            this.textBoxDateDebut.Name = "textBoxDateDebut";
            this.textBoxDateDebut.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateDebut.TabIndex = 2;
            this.textBoxDateDebut.Text = "18-04-2021";
            // 
            // textBoxDateFin
            // 
            this.textBoxDateFin.Location = new System.Drawing.Point(12, 171);
            this.textBoxDateFin.Name = "textBoxDateFin";
            this.textBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateFin.TabIndex = 3;
            this.textBoxDateFin.Text = "19-04-2021";
            // 
            // textBoxNombrePersonne
            // 
            this.textBoxNombrePersonne.Location = new System.Drawing.Point(12, 197);
            this.textBoxNombrePersonne.Name = "textBoxNombrePersonne";
            this.textBoxNombrePersonne.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombrePersonne.TabIndex = 4;
            this.textBoxNombrePersonne.Text = "1";
            // 
            // textBoxNombreEtoile
            // 
            this.textBoxNombreEtoile.Location = new System.Drawing.Point(12, 223);
            this.textBoxNombreEtoile.Name = "textBoxNombreEtoile";
            this.textBoxNombreEtoile.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreEtoile.TabIndex = 5;
            this.textBoxNombreEtoile.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre personne";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre etoile minimum";
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.AllowDrop = true;
            this.textBoxResultat.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxResultat.Location = new System.Drawing.Point(251, 0);
            this.textBoxResultat.Multiline = true;
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.ReadOnly = true;
            this.textBoxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxResultat.Size = new System.Drawing.Size(549, 450);
            this.textBoxResultat.TabIndex = 11;
            this.textBoxResultat.Text = "[\r\n   {\r\n      \"Nom\": \"Hotel 1\",\r\n      \"Adresse\": \"123, Rue Hotel 1, France\",\r\n " +
    "     \"NombreEtoile\": 5,\r\n      \"NombreLit\": 1,\r\n      \"Prix\": 46.410000000000004" +
    "\r\n   }\r\n]";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 262);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxResultat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Trivago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDateDebut;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombrePersonne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreEtoile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResultat;
        private System.Windows.Forms.Button buttonSearch;
    }
}

