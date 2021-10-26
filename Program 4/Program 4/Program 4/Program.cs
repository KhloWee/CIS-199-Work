//K1773
//Program 4 
//12-1-20
//CIS 199-02
//Program that uses service order objects to create an array of objects and output each property of them

using System;
using static System.Console;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Program_4
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            const int arrayLength = 6;              //constant for lenght of array of objects

            ServiceOrder[] orderArray = new ServiceOrder[arrayLength];  //creating array of order objects

            orderArray[0] = new ServiceOrder(40208, "bruh1", "4204204206", 175, "Rob Lowe", false);     //assinging values to each element of array of objects
            orderArray[1] = new ServiceOrder(40292, "uhhhh", "1235869871", 16, "Eric Andre", true);
            orderArray[2] = new ServiceOrder(40000, "B1576", "1654976213", 68, "Erica Badu", true);
            orderArray[3] = new ServiceOrder(40511, "C1111", "1987956164", 70, "Barrak Obama", false);
            orderArray[4] = new ServiceOrder(10052, "D2222", "1298791654", 125, "Ted", true);
            orderArray[5] = new ServiceOrder(11051, "E3333", "1111111111", 150, "Neil Armstrong", false);

            DisplayServiceOrder(orderArray);        //calling display service order method to display all objects within the array
        }

        public static void DisplayServiceOrder(ServiceOrder[] orderArray1)
        {
            foreach (var element in orderArray1) 
            {
                WriteLine(element.ToString());
                WriteLine();
            }
        }
    }
}
