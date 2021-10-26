//K1773
//Lab 2
//9-13-20
//CIS 199-02
//Pogram that uses a GUI to take price input from users and calcualte tip percentages then outputs them

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Takes price input from the user and generates percentages of the inputed number that are then displayed back to the user when a button is pressed 
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double tipRate15 = 0.15;      //constant for calculating tip % for first box
            const double tipRate18 = 0.18;      //constant for calculating tip % for second box
            const double tipRate20 = 0.20;      //constant for calculating tip % for third box

            string input;
            double salePrice, tip15, tip18, tip20;

            input = salePriceBox.Text;

            salePrice = double.Parse(input);

            tip15 = salePrice * tipRate15;
            output15.Text = tip15.ToString("C");

            tip18 = salePrice * tipRate18;
            output18.Text = tip18.ToString("C");

            tip20 = salePrice * tipRate20;
            output20.Text = tip20.ToString("C");
        }
    }
}
