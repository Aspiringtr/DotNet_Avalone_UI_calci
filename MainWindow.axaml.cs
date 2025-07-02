using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            updatecalci();
        }
        private void Divide(object sender, RoutedEventArgs e)
        {
            calci += " / ";
            updatecalci();
        }
        private void Multiply(object sender, RoutedEventArgs e)
        {
            calci += " X ";
            updatecalci();
        }
        private void Subtract(object sender, RoutedEventArgs e)
        {
            calci += " - ";
            updatecalci();
        }
        private void Addition(object sender, RoutedEventArgs e)
        {
            calci += " + ";
            updatecalci();
        }
        private void Seven(object sender, RoutedEventArgs e)
        {
            calci += "7";
            updatecalci();
        }
        private void Eight(object sender, RoutedEventArgs e)
        {
            calci += "8";
            updatecalci();
        }
        private void Nine(object sender, RoutedEventArgs e)
        {
            calci += "9";
            updatecalci();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            ///fuction to calc and update it to Result
            updatecalci();
        }
        private void CE (object sender, RoutedEventArgs e)
        {
            calci = "";
            updatecalci();
        }
        void updatecalci()
        {
            Calci.Text = calci;
        }
        public string calci = "";
    }
}