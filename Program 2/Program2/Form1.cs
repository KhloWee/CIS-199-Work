//K1773
//Program 2
//10-15-20
//CIS 199-02
//Gui application to test the shipping rates of three competing companies based of user inputed shipping datas

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const double compAWeight = 1.0;         //constant for company A weight charge 
            const double compAMile = 0.02;          //constant for company A distance charge 
            const int compADay1 = 20;               //constants for company A delivery days charge
            const int compADay2 = 17;
            const int compADay3 = 15;
            const int compADay4 = 10;
            const int compADay5 = 7;
            const double compBMile = 0.10;          //constant for company B distance charge
            const int compBDay1 = 10;               //constants for company B delivery days charge
            const int compBDay2 = 7;
            const double compBWeight1 = 3.0;        //constants for company B weight charge
            const double compBWeight2 = 5.0;
            const double compBWeight3 = 10.0;
            const double compBWeight4 = 20.0;
            const double compBWeight5 = 0.15;
            const double compCWeight = 0.25;        //constant for company C weight charge
            const int compCDay = 20;                //constant for company C delivery days charge
            const double compCMile1 = 40.0;         //constants for company C distance charge
            const double compCMile2 = 35.0;
            const double compCMile3 = 25.0;
            const double compCMile4 = 15.0;
            const double compCMile5 = 10.0;

            int daysIn;                         //variable for days inputed
            double weightIn, milesIn;           //variables for weight and distance inputed
            double compATotal = 0;              //variables for the total cost of the different companies
            double compBTotal = 0;
            double compCTotal = 0;

            if (double.TryParse(weightInBox.Text, out weightIn))        //test to test weight input and convert it to double
            {
                if(double.TryParse(milesInBox.Text, out milesIn))       //test to test distance input and convert it to double
                {
                    if(Int32.TryParse(daysInBox.Text, out daysIn))      //test to test days input and convert it to int
                    {
                        if (weightIn <= 0.0 || milesIn < 0.0 || daysIn <= 0)        //test to make sure inputed variables are positive
                            MessageBox.Show("Invalid entry, please enter positive numbers");
                        else
                        {

                            compATotal += weightIn * compAWeight;       //calculations for company A shipping cost
                            compATotal += milesIn * compAMile;
                            if (daysIn == 1)
                                compATotal += compADay1;
                            else if (daysIn == 2)
                                compATotal += compADay2;
                            else if (daysIn == 3)
                                compATotal += compADay3;
                            else if (daysIn <= 7)
                                compATotal += compADay4;
                            else
                                compATotal += compADay5;

                            compBTotal += milesIn * compBMile;          //calculations for company B shipping cost
                            if (daysIn <= 4)
                                compBTotal += compBDay1;
                            else
                                compBTotal += compBDay2;
                            if (weightIn < 10.0)
                                compBTotal += compBWeight1;
                            else if (weightIn < 50.0)
                                compBTotal += compBWeight2;
                            else if (weightIn < 100.0)
                                compBTotal += compBWeight3;
                            else if (weightIn < 200.0)
                                compBTotal += compBWeight4;
                            else
                                compBTotal += weightIn * compBWeight5;

                            compCTotal += weightIn * compCWeight;       //calculations for company C shipping cost
                            compCTotal += compCDay;
                            if (milesIn >= 1000.0)
                                compCTotal += compCMile1;
                            else if (milesIn >= 750.0)
                                compCTotal += compCMile2;
                            else if (milesIn >= 500.0)
                                compCTotal += compCMile3;
                            else if (milesIn >= 200.0)
                                compCTotal += compCMile4;
                            else
                                compCTotal += compCMile5;

                            companyAOutLabel.Text = String.Format("${0:0.00}", compATotal);     //formatting and outputting total cost for each company
                            companyBOutLabel.Text = String.Format("${0:0.00}", compBTotal);
                            companyCOutLabel.Text = String.Format("${0:0.00}", compCTotal);

                            if (compATotal < compBTotal && compATotal < compCTotal)             //Evaluating which company has the lowest shipping total
                                bigOutLabel.Text = "The lowest cost company is: A";
                            else if (compBTotal < compATotal && compBTotal < compCTotal)
                                bigOutLabel.Text = "The lowest cost company is: B";
                            else
                                bigOutLabel.Text = "The lowest cost company is: C";             //if the best 2 companies have an equal total it will default to saying company C is the best
                        }
                    }
                    else
                        MessageBox.Show("Invalid delivery days entry");             //error boxes for tryparse of each input
                }
                else
                    MessageBox.Show("Invalid distance entry");
            }
            else
                MessageBox.Show("Invalid package weight entry");
        }
    }
}
