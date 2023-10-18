using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
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

        private void ButtonNumberClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            progressTxtBlock.Text += button.Content;
        }

        private void CEButton(object sender, RoutedEventArgs e)
        {
            resultTxtBlock.Text = "0";
        }

        private void CButton(object sender, RoutedEventArgs e)
        {
            progressTxtBlock.Text = string.Empty;
            resultTxtBlock.Text = "0";
        }

        private void DELButton(object sender, RoutedEventArgs e)
        {
            try
            {
                progressTxtBlock.Text = progressTxtBlock.Text.Remove(progressTxtBlock.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void EqualsButton(object sender, RoutedEventArgs e)
        {
            try
            {
                resultTxtBlock.Text = new DataTable().Compute(progressTxtBlock.Text, "").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное выражение!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                progressTxtBlock.Text = string.Empty;
            }
        }

        private void OperationButton(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            progressTxtBlock.Text += button.Content;
        }
    }
}