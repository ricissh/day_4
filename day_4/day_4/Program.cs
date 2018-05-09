
using System;

namespace day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais;
            string ievade = Console.ReadLine();
            mainigais = Convert.ToInt16(ievade);

            Console.WriteLine(mainigais);
            // < 
            // >
            // ==
            // !=
            // <=
            // >=
            if (mainigais == 3)
            {
                Console.WriteLine("trijsturis");
            }
            else
            {
                if (mainigais == 4)
                {
                    Console.WriteLine("cetrsturis");
                }
                else
                {
                    if (mainigais == 5)
                    {
                        Console.WriteLine("piecsturis");
                    }
                    else
                    {
                        Console.WriteLine("Kluda!");
                    }
                }
            }





            ievade = Console.ReadLine();
            mainigais = Convert.ToInt16(ievade);

            switch ( mainigais)
            {
                case 1:
                    Console.WriteLine("George Wasington");
                    break;
                case 2:
                    Console.WriteLine("Thomas Jefferson");
                    break;
                case 5:
                    Console.WriteLine("Abraham Lincoln");
                    break;
                case 10:
                    Console.WriteLine("Alexender Hamilton");
                    break;
                case 20:
                    Console.WriteLine("Andrew Jackson");
                    break;
                case 50:
                    Console.WriteLine("Ulysses S. Grant");
                    break;
                case 100:
                    Console.WriteLine("Benjamin Franklin");
                    break;
                default:
                    Console.WriteLine("Nav tadas valutas!");
                    break;
            }




            switch (ievade)
            {
                case "piecsturis":
                    Console.WriteLine("JAAA!!!");
                    break;
                default:
                    Console.WriteLine("NEEE!");
                    break;
            }


            string mainigais2 = "si ir virkne";

            if (mainigais2 == "si ir virkne")
            {
                Console.WriteLine("vienads");
            }
            else
            {
                Console.WriteLine("nav vienads");
            }

            Console.ReadLine();
        }
    }
}