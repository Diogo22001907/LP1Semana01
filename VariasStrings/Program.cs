using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Diogo Miguel Viegas Ferreira";
            string citation = "and i quote \"This was is last wish\"";
            string citation2 = @"and i quote ""This was is last wish""";
            string filePath = "C:\\Users\\Diogo\\Documents\\LP1";
            string fileLocation = @"C:\User\Diogo\Documents\LP1";
            string monkeyEmoji = "\u1F648 monkey covering is eyes ";



            Console.WriteLine(myName);
            Console.WriteLine(citation);
            Console.WriteLine(citation2);
            Console.WriteLine(filePath);
            Console.WriteLine(fileLocation);
            Console.WriteLine(monkeyEmoji);


        }
    }
}
