namespace Assignment4._1._2
{
    public partial class Calculator_Form : Form, ICalculator
    {
        public double firstNumber = 0;
        public string operation;
        public Calculator_Form()
        {
            InitializeComponent();
        }
        public void Add()
        {
            firstNumber = Convert.ToDouble(ResultBox_TextBox.Text);
            ResultBox_TextBox.Text = "";
            operation = "+";
        }
        public void Subtract()
        {
            firstNumber = Convert.ToDouble(ResultBox_TextBox.Text);
            ResultBox_TextBox.Text = "";
            operation = "-";
        }
        public void Multiply()
        {
            firstNumber = Convert.ToDouble(ResultBox_TextBox.Text);
            ResultBox_TextBox.Text = "";
            operation = "*";
        }
        public void Divide()
        {
            firstNumber = Convert.ToDouble(ResultBox_TextBox.Text);
            ResultBox_TextBox.Text = "";
            operation = "/";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "1";
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "9";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + "0";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = "";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (ResultBox_TextBox.Text == "0" && ResultBox_TextBox.Text != null)
            {
                ResultBox_TextBox.Text = "0";
            }
            else
            {
                ResultBox_TextBox.Text = ResultBox_TextBox.Text + ".";
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(ResultBox_TextBox.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    ResultBox_TextBox.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    ResultBox_TextBox.Text = result.ToString();
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    ResultBox_TextBox.Text = result.ToString();
                    break;
                case "/":
                    if (secondNumber > 0) 
                    {
                        result = firstNumber / secondNumber;
                        ResultBox_TextBox.Text = result.ToString();
                    }
                    else
                    {
                        ResultBox_TextBox.Text = "Error: You can't divide by Zero.";
                    }
                    break;
            }
        }
    }
}
