using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace EasyModulo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
             BigInteger n1;
             BigInteger n2;
            if (number1.Text == "" || number2.Text == "" )
            {
                    result.Text = "Please enter a number and a modulo";
            }else
            {
                try
                {
                    n1 = new BigInteger(number1.Text,10);
                    n2 = new BigInteger(number2.Text,10);
                    result.Text = (n1%n2).ToString();
                }catch (System.Exception excep)
                {
                    result.Text = "Please enter numbers";

                }
            }
        }

        private void equal2_Click(object sender, RoutedEventArgs e)
        {
            BigInteger n3;
            BigInteger power;
            BigInteger n4;

            if (number3.Text == "" || number4.Text == "")
            {
                result2.Text = "Please enter a number and a modulo";
            }
            else
            {
                try
                {
                    n3 = new BigInteger(number3.Text, 10);
                    power = new BigInteger(numberP.Text, 10);
                    n4 = new BigInteger(number4.Text, 10);
                    result2.Text = n3.modPow(power,n4).ToString();
                }
                catch (System.Exception excep)
                {
                    result2.Text = "Please enter numbers";

                }
            }

        }
    }
}