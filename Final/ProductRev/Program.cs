//K1773

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;

namespace ProductRev
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentValue;   // Current product's value
            double totalValue = 0; // Running total of product's value
            ProductItem[] items; // Product Items

            // #1 - Put code here to construct 3  product items: Face Masks, Hand Soaps, and Disinfection Sparys as directed
            ProductItem item1 = new ProductItem("Face Masks", "AB125", 20, 4.20);   //Face Masks
            ProductItem item2 = new ProductItem("Hand Soaps", "BB122", 152, 5.10);   //Hand Soaps
            ProductItem item3 = new ProductItem("Disnefection Sprays", "CG684", 69, 259);   //Disinfection Sparys

            items = new ProductItem[] { item1, item2, item3 };

            WriteLine($"Product Revenue Report:");

            // #2 - Complete loop to step through array of items
            for (int index = 0; index < items.Length ; ++index)
            {

                currentValue = items[index].CalcValue();// #3 - Complete statement to calculate value of current item
                                                        //      from array by calling CalcValue

                totalValue += currentValue;// #4 - Add currentValue into running total

                WriteLine($"Current value: {currentValue.ToString("C2", CultureInfo.CurrentCulture)}\n{items[index].ToString()}");
                // #5 - Output currentValue, with currency formatting, followed by string representation
                //      of current item from array
            }

            WriteLine($"\nTotal Gross Revenue: {totalValue.ToString("C2", CultureInfo.CurrentCulture)}");
            // #6 - Output totalValue of Gross Revenue, with currency formatting

        }
    }
}
