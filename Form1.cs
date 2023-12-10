namespace CS311_FinalProject_PV
{
    public partial class UnitConverter : Form
    {
        double input;

        public UnitConverter()
        {
            InitializeComponent();
        }

        //accepts the meters as input and converts to feet using this formula
        public double metersToFeet(double meters)
        {
            double result;

            result = meters * 3.28084;
            return result;
        }//end metersToFeet

        //accepts the feet as input and converts to meters using this formula
        public double feetToMeters(double feet)
        {
            double result;

            result = feet * 0.3048;
            return result;
        }//end feetToMeters

        //accepts the km as input and converts to miles using this formula
        public double kmToMiles(double km)
        {
            double result;

            result = km * 0.621371;
            return result;
        }//end kmToMiles

        //accepts the miles as input and converts to km using this formula
        public double milesToKm(double miles)
        {
            double result;

            result = miles * 1.60934;
            return result;
        }//end milesToKm

        //accepts the celsius as input and converts to fahrenheit using this formula
        public double celsiusToFahrenheit(double celsius)
        {
            double result;

            result = (celsius * ((double)9 / (double)5)) + 32; //casting needed or result is 0
            return result;
        }//end celsiusToFahrenheit

        //accepts the fahrenheit as input and converts to celsius using this formula
        public double fahrenheitToCelsius(double fahrenheit)
        {
            double result;

            result = (fahrenheit - 32) * ((double)5 / (double)9); //casting needed or result is 0
            return result;
        }//end fahrenheitToCelsius

        //accepts the kilograms as input and converts to pounds using this formula
        public double kilogramsToPounds(double kilograms)
        {
            double result;

            result = kilograms * 2.20462;
            return result;
        }//end kilogramsToPounds

        //accepts the pounds as input and converts to kilograms using this formula
        public double poundsToKilograms(double pounds)
        {
            double result;

            result = pounds * 0.453592;
            return result;
        }//end poundsToKilograms

        //accepts the grams as input and converts to ounces using this formula
        public double gramsToOunces(double grams)
        {
            double result;

            result = grams * 0.035274;
            return result;
        }//end gramsToOunces

        //accepts the ounces as input and converts to grams using this formula
        public double ouncesToGrams(double ounces)
        {
            double result;

            result = ounces * 28.3495;
            return result;
        }//end ouncesToGrams

        //When the convert button is pressed, this method detects which radio buttons are checked and runs one of the 10 conversion methods above based on that
        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (txtInput.Text != "") //first checks to make sure text is entered in the box
            {
                input = double.Parse(txtInput.Text); //input saved as a double

                //if statements go through every valid combo of radio buttons and run the corresponding conversion method
                if (rdoMetersOG.Checked && rdoFeetNew.Checked) txtOutput.Text = metersToFeet(input).ToString() + " ft";
                else if (rdoFeetOG.Checked && rdoMetersNew.Checked) txtOutput.Text = feetToMeters(input).ToString() + " m";
                else if (rdoKilometersOG.Checked && rdoMilesNew.Checked) txtOutput.Text = kmToMiles(input).ToString() + " mi";
                else if (rdoMilesOG.Checked && rdoKilometersNew.Checked) txtOutput.Text = milesToKm(input).ToString() + " km";
                else if (rdoCelsiusOG.Checked && rdoFahrenheitNew.Checked) txtOutput.Text = celsiusToFahrenheit(input).ToString() + "°F";
                else if (rdoFahrenheitOG.Checked && rdoCelsiusNew.Checked) txtOutput.Text = fahrenheitToCelsius(input).ToString() + "°C";
                else if (rdoKilogramsOG.Checked && rdoPoundsNew.Checked) txtOutput.Text = kilogramsToPounds(input).ToString() + " lb";
                else if (rdoPoundsOG.Checked && rdoKilogramsNew.Checked) txtOutput.Text = poundsToKilograms(input).ToString() + " kg";
                else if (rdoGramsOG.Checked && rdoOuncesNew.Checked) txtOutput.Text = gramsToOunces(input).ToString() + " oz";
                else if (rdoOuncesOG.Checked && rdoGramsNew.Checked) txtOutput.Text = ouncesToGrams(input).ToString() + " g";
                else txtOutput.Text = "Please select a valid conversion"; //if a valid combo of radio buttons aren't selected this message is displayed
            }
            else txtOutput.Text = "Please enter input text"; //if no text entered this message is displayed in the output textbox

        }//end btnConvert_Click

    }//end form

}//end namespace