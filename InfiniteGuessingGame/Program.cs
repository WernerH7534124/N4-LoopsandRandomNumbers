using System;

namespace InfiniteGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tere tulemast mängima!");


            //Programm genereerib juhuslikku numbrit  1-10
            //Kasutaja peab võitmiseks selle numbri ära arvama
            //Kasutajal on piiramatu arv katseid
            //Programm genereerib juhuslikku numbrit üks kord


            Console.WriteLine("Võitmiseks tuleb pakkuda arv ühest - kümneni");

            Console.WriteLine("Mängus on teil lõputu arv katseid");

            Random rnd = new Random();
            int AINumber = rnd.Next(1, 11);
            bool LoopActive = true;
            int i = -1;

            while (LoopActive)

            {
                Console.WriteLine("Kirjutage oma vastus numbriga ja vajuta enter: ");
                int HumanNumber = Convert.ToInt32(Console.ReadLine());

                if (HumanNumber == AINumber)
                {
                    Console.WriteLine("WoW - Palju Õnne, Olete võitnud!");
                    LoopActive = false;

                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale! Proovi uuesti. Kasutatud katseid: {i+1}");

                }
            }

            Console.WriteLine("Tänan mängimast!");


        }
    }
}
