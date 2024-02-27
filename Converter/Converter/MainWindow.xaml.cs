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
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 1;
        }
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            string from, to;

            if (textBox2.Text == "")
            {
                from = cmb1.SelectedItem.ToString();
            }
            else
            {
                from = textBox2.Text;
            }

            if (textBox3.Text == "")
            {
                to = cmb2.SelectedItem.ToString();
            }
            else
            {
                to = textBox3.Text;
            }

            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта. Перевод невозможен!", "Внимание!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты для перевода!", "Внимание!");
            }

            // вот здесь происходит обработка конечного результата, который вышлядит, как результат запроса в гугле, только в ограниченной области веб-браузера. Всё должно выглядеть круто, только запрос говнится почему-то.
            else
            {
                web.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from.ToString() + " %D0%B2 " + to.ToString());
            }
        }

        //private double ConvertCurrency(double amount, string currency)
        //{
        //    double rate = GetExchangeRate(currency);
        //    return amount * rate;
        //}

        //private double GetExchangeRate(string currency)
        //{
        //    // Здесь можно добавить логику получения актуального курса валют из API или другого источника данных
        //    // В данном примере просто используем фиксированные курсы для демонстрации
        //    switch (currency)
        //    {
        //        case "USD":
        //            return 0.010864;
        //        case "EUR":
        //            return 0.010008;
        //        case "BYN":
        //            return 0.035125;
        //        default:
        //            return 1.0;
        //    }
        //}
    }
}
