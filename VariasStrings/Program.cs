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


            string name = "Diogo";
            string lastName = "Ferreira";
            string age = "23";

            string s = "O meu nome é " + name + " " + lastName + " e tenho " + age + " anos";
            string t = String.Format("Eu {0} de beber {1} Monsters ao dia !", "gosto", 4);
            string u = String.Format("O meu nome é {0} {1} tenho {2} e vivo em {3}", "Diogo", "Ferreira", 23, "Lisboa");
            string f = $"My name is {name} {lastName} and i am {age} years old";
            int x = 5;
            int y = 10;
            int q = x + y;
            
            Console.WriteLine($@"se é x = {x} e y = {y} então x + y = {q}");
            Console.WriteLine(t);
            Console.WriteLine(s);
            Console.WriteLine(u);
            Console.WriteLine(f);
            Console.WriteLine("Olá o meu nome é {0} {1} e tenho {2} anos", name, lastName, age);
            Console.WriteLine(@"\u1F355 é o emoji da pizza");


        }
    }
}
