//K1773
//Lab 4
//9-27-20
//CIS 199-02
//Gui application that uses if statments to test for qualifying student applications

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        int numAccepted = 0;        //declairing counting numbers
        int numRejected = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            const double gradeLimitHi = 4.0;        //max limit for gpa
            const double gradeLimitLow = 0.0;       //min limit for gpa
            const int testLimitHi = 100;            //max limit for test scores
            const int testLimitLow = 0;             //min limit for test scores

            String gradeString, testString;     //declairing needed variables
            double gradeNum;
            int testNum;

            gradeString = gradeIn.Text;
            testString = testScoreIn.Text;

            if (double.TryParse(gradeString, out gradeNum))    
            {
                if (int.TryParse(testString, out testNum))
                {
                    if (gradeNum >= gradeLimitLow && gradeNum <= gradeLimitHi)      //validating gpa input
                    {
                        if (testNum >= testLimitLow && testNum <= testLimitHi)      //validating test score input
                        {
                            if ((gradeNum >= 3.0 && testNum >= 60) || (testNum >= 80))      //testing if student will be accepted or not
                            {
                                outputLabel.Text = "Accpeted";
                                numAccepted++;
                                acceptNumOut.Text = numAccepted.ToString();
                            }
                            else
                            {
                                outputLabel.Text = "Rejected";
                                numRejected++;
                                rejectNumOut.Text = numRejected.ToString();
                            }
                        }
                        else
                            outputLabel.Text = "Test score must be between 0 - 100";        //error outputs if tryparse or validation fail
                    }
                    else
                        outputLabel.Text = "GPA should be between 0.0 - 4.0";
                }
                else                
                    outputLabel.Text = "Invalid Test Score input";
            }
            else
                outputLabel.Text = "Invalid GPA input";
        }
    }
}
