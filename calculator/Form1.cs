namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string opr = "Start", memoryValue = "0";
        private double runningTotal;
        private bool equalsClicked, firstNum = true;

        private void digitClick(object sender, EventArgs e)
        {
            restartCalc();
            if (String.IsNullOrEmpty(txtMain.Text) || Convert.ToDouble(txtMain.Text) == 0)
            {
                txtMain.Clear();
            }
            txtMain.Text += (sender as Button).Text;
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
            clearMain();
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

        private void clearMain()
        {
            txtMain.Clear();
            txtMain.Text += 0;
        }

        private void btnBckSpc_Click(object sender, EventArgs e)
        {
            txtMain.Text = txtMain.Text.Remove(txtMain.Text.Length - 1);

            if (String.IsNullOrEmpty(txtMain.Text))
            {
                txtMain.Text += 0;
            }
        }

        private void memoryStore()
        {
            memoryValue = txtMain.Text;
        }

        private void btnMmryStr_Click(object sender, EventArgs e)
        {
            memoryStore();
        }

        private void memoryClear()
        {
            memoryValue = "0";
        }

        private void btnMmryClr_Click(object sender, EventArgs e)
        {
            memoryClear();
        }

        private void memoryRecall()
        {
            txtMain.Text = memoryValue;
        }

        private void btnMmryRcll_Click(object sender, EventArgs e)
        {
            memoryRecall();
        }

        private void memoryAdd()
        {
            memoryValue = Convert.ToString(Convert.ToDouble(memoryValue) + Convert.ToDouble(txtMain.Text));
        }

        private void memorySubtract()
        {
            memoryValue = Convert.ToString(Convert.ToDouble(memoryValue) - Convert.ToDouble(txtMain.Text));
        }

        private void btnMmryAdd_Click(object sender, EventArgs e)
        {
            memoryAdd();
        }

        private void btnMmrySub_Click(object sender, EventArgs e)
        {

            memorySubtract();
        }
    }
}