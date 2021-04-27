using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        string operation;
        double firstNumber;
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
        }

        private void plus_minus_Click(object sender, RoutedEventArgs e)
        {
            double outValue = double.TryParse(result.Text, out outValue) ? outValue * -1 : 0;
            if (outValue == 0)
                result.Text = "ERROR";
            else
                result.Text = outValue.ToString();
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber;
            double Result = 0;

            secondNumber = Convert.ToDouble(result.Text);

            switch (operation)
            {
                case "+":
                    Result = (firstNumber + secondNumber);
                    result.Text = $"{firstNumber} {operation} {secondNumber} = {Result}";

                    break;
                case "-":
                    Result = (firstNumber - secondNumber);
                    result.Text = $"{firstNumber} {operation} {secondNumber} = {Result}";

                    break;
                case "*":
                    Result = (firstNumber * secondNumber);
                    result.Text = $"{firstNumber} {operation} {secondNumber} = {Result}";

                    break;
                case "/":
                    if (secondNumber == 0)
                        result.Text = "Cannot divide by zero";
                    else
                    {
                        Result = (firstNumber / secondNumber);
                        result.Text = $"{firstNumber} {operation} {secondNumber} = {Result}";
                    }
                    break;
                case "%":
                    Result = (firstNumber % secondNumber);
                    result.Text = $"{firstNumber} {operation} {secondNumber} = {Result}";
                    break;
            }
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            result.Text += ((sender as Button).Content.ToString());
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            result.Text += ((sender as Button).Content.ToString());
        }

        private void operator_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = double.TryParse(result.Text, out firstNumber) ? firstNumber : 0;
            if(((sender as Button).Content.ToString()) == "x")
                operation = "*";
            operation = (sender as Button).Content.ToString();
            result.Text = "";
        }
    }
}