//K1773
//Lab 7
//11-8-20
//CIS 199-02
//Program for printing box of stars sized by user input

using static System.Console;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;     //declaring bool used in do while loop
            int starsIn;            //declaring integer for number of stars eneted after parsing
            do
            {
                

                WriteLine("Please enter the number of rows and colums of stars you want (integer more than 0)");        //promting user for input 
                string input = ReadLine();                  //reading input and storing it into string

                if (int.TryParse(input, out starsIn))       //testing if input is parsable to integer
                {   
                    if(starsIn > 0)                         //testing if input is positive
                    {
                        StarPrinter(starsIn);               //calling star pringting method if input is valid
                        valid = true;                       //changing bool value so loop can end
                    }
                    else
                    {
                        WriteLine("Please enter a positive integer.");      //outputting error if integer isn't positive
                    }
                }
                else
                {
                    WriteLine("Please enter an integer.");                  //ouputting error if input isn't an an integer
                }


            } while (!valid);           
            

        }
        static void StarPrinter(int numStars)                           //declairing method
        {
            for(int i = 0; i < numStars; i++)                           //loop that goes through each row for the amoun of times entered when calling method
            {
                for (int count = 0; count < numStars; count++)          //loop that prints the appropriate amount of stars in each column based of number entered when calling method
                {
                    Write("*");                                         //printing stars
                }
                WriteLine("");                                          //going to next line after each row is done printing
            }
        }
    }
}
