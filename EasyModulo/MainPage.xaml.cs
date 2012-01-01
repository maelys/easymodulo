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
    }
}