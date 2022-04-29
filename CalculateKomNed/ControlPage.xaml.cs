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

namespace CalculateKomNed
{
    /// <summary>
    /// Interaction logic for ControlPage.xaml
    /// </summary>
    public partial class ControlPage : Page
    {
        public ControlPage()
        {
            InitializeComponent();
        }

        private void btnFiz_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CalculatPage());
        }

        private void btnUr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
