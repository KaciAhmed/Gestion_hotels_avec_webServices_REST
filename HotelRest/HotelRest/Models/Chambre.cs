using System;
using System.Collections.Generic;
using System.IO;

namespace HotelRest.Models
{
    public class Chambre
    {
        public int ChambreId { get; set; }
        public int Numero { get; set; }
        public bool EstLibre { get; set; }
        public string DateDisponibilite { get; set; }
        public float PrixDeBase { get; set; }
        public string UrlImage { get; set; }
        public byte[] Image { get; set; }
        public TypeChambre TypeChambre { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        public Chambre()
        {
            Reservations = new List<Reservation>();
        }

        public Chambre(int chambreId, int numero, bool estLibre, string dateDisponibilite, float prixDeBase, string urlImage, byte[] image, TypeChambre typeChambre, Hotel hotel, ICollection<Reservation> reservations)
        {
            ChambreId = chambreId;
            Numero = numero;
            EstLibre = estLibre;
            DateDisponibilite = dateDisponibilite;
            PrixDeBase = prixDeBase;
            UrlImage = urlImage;
            Image = image;
            TypeChambre = typeChambre;
            Hotel = hotel;
            Reservations = reservations;
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