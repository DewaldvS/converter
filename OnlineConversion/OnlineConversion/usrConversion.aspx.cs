using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineConversion.Classes;

namespace OnlineConversion
{
    public partial class usrConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void KmToMile(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if(isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Distance.ConvertKmToMiles(dblVal);
                    txtResult.Text = "Result: Mil: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }

                
            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        protected void MileToKm(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if (isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Distance.ConvertMilesToKm(dblVal);
                    txtResult.Text = "Result: Km: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }


            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        protected void CeltoFar(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if (isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Temperature.ConvertCelsiusToFahrenheit(dblVal);
                    txtResult.Text = "Result: Fa: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }


            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        protected void FartoCel(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if (isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Temperature.ConvertFahrenheitToCelsius(dblVal);
                    txtResult.Text = "Result: Cel: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }


            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        protected void KgToLbs(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if (isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Weight.ConverKgToLb(dblVal);
                    txtResult.Text = "Result: Lbs: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }


            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        protected void LbsToKg(object sender, EventArgs e)
        {
            // Just take the input from the txtinput and return the result to the output
            try
            {
                double dblVal = 0;
                double dblRetVal = 0;

                if (isValid(txtInput.Text.ToString()))
                {
                    dblVal = Convert.ToDouble(txtInput.Text.ToString());
                    dblRetVal = Weight.ConverLbToKg(dblVal);
                    txtResult.Text = "Result: Kg: " + dblRetVal.ToString("0.0000");
                }
                else
                {
                    //Not a valid input was provided.
                    lblError.Text = "*** " + "Non Valid Input recognised, please try again.";
                }


            }
            catch (Exception ex)
            {
                lblError.Text = "*** " + ex.StackTrace.ToString();
            }

        }

        private bool isValid(string input)
        {
            // Just do a quick eval on user input
            // Check that string is not empty
            if(input != string.Empty)
            {
                return true;
            }
            // Check that string is numeric
            decimal decTestNum = 0;
            bool canConvert = decimal.TryParse(input, out decTestNum);
            if(canConvert)
            {
                return true;
            }

            return false;
        }
    }
}