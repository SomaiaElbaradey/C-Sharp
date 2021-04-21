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

namespace bonus
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
        private void SetClick(object sender, RoutedEventArgs e)
        {
            text.Text = "Replace default text with initial text value";
        }
        private void SelectClick(object sender, RoutedEventArgs e)
        {
            text.SelectAll();
            text.Focus();
        }
        private void ClearClick(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }
        private void PrependClick(object sender, RoutedEventArgs e)
        {
            var writtenText = text.Text;
            text.Text = $"***Prepended Text*** {writtenText}";
        }
        private void InsertClick(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text.Insert(text.CaretIndex, "***Inserted Text***");
        }
        private void AppendClick(object sender, RoutedEventArgs e)
        {
            text.AppendText("**Appended Text**");
        }
        private void CutClick(object sender, RoutedEventArgs e)
        {
            if (text.SelectionLength == 0)
                MessageBox.Show("Cut text first", "Cut");
            else
            {
                if (MessageBox.Show($"Cut: '{text.SelectedText}'?", "cut", MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                    text.Cut();
            }
        }
        private void CopyClick(object sender, RoutedEventArgs e)
        {
            if (text.SelectionLength == 0)
                MessageBox.Show("Copy text first", "Copy");
            else
            {
                if (MessageBox.Show($"Copy: '{text.SelectedText}'?", "Copy", MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                    text.Copy();
            }
        }
        private void PasteClick(object sender, RoutedEventArgs e)
        {
            text.Paste();
        }
        private void UndoClick(object sender, RoutedEventArgs e)
        {
            text.Undo();
        }
        private void editRead(object sender, RoutedEventArgs e)
        {
            switch ((((RadioButton)sender).Content).ToString())
            {
                case "Readable":
                    text.IsReadOnly = true;
                    break;
                case "Editable":
                    text.IsReadOnly = false;
                    text.Focus();
                    break;
            }
        }
            private void positionClick(object sender, RoutedEventArgs e)
        {
            text.TextAlignment = (TextAlignment)Enum.Parse(typeof(TextAlignment), ((RadioButton)sender).Content.ToString());
        }
    }
}