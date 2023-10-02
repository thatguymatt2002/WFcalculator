namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string opr = "Start";
        double runningTotal = 0, tempHolder = 0;
        bool equalsClicked = false, firstNum = true;

        private void btnZero_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 0;
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 1;
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 2;
            
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 3;
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 4;
            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 5;
            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 6;
            
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 7;
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 8;
            
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            restartCalc();
            txtMain.Text += 9;
            
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtMain.Text.Contains("."))
            {
                txtMain.Text += ".";
            }
        }

        private void btnClrAll_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
            txtSecondary.Clear();
        }

        private void btnClrEntry_Click(object sender, EventArgs e)
        {
            if (equalsClicked != true)
            {
                txtMain.Clear();
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            continueCalc();
            txtSecondary.Text += txtMain.Text + " + ";
            opr = "+";
            operation();
            txtMain.Clear();
            firstNum = false;
            //txtMain.Text = Convert.ToString(runningTotal);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            continueCalc();

            if (firstNum)
            {
                runningTotal = Convert.ToDouble(txtMain.Text);
            }

            else
            {
                operation();
            }

            opr = "-";
            txtSecondary.Text += txtMain.Text + " - ";
            txtMain.Clear();
            firstNum = false;
            //txtMain.Text = Convert.ToString(runningTotal);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            continueCalc();

            if (firstNum)
            {
                runningTotal += Convert.ToDouble(txtMain.Text);
            }

            else
            {
                operation();
            }

            txtSecondary.Text += txtMain.Text + " × ";

            opr = "*";
            txtMain.Clear();
            firstNum = false;
            //txtMain.Text = Convert.ToString(runningTotal);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            continueCalc();
            txtSecondary.Text += txtMain.Text + " ÷ ";

            if (firstNum)
            {
                runningTotal += Convert.ToDouble(txtMain.Text);
            }

            else
            {
                operation();
            }

            opr = "/";
            txtMain.Clear();
            firstNum = false;
            //txtMain.Text = Convert.ToString(runningTotal);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operation();
            txtSecondary.Text += txtMain.Text + " = ";
            txtMain.Text = runningTotal.ToString();
            runningTotal = 0;
            equalsClicked = true;
            opr = "Start";
        }

        private void restartCalc()
        {
            if (equalsClicked == true)
            {
                txtMain.Clear();
                txtSecondary.Clear();
                equalsClicked = false;
                firstNum = true;
                return;
            }

            else
            {
                return;
            }
        }

        private void continueCalc()
        {
            if (equalsClicked == true)
            {
                txtSecondary.Clear();
                equalsClicked = false;
                firstNum = true;
                return;
            }

            else
            {
                return;
            }
        }

        private void operation()
        {
            switch (opr)
            {
                case "+":
                    runningTotal += Convert.ToDouble(txtMain.Text);
                    firstNum = false;
                    break;

                case "-":
                    runningTotal -= Convert.ToDouble(txtMain.Text);
                    break;

                case "*":
                    runningTotal *= Convert.ToDouble(txtMain.Text);
                    break;

                case "/":
                    runningTotal /= Convert.ToDouble(txtMain.Text);
                    break;

                case "Start":
                    break;
            }
        }

    }
}