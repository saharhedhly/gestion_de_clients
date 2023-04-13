using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_clients
{
    internal class Client
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumeroChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;
        }




        public override string ToString()
        {
            return $"Nom: {Nom}\nPrenom: {Prenom}\nCourriel: {Courriel}\nCarte de crédit: {CarteCredit}\nNuméro de chambre: {NumeroChambre}";
        }
    }



}
