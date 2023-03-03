// See https://aka.ms/new-console-template for more information
using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                int num;
                if (int.TryParse(arg, out num))
                {
                    Console.WriteLine("The input given : " + num + " is a integer and is Hexadecimal value is '0x{0:X}'", num);
                    
                    
                }

                else
                {
                    Console.WriteLine("The input given : " + arg + " is not an integer");
                }


            }
        }
    }
}
