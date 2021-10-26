//K1773
//Lab 6
//10-25-20
//CIS 199-02
//Program that outputs *'s in patterns using nested for loops

using static System.Console;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxRow = 10;                                              //constant for the number of rows of *'s
            int numSpaces, numStars;                                            //variables for setting how many spaces or *'s should be outputed in a line

            WriteLine("Pattern A");                                             //label for patern A

            for (int rowCount = 0; rowCount < maxRow; rowCount++)               //for loop that initiates however many times the maxRow constant is set for
            {
                numStars = rowCount + 1;                                        //assigning how many stars should be outputed for each row
                for(int starCount = 0; starCount < numStars; starCount++)       //for loop that outputs the *s 
                {
                    Write("*");
                }
                WriteLine("");
            }

            WriteLine("Pattern B");                                             //label for patern B

            for (int rowCount = 0; rowCount < maxRow; rowCount++)               //for loop that initiates however many times the maxRow constant is set for
            {
                numStars = maxRow - rowCount;                                   //assigning how many stars should be outputed for each row
                for (int starCount = 0; starCount < numStars; starCount++)      //for loop that outputs the *s to each row
                {
                    Write("*");
                }
                WriteLine("");
            }

            WriteLine("Pattern C");                                             //label for patern C

            for (int rowCount = 0; rowCount < maxRow; rowCount++)               //for loop that initiates however many times the maxRow constant is set for
            {
                numStars = maxRow - rowCount;                                   //assigning how many stars should be outputed for each row
                numSpaces = rowCount;                                           //assigning how many spaces should be outputed before the stars for each row
                for (int starCount = 0; starCount < numSpaces; starCount++)     //for loop that outputs the spaces to each row
                {
                    Write(" ");
                }
                for (int starCount = 0; starCount < numStars; starCount++)      //for loop that outputs the *s to each row
                {
                    Write("*");
                }
                WriteLine("");
            }

            WriteLine("Pattern D");                                             //label for patern D

            for (int rowCount = 0; rowCount < maxRow; rowCount++)               //for loop that initiates however many times the maxRow constant is set for
            {
                numStars = rowCount + 1;                                        //assigning how many stars should be outputed for each row
                numSpaces = maxRow - numStars;                                  //assigning how many spaces should be outputed before the stars for each row
                for (int starCount = 0; starCount < numSpaces; starCount++)     //for loop that outputs the spaces to each row
                {
                    Write(" ");
                }
                for (int starCount = 0; starCount < numStars; starCount++)      //for loop that outputs the *s to each row
                {
                    Write("*");
                }
                WriteLine("");
            }

        }
    }
}
