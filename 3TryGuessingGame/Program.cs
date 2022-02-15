using System;

namespace _3TryGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast mängima!");

            //Programm genereerib juhuslikku numbrit  1-10
            //Kasutaja peab võitmiseks selle numbri ära arvama
            //Kasutajal on kolm katset
            //Kui kasutaja ei arva numbrit ära on mäng läbi
            //Programm genereerib juhuslikku numbrit üks kord


            Console.WriteLine("Võitmiseks tuleb pakkuda arv ühest - kümneni");

            Console.WriteLine("Mängus on teil kolm katset");

            Random rnd = new Random();
            int AINumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            
            {
                Console.WriteLine("Kirjutage oma vastus numbriga ja vajuta enter: ");
            int HumanNumber  = Convert.ToInt32(Console.ReadLine());

                if (HumanNumber == AINumber)
                {
                    Console.WriteLine("WoW - Palju Õnne, Olete võitnud!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale! Katseid jäänud: {3 - (i)}");

                                    }
                            }

            Console.WriteLine("Tänan mängimast!");
        }

    }
}
