using System;

namespace PINinfiniteloop
{
    class Program
    {
        static void Main(string[] args)

        //Programm palun sisestada PIN koodi
        //Programm võrdleb arvuga 1234
        //Kui sisestatud PIN on 1234 kuvab konsool "Tere Tulemast!"
        //Kui sisestatud PIN on midagi muud kuvab konsool "Vale PIN! - Proovi uuesti"
        //Katsete arv on piiramatu

        {
            Console.WriteLine("Tere!");

            bool loopActive = true;
            int i = 1;
           
            while (loopActive)
            {

                Console.WriteLine("Sisesta PIN kood: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Kood õige - Tere tulemast!");
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine($"Vale PIN - Proovi veel :) ; Valesti sisestatud katseid: {i++}");

                }

                Console.WriteLine("Kena päeva!");

            }
        }
    }
}


