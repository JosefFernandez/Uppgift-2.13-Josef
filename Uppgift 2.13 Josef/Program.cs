using System;

namespace uppgift_2._13

{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lön för anställd person Josef");
            int Josef = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för anställd person Oliver");
            int Oliver = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för anställd Max");
            int Max = int.Parse(Console.ReadLine());

            Console.WriteLine((Josef + Oliver + Max) / 3);


        }

    }
}
