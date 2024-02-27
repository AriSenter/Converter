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

        private void Kurs(object sender, TextChangedEventArgs e)
        {
            if (txtAmount.Text.Length >= 1)
            {
                double amount = Convert.ToDouble(txtAmount.Text);
                usd.Content = amount * 0.010864;
                eur.Content = amount * 0.010008;
                cny.Content = amount * 0.078519;
                gbp.Content = amount * 0.008566;
            } 
        }
    }
}
