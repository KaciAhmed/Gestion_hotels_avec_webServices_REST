using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrivagoComparateur
{
    public partial class Form1 : Form
    {


        private static ClientRest clientRest = new ClientRest();
        private Dictionary<string, List<string>> agencePartenaires = new Dictionary<string, List<string>>() {
            { @"https://localhost:44324/api/Agences/", new List<string>() { "Montpellier", "5" } }
        };
        private List<string> baseUrlHotelsChoisis;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxResultat.Text = "Loading..";
            List<OffreComparateur> offres;
            baseUrlHotelsChoisis = new List<string>();

            string route;
            foreach (KeyValuePair<string, List<string>> hotel in agencePartenaires)
            {
                if (hotel.Value[0].Equals(textBoxVille.Text.ToString().Trim()) && (hotel.Value[1].CompareTo(textBoxNombreEtoile.Text.ToString()) >= 0))
                {
                    baseUrlHotelsChoisis.Add(hotel.Key);
                }
            }
            offres = new List<OffreComparateur>();
            route = "offres" + "/" + textBoxVille.Text.ToString() + "/" + textBoxDateDebut.Text.ToString() + "/" + textBoxDateFin.Text.ToString() + "/" + textBoxNombrePersonne.Text.ToString() + "/" + textBoxNombreEtoile.Text.ToString();

            foreach (string baseUrlHotel in baseUrlHotelsChoisis)
            {
                offres.AddRange(clientRest.makeRequestGetOffresComparateur(baseUrlHotel, route));
            }
            textBoxResultat.Text = "";
            foreach (OffreComparateur o in offres)
            {
                textBoxResultat.Text += o.ToString() + "\n";
            }

        }
    }
}
