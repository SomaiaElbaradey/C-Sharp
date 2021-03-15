using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        char operation = ' ' ;
        string operand1="", operand2="";
        int first = 0;
        int opFlag = 0;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OpClicked(object sender, RoutedEventArgs e)
        {
            Button optrObj = (Button)sender;
            string optr = optrObj.Content.ToString();
            
           
            if (operation == ' ' && operand1?.Length != 0 && opFlag == 0 ) { 
                operation = char.Parse(optr);
                Screen.Text += operation;
                opFlag = 1;
            }
          

        }

        private void NumClicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (first == 0)
            {
                first = 1;
                operand1 = button.Content.ToString();
            }
            else
            {
                operand2 = button.Content.ToString();
            }
            
            Screen.Text += button.Content.ToString();
        }

        private void clearClicked(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
            //Clear Resources
            operation = ' ';
            operand1 = operand2 = "";
            first = 0;
            opFlag = 0;
        }

        private void EqualClicked(object sender, RoutedEventArgs e)
        {
    
            double num1, num2, result;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                Screen.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                Screen.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                Screen.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Screen.Text = result.ToString();
                }
                else
                {
                    Screen.Text = "DIV/Zero!";
                }

            }
            //Clear Resources
            operation = ' ';
            operand1 = operand2 = "";
            first = 0;
            opFlag = 0;

        }
    }
}
