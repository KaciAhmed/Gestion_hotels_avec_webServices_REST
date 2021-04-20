﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Chambre
    {
        [Key]
        public int ChambreId { get; set; }
        public int Numero { get; set; }
        public bool EstLibre { get; set; }
        public string DateDisponibilite { get; set; }
        public float PrixDeBase { get; set; }
        public virtual TypeChambre TypeChambre { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public string UrlImage { get; set; }
        public byte[] Image { get; set; }
        
        public Chambre()
        {
            this.Reservations = new List<Reservation>();
        }

        public byte[] StreamToByteArray(string fileName)
        {

            byte[] totalStream = new byte[0];

            using (Stream input = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                File.SetAttributes(fileName, FileAttributes.Normal);
                byte[] streamArray = new byte[0];
                byte[] buffer = new byte[64 * 1024];
                int read = 0;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    streamArray = new byte[totalStream.Length + read];
                    totalStream.CopyTo(streamArray, 0);
                    Array.Copy(buffer, 0, streamArray, totalStream.Length, read);
                    totalStream = streamArray;
                }
            }
            return totalStream;
        }
    }
}
