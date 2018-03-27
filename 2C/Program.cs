using System;

namespace _2C
{
    class Program
    {       //Syntactic sugar is syntax designed to make things easier to read or to express.

        static void Main(string[] args)
        {
            Bleed();
        }

        //static void Bleed(string me = "I", string blood = "Orange")
        //{
        //    Console.WriteLine($"{me} bleed {blood}");
        //}

        static void Bleed(string me, string blood)
        {
            Console.WriteLine($"{me} bleed {blood}");
        }

        static void Bleed(string me)
        {
            Bleed(me, "Red");
        }

        static void Bleed()
        {
            Bleed("I");
        }

    }
}
