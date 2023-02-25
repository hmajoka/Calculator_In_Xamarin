using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorApp.Views
{
    public partial class AboutPage : ContentPage
    {
        int value1;
        int value2;
        double result;
        string sign;
        string value;
        String Test;
        public AboutPage()
        {
            InitializeComponent();
        }
        
        private void BtnOne_Clicked(object sender, EventArgs e)
        {
            if (LabelResult.Text=="0")
            {
                LabelResult.Text = "1";
            }
            else
            {
                LabelResult.Text += "1";
            }
        }
        private void BtnCommon_Clicked(object sender, EventArgs e)
        {
            var button= sender as Button;
            if (LabelResult.Text=="0")
            {
                LabelResult.Text=button.Text;                                               
            }
            else
            {
                LabelResult.Text += button.Text;
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            LabelResult.Text = "0";
        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            String Number = LabelResult.Text;
            if (Number!="0")
            {
                Number = Number.Remove(Number.Length - 1, 1);
                if (String.IsNullOrEmpty(Number))
                {
                    LabelResult.Text = "0";
                }
                else
                {
                    LabelResult.Text=Number;
                }
            }
        }

        private async void BtnPercentage_Clicked(object sender, EventArgs e)
        {
            try
            {
                String Number = LabelResult.Text;
                if (Number != "0")
                {
                  Decimal percentValue = Convert.ToDecimal(Number);
                  String result = (percentValue / 100).ToString();
                  LabelResult.Text = result;
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void BtnPlus_Clicked(object sender, EventArgs e)
        {
            value1=Convert.ToInt32(LabelResult.Text);
            sign = "+";
            //value=LabelResult.Text + sign;
            LabelResult.Text = "0";
        }

        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(LabelResult.Text);
            sign = "-";
            //value = LabelResult.Text + sign;
            LabelResult.Text = "0";
        }
        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(LabelResult.Text);
            sign = "/";
            //value = LabelResult.Text + sign;
            LabelResult.Text = "0";
        }
        private void BtnMultiplication_Clicked(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(LabelResult.Text);
            sign = "*";
            //value = LabelResult.Text + sign;
            LabelResult.Text = "0";
        }
     
        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            if (value1 != null && sign != null)
            {
                value2 = Convert.ToInt32(LabelResult.Text);
                value = LabelResult.Text;
                if (sign == "+")
                {
                    result = value1 + value2;
                    LabelResult.Text = result.ToString();
                }
                else if (sign == "-")
                {
                    result = value1 - value2;
                    LabelResult.Text = result.ToString();
                }
                else if (sign == "*")
                {
                    result = value1 * value2;
                    LabelResult.Text = result.ToString();
                }
                else if (sign == "/")
                {
                    result = value1 / value2;
                    LabelResult.Text = result.ToString();
                }
            }
        }
    }
}