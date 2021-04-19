﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Agence
    {
        public int AgenceId { get; set; }
        public string Nom { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public double PourcentageReduction { get; set; }
        public int AdresseId { get; set; }
        [ForeignKey("AdresseId")]
        public virtual Adresse Adresse { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Client> Clients { get; set; }
        public virtual List<AgencesHotels> AgencesHotels { get; set; }
        public Agence()
        {
            this.Reservations = new List<Reservation>();
            this.Clients = new List<Client>();
            this.AgencesHotels = new List<AgencesHotels>();
        }
    }
}
