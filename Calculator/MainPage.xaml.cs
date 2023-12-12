namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double result = 0;
        string operation = "0";
        double currentNumber = 0;

        private void ButtonNum_Clicked(object sender, EventArgs e)
        {
            int var = ButtonNumId();
            if (currentNumber == 0)
            {
                currentNumber = var;
                if (operation == "0")
                {
                    operation = var.ToString();
                }
                else {
                    operation = operation + var.ToString();
                }
            }
            else
            {
                string strCurrentNumber = currentNumber.ToString() + var.ToString();
                double.TryParse(strCurrentNumber, out currentNumber);
                operation = operation + var.ToString();
            }
            string displayText = display.Text;
            display.Text = operation;
        }

        private int ButtonNumId()
        {
            int var = 0;
            if (button1.IsPressed) {
                var = 1;
            }
            else if (button2.IsPressed) {
                var = 2;
            }
            else if (button3.IsPressed) {
                var = 3;
            }
            else if (button4.IsPressed) {
                var = 4;
            }
            else if (button5.IsPressed) {
                var = 5;
            }
            else if (button6.IsPressed) {
                var = 6;
            }
            else if (button7.IsPressed) {
                var = 7;
            }
            else if (button8.IsPressed) {
                var = 8;
            }
            else if (button9.IsPressed) {
                var = 9;
            }
            return var;
        }

        private void ButtonOps_Clicked(object sender, EventArgs e)
        {
            int var = ButtonOpsId();
            if (var == 1 && !(display.Text.Equals("0") || display.Text[^1] == ('+'))) //Addition
            {
                result = result + currentNumber;
                operation = operation + buttonAdd.Text;
                currentNumber = 0;
            }
            else if (var == 2 && !(display.Text.Equals("0") || display.Text[^1] == ('-'))) //Subtraction
            {
                result = result - currentNumber;
                operation = operation + buttonSub.Text;
                currentNumber = 0;
            }
            else if (var == 3 && !(display.Text.Equals("0") || display.Text[^1] == ('X'))) //Multiplication
            {
                result = result * currentNumber;
                operation = operation + buttonMult.Text;
                currentNumber = 0;
            }
            else if (var == 4 && !(display.Text.Equals("0") || display.Text[^1] == ('/'))) //Division
            {
                result = result / currentNumber;
                operation = operation + buttonDiv.Text;
                currentNumber = 0;
            }
            else if (var == 5) //Reset *Will be different
            {
                result = 0;
                operation = "0";
                currentNumber = 0;
                display.Text = "0";
            }
            else if (var == 6) //Equal *Will be different
            {
                LocateOperand(); //Calculates final number.
                operation = result.ToString();
            }
            string displayText = display.Text;
            display.Text = operation;
        }

        private void LocateOperand() {
            char operand = 't';
            string finalNum = "";
            for (int i = operation.Length-1; operand != '+' && operand != '-' && operand != '*' && operand != '/'; i--) {
                char pos = operation[i];
                if (pos == '+') { operand = pos; }
                else if (pos == '-') { operand = pos; }
                else if (pos == '*') { operand = pos; }
                else if (pos == '/') { operand = pos; }
                else { finalNum = pos + finalNum; }
            }
            if (operand == '+') {
                double.TryParse(finalNum, out double num);
                result = result + num;
            }
            if (operand == '-') {
                double.TryParse(finalNum, out double num);
                result = result - num;
            }
            if (operand == '*') {
                double.TryParse(finalNum, out double num);
                result = result * num;
            }
            if (operand == '/') {
                double.TryParse(finalNum, out double num);
                result = result / num;
            }
        }

        private int ButtonOpsId()
        {
            int var = 0;
            if (buttonAdd.IsPressed)
            {
                var = 1;
            }
            else if (buttonSub.IsPressed)
            {
                var = 2;
            }
            else if (buttonMult.IsPressed)
            {
                var = 3;
            }
            else if (buttonDiv.IsPressed)
            {
                var = 4;
            }
            else if (buttonAC.IsPressed)
            {
                var = 5;
            }
            else if (buttonEqual.IsPressed)
            {
                var = 6;
            }
            return var;
        }

    }
}