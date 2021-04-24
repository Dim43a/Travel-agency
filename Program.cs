using System;
using System.Collections.Generic;

namespace Dmitri_Zigulev_OOADP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Packet packet1 = new Packet  ("Turkey all inclusive 5*", 300, 600.0, 2);
            Packet packet2 = new Packet("Old Tallinn Tour", 1, 15.0, 20);
            Packet packet3 = new Packet("Skiing in  Ootepaa", 72, 300.0, 4);

            Special special1 = new Special ("Bali trip", 168, 1000.0, 10,5,5); 
            Special special2 = new Special ("Culture trip to Saint's Petersburg ", 96, 200.0, 60,10,30);
            Special special3 = new Special ("KUMU ART Exhibion*", 4, 35.0, 30, 20, 40); // Вариант с икслючением , где МАХ кол-во людей меньше , чем кол-во людей для скидки

            Console.WriteLine(packet1);
            packet1.ForWho(1); //True
            packet1.ForWho(2); //True
            packet1.ForWho(3); //False
            packet1.HowMuch(1); //600
            packet1.HowMuch(2); //1200
            packet1.HowMuch(3); //False

            Console.WriteLine(special2);
            special2.ForWho(1); //True
            special2.ForWho(60); //True
            special2.ForWho(61); //False

            special2.HowMuch(1); //200
            special2.HowMuch(30); //Your price with 10% discount is : 5400
            special2.HowMuch(61); //False
            special3.HowMuch(30); // Your price with 20% discount is : 840

            List<Packet> list = new List<Packet>();
            list.Add(packet1);
            list.Add(packet2);
            list.Add(packet3);
            list.Add(special1);
            list.Add(special2);
            list.Add(special3);

            foreach (Packet p in list)
            {
                Console.WriteLine(p);   //Print all list
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
