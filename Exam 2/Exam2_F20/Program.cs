//K1773
//Exam 2 
//11-9-20
//CIS 199-02
//using parallel array to output threat level of given counties  

using static System.Console;

namespace Exam2_F20
{
    class Program
    {
        static void Main(string[] args)
        {
            // The parallel arrays to be searched

            string[] counties = { "Jefferson" , "Clark", "Floyd", "Harrison", "Bullitt","Shelby", "Nelson", "Oldham", "Galatin", "Meade" };

            string[] threats = { "Red", "Orange", "Red", "Orange", "Red", "Orange", "Red", "Orange", "Yellow", "Orange" };

            WriteLine("Please enter in the county you want to see the threat level of.");
            string input = ReadLine();

            bool found = false;
            int index = 0;

            do
            {
                

                if (input.ToUpper() == counties[index].ToUpper())
                {
                    WriteLine("The state assessed threat level in {0} county is {1}.", input, threats[index]);

                    found = true;
                }
                else
                {
                    if (index == counties.Length - 1 && !found)
                    {
                        WriteLine("Sorry, no data for {0} county.", input);
                    }

                }
                index++;
            } while (!found && index < counties.Length);

        }
    }
}
