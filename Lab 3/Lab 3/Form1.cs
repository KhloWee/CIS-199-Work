//Lab 3
//CIS 199-02
//Due: 9/20/2020
//Grading ID: K1773
//This is a program that uses a gui to accept user input for the radius of a sphere uses that radius to calculate more properties of that sphere 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(radiusInBox.Text);         //gets radius from text box and converts it to double

            double radiusToDiameter = 2.0 * radius;                 //converts radius to diameter
            double radiusToArea = 4.0 * Math.PI * (Math.Pow(radius, 2.0));      //converts radius to area
            double radiusToVolume = (4.0 * Math.PI * (Math.Pow(radius, 3.0))) / 3.0;        //converts radius to volume

            String diameter = String.Format("{0:0.00}", radiusToDiameter);      //converts double to string and formats it to only have 2 decimal places
            String area = String.Format("{0:0.00}", radiusToArea);
            String volume = String.Format("{0:0.00}", radiusToVolume);

            diameterOutBox.Text = diameter;         //assignes calculated values to gui elements to show user
            areaOutBox.Text = area;
            volumeOutBox.Text = volume;
        }
    }
}
