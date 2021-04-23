using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Program
    {
        private readonly static string LoginAgence = "LoginAgence1";
        private readonly static string mdp = "123";
        private static ClientRest clientRest = new ClientRest();

        private static void Main(string[] args)
        {
            string dateArrivee;
            string dateDepart;
            int nombrePersonnes;
            string choix = "-1";
            string offre;
            string nomClient;
            string prenomClient;
            string infoCarteCreditClient;
            string nbEtoile;
            string ville;
            List<string> offres;
            string resultatReservation;
            List<string> baseUrlHotelsChoisis ;
            string route;
            string url;
            Dictionary<string,List<string>> hotelsPartenaires= new Dictionary<string, List<string>>();
            hotelsPartenaires.Add(@"https://localhost:44365/api/Hotels/", new List<string>() { "Montpellier", "5"});
        // hotelsPartenaires.Add(@"https://localhost:44365/api/Hotels/", new List<string>() { "Paris", "4"});
        //  hotelsPartenaires.Add(@"https://localhost:44365/api/Hotels/", new List<string>() { "Lyon", "3"});
            do
             {
                 ville = saisie("ville");
                 dateArrivee = saisie("date d'arriver");
                 dateDepart = saisie("date de depart");
                 nbEtoile = saisie("nombre d'étoile");
                 nombrePersonnes = int.Parse(saisie("nombre de personne a heberger entre 1 et 3 (refaite une reservation pour plus de personne)"));
                 baseUrlHotelsChoisis = new List<string>();
                 foreach(KeyValuePair<string, List<string>> hotel in hotelsPartenaires)
                 {
                     if (hotel.Value[0].Equals(ville.Trim()) && hotel.Value[1].Equals(nbEtoile.Trim()))
                     {
                         baseUrlHotelsChoisis.Add(hotel.Key);
                     }

                 }

                 offres = new List<string>();
                 route= "offres" + "/"+LoginAgence + "/" + mdp + "/" + dateArrivee + "/" + dateDepart + "/" + nombrePersonnes;
                 foreach(string baseUrlHotel in baseUrlHotelsChoisis)
                 {
                     url = baseUrlHotel+route;
                     offres.Add(clientRest.makeRequestGET(url));
                 }

                 afficherOffres(offres);


                 choix = saisie("voulez vous continuer (1 = oui / -1 = non)");
                 if (!choix.Equals(-1))
                 {
                     nomClient = saisie("votre nom");
                     prenomClient = saisie("votre prénom");
                     infoCarteCreditClient = saisie("les informations de votre carte de crédit");
                     do
                     {
                         Console.WriteLine("Veillez sélectionner l'identifiant de l'offre que vous souhaitter, SVP (pour quitter tapez -1)");
                         choix = saisie("identifiant de l'offre");
                         offre = getOffre(choix, offres);
                     } while (offre == null);

                   //  resultatReservation = effectuerReservation(LoginAgence, mdp, offre.Identifiant, dateArrivee, dateDepart, nombrePersonnes, nomClient, prenomClient, infoCarteCreditClient);

                    // afficherResultatReservation(resultatReservation);

                     choix = saisie("voulez effectuer une autre réservation (1 = oui / -1 = non)");
                 }
             } while (!choix.Equals("-1"));

             Console.ReadLine();
         }
         private static string saisie(string nomAfficher)
         {
             Console.WriteLine("Saisir " + nomAfficher + " ?");
             string res = Console.ReadLine();
             return res;
         }
        /* public static Image byteArrayToImage(byte[] bytesArr)
         {
             using (MemoryStream memstr = new MemoryStream(bytesArr))
             {
                 Image img = Image.FromStream(memstr);
                 return img;
             }
         }
        */
         public static void afficherOffres(List<string> offres)
         {
             foreach (string offre in offres)
             {
                // Image image = byteArrayToImage(offre.Image);
                // image.Save(offre.Identifiant + "_chambre.png", ImageFormat.Png);
                 Console.WriteLine(offre);
             }
         }
         private static void afficherResultatReservation(String resultat)
         {
             if (resultat.StartsWith("#"))
             {
                 Console.WriteLine("Réservation réussi.");
                 Console.WriteLine("La référence de votre réservation est :" + resultat);
             }
             else
             {
                 Console.WriteLine(resultat);
             }
         }
         public static string getOffre(String id, List<string> offres)
         {
            /*  foreach (string offre in offres)
              {
                  if (offre.Identifiant.Equals(id))
                  {
                      return offre;
                  }
              }

            */
            return null;
        }
        /*
         public static string effectuerReservation(string LoginAgence, string mdp, string identifiantOffre, String dateDebut, String dateFin, int nombrePersonnes, string nomClient, string prenomClient, string infoCarteCreditClient)
         {
             return serviceReservation.creerReservation(LoginAgence, mdp, identifiantOffre, dateDebut, dateFin, nombrePersonnes, nomClient, prenomClient, infoCarteCreditClient);
         }
            */
        
    }
}
