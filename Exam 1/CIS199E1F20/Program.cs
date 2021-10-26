//K1773

using System;
using static System.Console;

namespace CIS199E1F20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int polutionNum;

            Console.WriteLine("Please enter number for pollution level");
            input = ReadLine();

            polutionNum = int.Parse(input);

            if (polutionNum < 25)
            {
                WriteLine("The air pollution level is very low");
            }
            else if (polutionNum < 50)
            {
                WriteLine("The air pollution level is low.");
            }
            else if (polutionNum < 75)
            {
                WriteLine("The air pollution level is medium.");
            }
            else if (polutionNum < 100)
            {
                WriteLine("The air pollution level is high.");
            }
            else
            {
                WriteLine("The air pollution level is very high.");
            }
        }
    }
}
