//K1773
//Program 3
//11-5-20
//CIS 199-02
//Program for calculating Total Cost of an order including taxes and a discount

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int[] productNums = {1001, 1002, 1003, 1004, 1005, 1006, 1007};             //array for valid product numbers
            int[] discountItemNum = {4, 9, 19};                                         //array for the max units each tier of discounts allow
            double[] discount = {0.0, 0.05, 0.10, 0.15};                                //array for the percent discount given for each tier of discounts
            double[] stateTax = {.06, .0717, .0700, .0874};                             //array for the percent of tax each state has alligned with combo box
            double[] productCost = {7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58};        //array for the cost of each product alligned with producNums array
            int productInput, quantityInput;                                            //integers for user input
            double orderTax, unitCost, discountCost, totalCost, totalTax;               //doubles used for calculating cost
            double initCost = 0.0;                                                      //another double used for cost
            int index = 0, count = 0;                                                   //integers used in iterating loops
            bool discFound = false;                                                     //bool used for finding discount

            if (stateComboBox.SelectedIndex >= 0)       //checks to see if state is selected in combo box
            {
                if (int.TryParse(productNumInBox.Text, out productInput))       //tries to parse given product number
                {
                    if(int.TryParse(quantityInBox.Text, out quantityInput) && quantityInput >= 0)       //tries to parse given quantity and checks to see if it's a positive number
                    {
                        if(productInput >= productNums[0] && productInput <= productNums[productNums.Length - 1]){  //checks to see if the given product number is valid
                            orderTax = stateTax[stateComboBox.SelectedIndex];                   //assigns tax based off combo box input

                            foreach(int productNum in productNums){         //for each loop that compaires the given product number to productNums array and assigns the unit cost basted off productCost array
                                if(productInput == productNum){
                                    unitCost = productCost[count];
                                    initCost = unitCost * quantityInput;
                                    initialCostOutBox.Text = initCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));       //outputting the cost before tax and discounts to GUI
                                }
                                count++;
                            }

                            do
                            {

                                if(quantityInput <= discountItemNum[index])     //do while loop that tests if given quantity is lower or equal to the max of the ranges, listed in the discountgItemNum array
                                {
                                    discountCost = initCost - (initCost * discount[index]);     //calculating discount
                                    discountOutBox.Text = discountCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));  //outputing discount to gui

                                    totalTax = discountCost * orderTax;     //calculating tax
                                    taxOutBox.Text = totalTax.ToString("C", CultureInfo.GetCultureInfo("en-US"));       //outputting tax to gui

                                    totalCost = discountCost + totalTax;            //calculating total cost
                                    totalOutBox.Text = totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));    //outputting total cost to gui

                                    discFound = true;   //setting bool to true to end loop
                                }
                                index++;

                            } while (!discFound && index < discountItemNum.Length);         //keeping the loop running until there are no more ranges to evaluate or a discount is found

                            if (!discFound)     //if the loop finishes and no discount has been found then it's assumed that there are more than 19 items so the max discount is applied
                            {
                                discountCost = initCost - (initCost * discount[discount.Length - 1]);       //calculating discount
                                discountOutBox.Text = discountCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));  //outputing discount to gui

                                totalTax = discountCost * orderTax;         //calculating tax
                                taxOutBox.Text = totalTax.ToString("C", CultureInfo.GetCultureInfo("en-US"));       //outputting tax to gui

                                totalCost = discountCost + totalTax;        //calculating total cost
                                totalOutBox.Text = totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));        //outputting total cost to gui
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error!! Please input product number between 1001 and 1007");       //error message for invalid product number input
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!! Please input positive integer for quantity");          //error message for invalid quantity input
                    }
                }
                else
                {
                    MessageBox.Show("Error!! please input integer for product number");             //errop message for unparsable product number
                }
            }
            else
            {
                MessageBox.Show("Error!! please select a value within the state drop down box");    //error message for unselected state in combo box
            }
        }
    }
}
