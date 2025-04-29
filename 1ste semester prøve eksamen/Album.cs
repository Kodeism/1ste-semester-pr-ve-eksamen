using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//opgave: 3.2.1, 3.2.2 
namespace _1ste_semester_prøve_eksamen
{
    public class Album
    {
        public int Pris { get; set; }
        public string Isbn { get; set; }
        public string Titel { get; set; }
        public int UdgivelsesDato { get; set; }
        public string Tegner { get; set; }
        public int AntalProduceret { get; set; }
        public Album(string isbn, string titel, int udgivelsesDato, string tegner, int antalProduceret,int pris)
        {
            Isbn = isbn;
            Titel = titel;
            UdgivelsesDato = udgivelsesDato;
            Tegner = tegner;
            AntalProduceret = antalProduceret;
            Pris = pris;
        }
    }
}
