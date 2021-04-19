using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelsAvecWebServicesRest.Models
{
    public class Chambre
    {
        private int identifiant;
        private int numero;
        private bool estLibre;
        private string dateDisponibilite;
        private float prixDeBase;
        private string urlImage;
        private byte[] image;
        private TypeChambre typeChambre;
        private Hotel hotel;
        private List<Reservation> reservations = new List<Reservation>();

        public Chambre()
        {

        }

        public Chambre(int identifiant, int numero, string dateDisponibilite, TypeChambre typeChambre, float prixDeBase, bool estLibre, string urlImage,Hotel hotel)
        {

            this.identifiant = identifiant;
            this.numero = numero;
            this.dateDisponibilite = dateDisponibilite;
            this.estLibre = estLibre;
            this.prixDeBase = prixDeBase;
            this.typeChambre = typeChambre;
            this.urlImage = urlImage;
            image = StreamToByteArray(urlImage);
            this.hotel = hotel;
        }

        public int ChambreId { get => identifiant; set => identifiant = value; }
        public int Numero { get => numero; set => numero = value; }
        public bool EstLibre { get => estLibre; set => estLibre = value; }
        public string DateDisponibilite { get => dateDisponibilite; set => dateDisponibilite = value; }
        public float PrixDeBase { get => prixDeBase; set => prixDeBase = value; }
        [ForeignKey("TypeChambreId")]
        public TypeChambre TypeChambre { get => typeChambre; set => typeChambre = value; }

        public string UrlImage { get => urlImage; set => urlImage = value; }
        public byte[] Image { get => image; set => image = value; }

        [ForeignKey("HotelId")]
        public Hotel Hotel { get => hotel; set => hotel = value; }
        public List<Reservation> Reservations { get => reservations; set => reservations = value; }


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
