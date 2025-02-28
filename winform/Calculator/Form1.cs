using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1: Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean opreatorChangeFlag = false;
        Boolean divideZeroFalg = false;
        double firstOperand = 0;
        double secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Buton_Click(string number)
        {
            if(opreatorChangeFlag == true)
            {
                display.Text = "";
                opreatorChangeFlag = false;
            }

            string strNumber = display.Text += number;
            double doubleNumber = Double.Parse(strNumber);
            display.Text = doubleNumber.ToString();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("0");
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("1");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("2");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("3");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("4");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("5");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("6");
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("7");
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("8");
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            Number_Buton_Click("9");
        }

        private void Save_First_Operand()
        {
            if(divideZeroFalg)
            {
                display.Text = "0";
                divideZeroFalg = false;
            }

            display.Text = Solve_LastPoint(display.Text);

            firstOperand = Double.Parse(display.Text);
            opreatorChangeFlag = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Save_First_Operand();
            currentOperator = Operators.Add;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            Save_First_Operand();
            currentOperator = Operators.Subtract;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Save_First_Operand();
            currentOperator = Operators.Multiply;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Save_First_Operand();
            currentOperator = Operators.Divide;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            display.Text = Solve_LastPoint(display.Text);
            secondOperand = Double.Parse(display.Text);

            switch(currentOperator)
            {
                case Operators.Add:
                    firstOperand += secondOperand;
                    break;

                case Operators.Subtract:
                    firstOperand -= secondOperand;
                    break;

                case Operators.Multiply:
                    firstOperand *= secondOperand;
                    break;

                case Operators.Divide:
                    if(secondOperand == 0)
                    {
                        display.Text = "0으로 나눌 수 없습니다.";
                        divideZeroFalg = true;
                        return;
                    }
                    firstOperand /= secondOperand;
                    break;
            }

            display.Text = firstOperand.ToString();
        }

        private void BtnAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
            opreatorChangeFlag = false;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if(display.Text.Contains("."))  // 이미 소수점이 선언된 경우
            {
                return;
            }
            display.Text += ".";
        }

        private string Solve_LastPoint(string number)
        {
            if(number.Substring(number.Length - 1, 1).Equals("."))
            {
                number += "0";
            }

            return number;
        }
    }
}
