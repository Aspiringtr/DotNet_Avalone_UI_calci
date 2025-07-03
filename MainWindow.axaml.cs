using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Data;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
        private void Four(object sender, RoutedEventArgs e)
        {
            calci += "4";
            updatecalci();
        }
        private void Five(object sender, RoutedEventArgs e)
        {
            calci += "5";
            updatecalci();
        }
        private void Six(object sender, RoutedEventArgs e)
        {
            calci += "6";
            updatecalci();
        }
        private void One(object sender, RoutedEventArgs e)
        {
            calci += "1";
            updatecalci();
        }
        private void Two(object sender, RoutedEventArgs e)
        {
            calci += "2";
            updatecalci();
        }
        private void Three(object sender, RoutedEventArgs e)
        {
            calci += "3";
            updatecalci();
        }
        private void Zero(object sender, RoutedEventArgs e)
        {
            calci += "0";
            updatecalci();
        }
        private void Dot(object sender, RoutedEventArgs e)
        {
            calci += ".";
            updatecalci();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(calci.Replace("X", "*"), "");
                Result.Content = result;
            }
            catch
            {
                Result.Content = "Error";
            }
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