using System;
namespace ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {

            //full name
            string name = "Shirley Alvarez";

            //Location of the letter i
            int charPos = name.IndexOf("i");

            //Get last name
            string lastName =name.Substring(charPos);

            //print the result
            Console.WriteLine(lastName);
;        }
    }
}



