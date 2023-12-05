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

        private void Button_Clicked(object sender, EventArgs e)
        {
            string displayText = display.Text;
            if (currentNumber == "0") {
                currentNumber = "7";
            }
            else {
                currentNumber = currentNumber + "7";
            }
            display.Text = currentNumber;
        }

        private void ButtonOps_Clicked(object sender, EventArgs e)
        {
            string displayText = display.Text;
            
        }

    }
}