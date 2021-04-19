﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Reservation
    {
        private int identifiant;
        private string reference;
        private string dateDebut;
        private string dateFin;
        private int nbPersonne;
        private string informationCarteCredit;
        private Client client;
        private Agence agence;
        private Chambre chambre;

        public Reservation()
        {
        }

        public Reservation(int identifiant, string reference, string dateDebut, string dateFin, int nbPersonne, string informationCarteCredit, Client client, Agence agence, Chambre chambre)
        {
            this.identifiant = identifiant;
            this.reference = reference;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.nbPersonne = nbPersonne;
            this.informationCarteCredit = informationCarteCredit;
            this.client = client;
            this.agence = agence;
            this.chambre = chambre;
        }

        public int ReservationId { get => identifiant; set => identifiant = value; }
        public string Reference { get => reference; set => reference = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        public int NbPersonne { get => nbPersonne; set => nbPersonne = value; }
        public string InformationCarteCredit { get => informationCarteCredit; set => informationCarteCredit = value; }
        [ForeignKey("ClientId")]
        public Client Client { get => client; set => client = value; }
        [ForeignKey("AgenceId")]
        public Agence Agence { get => agence; set => agence = value; }
        [ForeignKey("ChambreId")]
        public Chambre Chambre { get => chambre; set => chambre = value; }
    }
}
