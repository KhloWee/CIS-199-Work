//K1773
//Program 1 
//9-22-20
//CIS 199-02
//Program that calculates the price for a customer to have wood flooring installed

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double feetToYard = 9.0;          //Constant for converting feet to yards
            const double wastePercent = 1.1;        //constant for adding 10% of The area of the floor for waste
            const double underlayCost = 4.25;       //Constant for the cost of 1 yard of undelayment
            const double laborCost = 3.25;          //Constant for the labor cost per yard
            const double firstRoomCost = 50.0;      //Constant for extra cost for the first room of a job
            
            double widthIn, lengthIn, priceIn, yardsOut, hardwoodOut,
                underlayOut, laborOut, totalOut, roomArea;

            int underlayIn, firstRoomIn;

            widthIn = double.Parse(widthInput.Text);
            lengthIn = double.Parse(lengthInput.Text);
            priceIn = double.Parse(priceInput.Text);
            underlayIn = int.Parse(underlayInput.Text);
            firstRoomIn = int.Parse(firstRoomInput.Text);

            roomArea = (widthIn * lengthIn) / feetToYard;
            yardsOut = roomArea * wastePercent;

            hardwoodOut = yardsOut * priceIn;

            if (firstRoomIn == 1){
                laborOut = (roomArea * laborCost) + firstRoomCost;
            }
            else{
                laborOut = roomArea * laborCost;
            }

            if (underlayIn == 1)
            {
                underlayOut = roomArea * underlayCost;
                totalOut = laborOut + underlayOut + hardwoodOut;
            }
            else
            {
                underlayOut = 0.0;
                totalOut = laborOut + hardwoodOut;
            }

            yardOutBox.Text = String.Format("{0:0.0yd}", yardsOut);
            hardwoodOutBox.Text = String.Format("{0:$0.00}", hardwoodOut);
            underlayOutBox.Text = String.Format("{0:$0.00}", underlayOut);
            laborOutBox.Text = String.Format("{0:$0.00}", laborOut);
            totalOutBox.Text = String.Format("{0:$0.00}", totalOut);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
