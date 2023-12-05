namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double result = 0;
        string currentNumber = "0";

        private void ButtonNum_Clicked(object sender, EventArgs e)
        {
            int var = ButtonId();
            if (currentNumber == "0")
            {
                currentNumber = var.ToString();
            }
            else
            {
                currentNumber = currentNumber + var.ToString();
            }
            string displayText = display.Text;
            display.Text = currentNumber;
        }

        private int ButtonId()
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
            string displayText = display.Text;
            
        }

    }
}