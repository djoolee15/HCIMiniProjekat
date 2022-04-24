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

namespace MiniProjekatHCI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbInterval.Visibility = Visibility.Hidden;
            lab_int.Visibility = Visibility.Hidden;

        }

        public static string odabir_prikaza;
        public static string odabir_intervala;
        public static string odabir_sadrzaja;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (odabir_prikaza == "Tabelarni Prikaz")
            {
                var s = new MiniProjekatHCI.Prikazi.TabelarniPrikaz();
                s.Show();
            }
            else if (odabir_prikaza == "Grafikon Prikaz")
            {
                var s = new MiniProjekatHCI.Prikazi.Grafikon();
                s.Show();
            }
            else
            {
                var s = new MiniProjekatHCI.Prikazi.LinijskiGrafikon();
                s.Show();
            }
        }

        private void cmbPrikaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabir_prikaza = cmbPrikaz.SelectedValue.ToString();
        }

        private void cmbInt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabir_intervala = cmbInterval.SelectedValue.ToString();
        }

        private void cmbContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabir_sadrzaja = cmbContent.SelectedValue.ToString();
            if (odabir_sadrzaja == "Inflacija")
            {
                cmbInterval.Visibility = Visibility.Hidden;
                lab_int.Visibility = Visibility.Hidden;
            }
            else if (odabir_sadrzaja == "Zarada")
            {
                cmbInterval.Visibility = Visibility.Hidden;
                lab_int.Visibility = Visibility.Hidden;
            }
            else
            {
                cmbInterval.Visibility = Visibility.Visible;
                lab_int.Visibility = Visibility.Visible;
            }
        }
    }
}

