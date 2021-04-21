using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inkcanvas
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
        private void ColorClick(object sender, RoutedEventArgs e)
        {
            ink.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString((((RadioButton)sender).Content.ToString()));
        }

        private void ModeClick(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = (InkCanvasEditingMode)Enum.Parse(typeof(InkCanvasEditingMode), ((RadioButton)sender).Content.ToString());
        }
        private void BrushClick(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Small":
                    ink.DefaultDrawingAttributes.Width = 3;
                    ink.DefaultDrawingAttributes.Height = 3;
                    break;
                case "Large":
                    ink.DefaultDrawingAttributes.Width = 19;
                    ink.DefaultDrawingAttributes.Height = 19;
                    break;
                default:
                    ink.DefaultDrawingAttributes.Width = 13;
                    ink.DefaultDrawingAttributes.Height = 13;
                    break;
            }
        }
        private void NewClick(object sender, RoutedEventArgs e)
        {
            ink.Strokes.Clear();
        }
        private void SaveClick(object sender, RoutedEventArgs e)
        {   
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.ShowDialog();
                FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                ink.Strokes.Save(stream);
                stream.Close();
            }
            catch (FileNotFoundException exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        private void LoadClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "*.ink|All files (*.*)|*.*";
                if (openDialog.ShowDialog() == true)
                {
                    FileStream stream = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    StrokeCollection loadedStrokes = new StrokeCollection(stream);
                    ink.Strokes = loadedStrokes;
                    stream.Close();
                }
            }
            catch (FileNotFoundException exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        private void ShapingClick(object sender, RoutedEventArgs e)
        {
            ink.DefaultDrawingAttributes.StylusTip = (StylusTip)Enum.Parse(typeof(StylusTip), ((RadioButton)sender).Content.ToString());
        }
        private void CopyClick(object sender, RoutedEventArgs e)
        {
            ink.CopySelection();
        }
        private void CutClick(object sender, RoutedEventArgs e)
        {
            ink.CutSelection();
        }
        private void PasteClick(object sender, RoutedEventArgs e)
        {
            ink.Paste();
        }
    }
}
