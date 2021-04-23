using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparateur
{
    public partial class Form1 : Form
    {
        List<string> agences = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            ClientRest clientRest = new ClientRest();
            agences.Add("Comparateur");
            agences.Add("Agence2");
            agences.Add("Agence3");

            foreach (string ag in agences)
            {
                clientRest.EndPointReq = "https" + "://localhost:44381/api/" + ag + "/" + t_ville.Text + "/"
               + t_DateDepart.Text + "/" + t_DateArrivee.Text  + "/"+ t_prixMin.Text + "/"+t_prixMax+"/" 
               +t_nbEtoile.Text + "/" + t_nbPersonne.Text;

                string strResponse = string.Empty;
                strResponse = clientRest.makeRequest();

 
            }

        }
    }
}
