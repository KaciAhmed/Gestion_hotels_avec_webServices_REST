
namespace Comparateur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_ville = new System.Windows.Forms.TextBox();
            this.t_DateArrivee = new System.Windows.Forms.TextBox();
            this.l_ville = new System.Windows.Forms.Label();
            this.l_dateArrivee = new System.Windows.Forms.Label();
            this.t_DateDepart = new System.Windows.Forms.TextBox();
            this.t_prixMin = new System.Windows.Forms.TextBox();
            this.t_prixMax = new System.Windows.Forms.TextBox();
            this.t_nbEtoile = new System.Windows.Forms.TextBox();
            this.t_nbPersonne = new System.Windows.Forms.TextBox();
            this.l_DateDepart = new System.Windows.Forms.Label();
            this.l_prixMin = new System.Windows.Forms.Label();
            this.l_prixMax = new System.Windows.Forms.Label();
            this.l_nbEtoiles = new System.Windows.Forms.Label();
            this.l_nbPersonne = new System.Windows.Forms.Label();
            this.b_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_ville
            // 
            this.t_ville.Location = new System.Drawing.Point(116, 39);
            this.t_ville.Name = "t_ville";
            this.t_ville.Size = new System.Drawing.Size(100, 22);
            this.t_ville.TabIndex = 0;
            // 
            // t_DateArrivee
            // 
            this.t_DateArrivee.Location = new System.Drawing.Point(116, 82);
            this.t_DateArrivee.Name = "t_DateArrivee";
            this.t_DateArrivee.Size = new System.Drawing.Size(100, 22);
            this.t_DateArrivee.TabIndex = 1;
            // 
            // l_ville
            // 
            this.l_ville.AutoSize = true;
            this.l_ville.Location = new System.Drawing.Point(62, 44);
            this.l_ville.Name = "l_ville";
            this.l_ville.Size = new System.Drawing.Size(34, 17);
            this.l_ville.TabIndex = 2;
            this.l_ville.Text = "Ville";
            // 
            // l_dateArrivee
            // 
            this.l_dateArrivee.AutoSize = true;
            this.l_dateArrivee.Location = new System.Drawing.Point(17, 82);
            this.l_dateArrivee.Name = "l_dateArrivee";
            this.l_dateArrivee.Size = new System.Drawing.Size(87, 17);
            this.l_dateArrivee.TabIndex = 3;
            this.l_dateArrivee.Text = "Date Arrivée";
            // 
            // t_DateDepart
            // 
            this.t_DateDepart.Location = new System.Drawing.Point(116, 133);
            this.t_DateDepart.Name = "t_DateDepart";
            this.t_DateDepart.Size = new System.Drawing.Size(100, 22);
            this.t_DateDepart.TabIndex = 4;
            // 
            // t_prixMin
            // 
            this.t_prixMin.Location = new System.Drawing.Point(144, 172);
            this.t_prixMin.Name = "t_prixMin";
            this.t_prixMin.Size = new System.Drawing.Size(43, 22);
            this.t_prixMin.TabIndex = 5;
            // 
            // t_prixMax
            // 
            this.t_prixMax.Location = new System.Drawing.Point(327, 172);
            this.t_prixMax.Name = "t_prixMax";
            this.t_prixMax.Size = new System.Drawing.Size(43, 22);
            this.t_prixMax.TabIndex = 6;
            // 
            // t_nbEtoile
            // 
            this.t_nbEtoile.Location = new System.Drawing.Point(116, 211);
            this.t_nbEtoile.Name = "t_nbEtoile";
            this.t_nbEtoile.Size = new System.Drawing.Size(100, 22);
            this.t_nbEtoile.TabIndex = 7;
            // 
            // t_nbPersonne
            // 
            this.t_nbPersonne.Location = new System.Drawing.Point(116, 247);
            this.t_nbPersonne.Name = "t_nbPersonne";
            this.t_nbPersonne.Size = new System.Drawing.Size(100, 22);
            this.t_nbPersonne.TabIndex = 8;
            // 
            // l_DateDepart
            // 
            this.l_DateDepart.AutoSize = true;
            this.l_DateDepart.Location = new System.Drawing.Point(19, 133);
            this.l_DateDepart.Name = "l_DateDepart";
            this.l_DateDepart.Size = new System.Drawing.Size(85, 17);
            this.l_DateDepart.TabIndex = 9;
            this.l_DateDepart.Text = "Date Départ";
            // 
            // l_prixMin
            // 
            this.l_prixMin.AutoSize = true;
            this.l_prixMin.Location = new System.Drawing.Point(37, 172);
            this.l_prixMin.Name = "l_prixMin";
            this.l_prixMin.Size = new System.Drawing.Size(59, 17);
            this.l_prixMin.TabIndex = 10;
            this.l_prixMin.Text = "Prix MIN";
            // 
            // l_prixMax
            // 
            this.l_prixMax.AutoSize = true;
            this.l_prixMax.Location = new System.Drawing.Point(257, 172);
            this.l_prixMax.Name = "l_prixMax";
            this.l_prixMax.Size = new System.Drawing.Size(64, 17);
            this.l_prixMax.TabIndex = 11;
            this.l_prixMax.Text = "Prix MAX";
            // 
            // l_nbEtoiles
            // 
            this.l_nbEtoiles.AutoSize = true;
            this.l_nbEtoiles.Location = new System.Drawing.Point(23, 211);
            this.l_nbEtoiles.Name = "l_nbEtoiles";
            this.l_nbEtoiles.Size = new System.Drawing.Size(73, 17);
            this.l_nbEtoiles.TabIndex = 12;
            this.l_nbEtoiles.Text = "NB Etoiles";
            // 
            // l_nbPersonne
            // 
            this.l_nbPersonne.AutoSize = true;
            this.l_nbPersonne.Location = new System.Drawing.Point(4, 247);
            this.l_nbPersonne.Name = "l_nbPersonne";
            this.l_nbPersonne.Size = new System.Drawing.Size(92, 17);
            this.l_nbPersonne.TabIndex = 13;
            this.l_nbPersonne.Text = "NB Pérsonne";
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(141, 304);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(75, 31);
            this.b_submit.TabIndex = 14;
            this.b_submit.Text = "submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_ville);
            this.groupBox1.Controls.Add(this.l_dateArrivee);
            this.groupBox1.Controls.Add(this.l_DateDepart);
            this.groupBox1.Controls.Add(this.l_nbPersonne);
            this.groupBox1.Controls.Add(this.b_submit);
            this.groupBox1.Controls.Add(this.l_nbEtoiles);
            this.groupBox1.Controls.Add(this.l_ville);
            this.groupBox1.Controls.Add(this.l_prixMin);
            this.groupBox1.Controls.Add(this.l_prixMax);
            this.groupBox1.Controls.Add(this.t_DateArrivee);
            this.groupBox1.Controls.Add(this.t_DateDepart);
            this.groupBox1.Controls.Add(this.t_prixMin);
            this.groupBox1.Controls.Add(this.t_prixMax);
            this.groupBox1.Controls.Add(this.t_nbEtoile);
            this.groupBox1.Controls.Add(this.t_nbPersonne);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 351);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface Réservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox t_ville;
        private System.Windows.Forms.TextBox t_DateArrivee;
        private System.Windows.Forms.Label l_ville;
        private System.Windows.Forms.Label l_dateArrivee;
        private System.Windows.Forms.TextBox t_DateDepart;
        private System.Windows.Forms.TextBox t_prixMin;
        private System.Windows.Forms.TextBox t_prixMax;
        private System.Windows.Forms.TextBox t_nbEtoile;
        private System.Windows.Forms.TextBox t_nbPersonne;
        private System.Windows.Forms.Label l_DateDepart;
        private System.Windows.Forms.Label l_prixMin;
        private System.Windows.Forms.Label l_prixMax;
        private System.Windows.Forms.Label l_nbEtoiles;
        private System.Windows.Forms.Label l_nbPersonne;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

