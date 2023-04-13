using System;
using gestion_de_clients;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_Hotel
{
    internal class Hotel
    {
        private ArrayList listClients;

        public Hotel()
        {
            listClients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            listClients.Add(client);
        }


        public override string ToString()
        {
            string clients = "";
            foreach (Client c in listClients)
            {
                clients += c.ToString() + "\n\n";
            }
            return $"Liste de clients de l'hôtel:\n\n{clients}";
        }
    }
}
