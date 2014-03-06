using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Program: Dice Simulator
  Author: Kyle McBride A02609917
  Date: 02/28/2014
  Description: Application that simulates rolling a pair of dice. When the user clicks a button, the application 
               will generate two random numbers, each in the range of 1 through 6, to represent the value of the dice.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***                                  */

namespace Dice_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create variables to carry random numbers
                int leftRand;
                int rightRand;

                //creating randoms
                Random rand = new Random();

                //getting random numbers and assigning them to variables
                leftRand = rand.Next(6) + 1;
                rightRand = rand.Next(6) + 1;

                //hiding the pictures
                leftDie1Pic.Visible = false;
                leftDie2Pic.Visible = false;
                leftDie3Pic.Visible = false;
                leftDie4Pic.Visible = false;
                leftDie5Pic.Visible = false;
                leftDie6Pic.Visible = false;
                rightDie1Pic.Visible = false;
                rightDie2Pic.Visible = false;
                rightDie3Pic.Visible = false;
                rightDie4Pic.Visible = false;
                rightDie5Pic.Visible = false;
                rightDie6Pic.Visible = false;

                //handeling the random numbers
                switch (leftRand)
                {
                    case 1:
                        leftDie1Pic.Visible = true;
                        break;
                    case 2:
                        leftDie2Pic.Visible = true;
                        break;
                    case 3:
                        leftDie3Pic.Visible = true;
                        break;
                    case 4:
                        leftDie4Pic.Visible = true;
                        break;
                    case 5:
                        leftDie5Pic.Visible = true;
                        break;
                    case 6:
                        leftDie6Pic.Visible = true;
                        break;
                }
                switch (rightRand)
                {
                    case 1:
                        rightDie1Pic.Visible = true;
                        break;
                    case 2:
                        rightDie2Pic.Visible = true;
                        break;
                    case 3:
                        rightDie3Pic.Visible = true;
                        break;
                    case 4:
                        rightDie4Pic.Visible = true;
                        break;
                    case 5:
                        rightDie5Pic.Visible = true;
                        break;
                    case 6:
                        rightDie6Pic.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
