using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C
{
    class Program
    {       //Syntactic sugar is syntax designed to make things easier to read or to express.


        static void Main(string[] args) => Bleed();

        static void Bleed(string Me = "I", string Blood = "Orange")
        {
            Console.WriteLine($"{Me} bleed {Blood}");
            Manual.Me(); Manual.Blood();
        }
        static void Bleed(string Me = "I", string Blood = "Orange", string Time = "Always")
        {
            Console.WriteLine($"{Me} {Time} bleed {Blood}");
            Manual.Me(); Manual.Time(); Manual.Blood();
        }
    }
    class Manual
    {
        public static string Me()
        {
            return ("I");
        }
        public static string Blood()
        {
            return ("Orange");
        }
        public static string Time()
        {
            return ("");
        }
    }
}
