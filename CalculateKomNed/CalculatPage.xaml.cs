using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CalculateKomNed
{
    /// <summary>
    /// Interaction logic for CalculatPage.xaml
    /// </summary>
    public partial class CalculatPage : Page
    {
        public CalculatPage()
        {
            InitializeComponent();
            List<string> a = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            cmbMounth.ItemsSource = a;
            cmbMounth.SelectedIndex = 0;
        }

        private void btnSpravka_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.consultant.ru/document/cons_doc_LAW_157394/");
        }

        private void btnSchet_Click(object sender, RoutedEventArgs e)
        {
            if (tbKadastr.Text != "" && tbNalog.Text != "")
            {
                double kadastr = double.Parse(tbKadastr.Text);
                double nalog = double.Parse(tbNalog.Text);
                int mouth = 1;
                double itog = 0.0;
                double _itog = 0.0;
                switch (cmbMounth.SelectedIndex)
                {
                    case 0:
                        mouth = 12;
                        break;
                    case 1:
                        mouth = 11;
                        break;
                    case 2:
                        mouth = 10;
                        break;
                    case 3:
                        mouth = 9;
                        break;
                    case 4:
                        mouth = 8;
                        break;
                    case 5:
                        mouth = 7;
                        break;
                    case 6:
                        mouth = 6;
                        break;
                    case 7:
                        mouth = 5;
                        break;
                    case 8:
                        mouth = 4;
                        break;
                    case 9:
                        mouth = 3;
                        break;
                    case 10:
                        mouth = 2;
                        break;
                    case 11:
                        mouth = 1;
                        break;
                }
                itog = ((kadastr * nalog) / 100) / mouth;
                _itog = (kadastr * nalog) / 100;
                MessageBox.Show($"Годовой налог: {_itog.ToString()} рублей.\nМесячный налог: {itog.ToString()} рублей", "Рассчет", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Вы ничего не ввели", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void tbKadastr_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex input = new Regex(@"[0-9\,\.]");
            Match match = input.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void tbNalog_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex input = new Regex(@"[0-9\,\.]");
            Match match = input.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }
    }
}
