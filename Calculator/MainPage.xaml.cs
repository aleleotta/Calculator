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

        private void ButtonNum_Clicked(object sender, EventArgs e)
        {
            int var = ButtonNumId();
            if (operation == "0")
            {
                operation = var.ToString();
            }
            else
            {
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
            if (buttonAdd.IsPressed)
            {
                operation = operation + buttonAdd.Text;
            }
            else if (buttonSub.IsPressed)
            {
                operation = operation + buttonSub.Text;
            }
            else if (buttonMult.IsPressed)
            {
                operation = operation + buttonMult.Text;
            }
            else if (buttonDiv.IsPressed)
            {
                operation = operation + buttonDiv.Text;
            }
            else if (buttonDecimal.IsPressed)
            {
                operation = operation + buttonDecimal.Text;
            }
            else if (buttonEqual.IsPressed)
            {
                operation = operation + buttonEqual.Text;
            }
            string displayText = display.Text;
            display.Text = operation;
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
            else if (buttonDecimal.IsPressed)
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