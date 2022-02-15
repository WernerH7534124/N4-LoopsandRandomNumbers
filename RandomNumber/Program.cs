using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");

            //Programm genereerib juhuslikku numbrit 1-10 
            //Kui genereeritud number on 5, soovib konsool "Kena päeva!"
            //ja programm lõppeb.
            //Seni jätkab programm numbrite genereerimist

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number: {myRandomNumber}");
                if (myRandomNumber == 5) 
                {
                    i = myRandomNumber;
                }


            }



            








        }
    }
}
