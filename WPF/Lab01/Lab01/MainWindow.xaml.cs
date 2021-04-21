using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab01
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

        private void confirmClick(object sender, RoutedEventArgs e)
        {
            var result =
            MessageBox.Show($"First Name: {FirstName.Text} \n" + $"Last Name: {LastName.Text} \n" +
            $"" + $"Gender: {Gender.Text} \n" + $"Phone: {Phone.Text} \n" + $"Address: {Address.Text} \n" +
            $"" + $"Email: {Email.Text}",
                "Confirmation", MessageBoxButton.YesNo,
                MessageBoxImage.Information, MessageBoxResult.Yes);
            if (result == MessageBoxResult.Yes)
                MessageBox.Show("Your info has been confirmed!");
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
