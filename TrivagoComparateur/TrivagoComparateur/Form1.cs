using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrivagoComparateur
{
    public partial class Form1 : Form
    {


        private static ClientRest clientRest = new ClientRest();
        private Dictionary<string, List<string>> agencePartenaires = new Dictionary<string, List<string>>() {
            { @"https://localhost:44324/api/Agences/", new List<string>() { "Montpellier", "5" } },
             { @"https://localhost:44341/api/Agences/", new List<string>() { "Montpellier", "5" } }
        };
        private List<string> baseUrlAgencesChoisis;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxResultat.Text = "Loading..";
            List<OffreComparateur> offres;
            baseUrlAgencesChoisis = new List<string>();

            string route;
            foreach (KeyValuePair<string, List<string>> agence in agencePartenaires)
            {
                if (agence.Value[0].Equals(textBoxVille.Text.ToString().Trim()) && (agence.Value[1].CompareTo(textBoxNombreEtoile.Text.ToString()) >= 0))
                {
                    baseUrlAgencesChoisis.Add(agence.Key);
                }
            }
            offres = new List<OffreComparateur>();
            route = "offres" + "/" + textBoxVille.Text.ToString() + "/" + textBoxDateDebut.Text.ToString() + "/" + textBoxDateFin.Text.ToString() + "/" + textBoxNombrePersonne.Text.ToString() + "/" + textBoxNombreEtoile.Text.ToString();

            foreach (string baseUrlAgence in baseUrlAgencesChoisis)
            {
                offres.AddRange(clientRest.makeRequestGetOffresComparateur(baseUrlAgence, route));
            }
            textBoxResultat.Text = "";
            foreach (OffreComparateur o in offres)
            {
                textBoxResultat.Text += o.ToString() + Environment.NewLine;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
