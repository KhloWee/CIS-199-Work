//K1773
//Lab 5
//10-9-20
//CIS 199-02
//Prgram that validates user tempurature input and averages correct inputs

using System;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0, numValid = 0;     //declaring needed variables
            double average = 0.0;
            double total = 0.0;
            string input;
            const int limitHigh = 130;          //constant for higher limit of tempurature input
            const int limitLow = -20;           //constant for lower limit of tempurature input
            const int stopCase = 999;

            WriteLine("Enter tempuratures from {0} to {1} ({2} to stop)", limitLow, limitHigh, stopCase);  //outputing instructions

            do
            {
                Write("Enter tempurature: ");           //prompting user and reading input
                input = ReadLine();

                if (int.TryParse(input, out inputNum))      //testing if input is valid integer
                {
                    if (inputNum <= limitHigh && inputNum >= limitLow)      //testing if input is within limits
                    {
                        total += inputNum;
                        numValid++;
                    }
                    else
                        WriteLine("Valid tempuratures range from {0} to {1}. Please reenter tempurature.", limitLow, limitHigh);    //error message for bad input
                }
                else
                    WriteLine("Valid tempuratures range from {0} to {1}. Please reenter tempurature.", limitLow, limitHigh);



            } while (inputNum != stopCase);

            average = total / numValid;

            WriteLine("You entered {0} valid tempuratures", numValid);          //outputing final average and number of valid inputs
            WriteLine("The mean Tempurature is {0:0.0} degrees", average);
        }
    }
}
