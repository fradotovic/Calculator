using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.labelResult.Text = "";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            
            
            
              this.labelResult.Text = this.labelResult.Text + "0";
            
                

            
               
            
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
          
           
            this.labelResult.Text = this.labelResult.Text + "1";
            
        }

        private void butttonTwo_Click(object sender, EventArgs e)
        {
            
            this.labelResult.Text = this.labelResult.Text + "2"; 
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
           
            this.labelResult.Text = this.labelResult.Text + "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
          
            this.labelResult.Text = this.labelResult.Text + "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            
            this.labelResult.Text = this.labelResult.Text + "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
           
            this.labelResult.Text = this.labelResult.Text + "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.labelResult.Text = this.labelResult.Text + "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
          
            this.labelResult.Text = this.labelResult.Text + "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            
           
            this.labelResult.Text = this.labelResult.Text + "9";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            
            this.labelResult.Text = this.labelResult.Text + ",";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if(this.labelResult.Text != "")
            {
                this.firstNumLabel.Text = this.labelResult.Text;
            }
            

            this.operatorLabel.Text = "+";

            this.labelResult.Text = "";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            
            if (this.labelResult.Text != "")
            {
                this.firstNumLabel.Text = this.labelResult.Text;
            }
            this.operatorLabel.Text = "-";

            this.labelResult.Text = "";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "")
            {
                this.firstNumLabel.Text = this.labelResult.Text;
            }
            
            this.operatorLabel.Text = "*";
            this.labelResult.Text = "";    
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "")
            {
                this.firstNumLabel.Text = this.labelResult.Text;
            }
            
            this.operatorLabel.Text = "/";
            this.labelResult.Text = "";
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text != "")
            {
                this.firstNumLabel.Text = this.labelResult.Text;
            }
            this.operatorLabel.Text = "%";
            this.labelResult.Text = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double rezultat = 0;

            double.TryParse(firstNumLabel.Text, out num1);
             double.TryParse(labelResult.Text, out num2);

         
            switch (operatorLabel.Text)
            {
                
                case "+":
                    {
                       
                        rezultat = num1 + num2;
                      
                        //firstNumLabel.Text = rezultat.ToString();
                        //operatorLabel.Text = "+";
                        break;
                    }
                case "-":
                    {
                        rezultat = num1 - num2;
                        
                        //firstNumLabel.Text = rezultat.ToString();
                        //operatorLabel.Text = "-";
                        break;
                    }
                case "*":
                    {
                        rezultat = num1 * num2;
                        
                        //firstNumLabel.Text = rezultat.ToString();
                        //operatorLabel.Text = "*";
                        break;
                    }
                case "/":
                    {
                        rezultat = num1/num2;
                        
                        //firstNumLabel.Text = rezultat.ToString();
                        //operatorLabel.Text = "/";
                        break;
                    }
            }
            this.labelResult.Text = rezultat.ToString();
            this.firstNumLabel.Text = "";
            this.operatorLabel.Text = "";
        }
    }
}
