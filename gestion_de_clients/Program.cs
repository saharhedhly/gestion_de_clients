using System;
using gestion_de_clients;
using gestion_Hotel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        Hotel hotel1 = new Hotel();


        Client client1 = new Client("hedhli", "sahar", "sahar@gmail.com", "1234567", 10);
        Client client2 = new Client("kharbechi", "jamila", "jamila@gmail.com", "65437896", 18);
        Client client3 = new Client("hedhli", "sirine", "sirine@gmail.com", "987654", 20);
        Client client4 = new Client("moussi", "amal", "amal@gmail.com", "1565427", 15);

        hotel1.AjouterClient(client1);
        hotel1.AjouterClient(client2);
        hotel1.AjouterClient(client3);
        hotel1.AjouterClient(client4);


        Console.WriteLine(hotel1);

    }



}