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

namespace Converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            string currency = cmbCurrency.Text;
            double result = ConvertCurrency(amount, currency);
            txtResult.Text = $"Converted amount: {result}";
        }

        private double ConvertCurrency(double amount, string currency)
        {
            double rate = GetExchangeRate(currency);
            return amount * rate;
        }

        private double GetExchangeRate(string currency)
        {
            // Здесь можно добавить логику получения актуального курса валют из API или другого источника данных
            // В данном примере просто используем фиксированные курсы для демонстрации
            switch (currency)
            {
                case "USD":
                    return 0.010864;
                case "EUR":
                    return 0.010008;
                case "BYN":
                    return 0.035125;
                default:
                    return 1.0;
            }
        }
    }
}
