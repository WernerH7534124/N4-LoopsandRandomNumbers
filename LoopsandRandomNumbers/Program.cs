using System;

namespace LoopsandRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");

            //1.0
            //Programm palun sisestada PIN koodi
            //Programm võrdleb arvuga 1234
            //Kui sisestatud PIN on 1234 kuvab konsool "Tere Tulemast!"
            //Kui sisestatud PIN on midagi muud kuvab konsool "Vale PIN! - Proovi uuesti"
            //1.1
            //Kasutajale antakse kolm katset PIN koodi sisestamiseks
            //

            int i = 0;

            while (i < 3)

            {

                Console.WriteLine("Sisestage PIN kood: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("PIN ÕIGE - Tere tulemast tagasi!");
                    break;
                }
                else
                {
                    //i = i + 1;
                    i++;

                    Console.WriteLine($"Vale PIN. {3 - i} katset alles");
                }

                Console.WriteLine("Kena päeva jätku!");

            }
        }
    }
}

                



        
    

