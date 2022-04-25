using MiniProjekatHCI.Podaci;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
        }

        public static string odabir_prikaza;
        public static string odabir_intervala;
        public static string odabir_sadrzaja;

        public static IEnumerable<Value1> data_prozora;
        public static IEnumerable<Value1> data_provereni;
        private ViewModel _viewModel;


       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dat1;
            string dat2;

            dat1 = prvi_datum.Text;
            dat2 = drugi_datum.Text;

          


            APIData apiData = new APIData();  // dobavljac
            DataClass1 data;
            try
            {
                data = apiData.generateData(cmbContent.SelectedValue.ToString());
                this._viewModel = new ViewModel
                {

                    Data = data.data
                
                };
                this.DataContext = this._viewModel;
                data_prozora = data.data;
                if (data_prozora is null) {
                    MessageBox.Show("Podaci ne mogu biti ucitani!");
                    Close();
                }
            }
            catch {
                MessageBox.Show("Podaci ne mogu biti ucitani!");
            }

            //Pre prikaza ukloniti sve one koji nisu u opsegu i  prikazati prvih 15


            try
            {
                DateTime oDate1 = DateTime.Parse(dat1);
                DateTime oDate2 = DateTime.Parse(dat2);
                foreach (Value1 v in data_prozora)
                {

                    DateTime oDate = DateTime.Parse(v.date);
                    if (oDate < oDate2 && oDate > oDate1)
                    {
                        Console.WriteLine("Dobar Datum za prikaz!");
                    }
                    else
                    {
                        data_provereni.Append(v);
                    }
                }
                if (data_provereni != null)
                {
                    data_prozora = data_provereni;
                }
            }
            catch (Exception) { MessageBox.Show("Molimo unesite podatke u dobrom formatu!");
                prvi_datum.Focus();
                drugi_datum.Focus();
                

            }



            if (odabir_prikaza == "Tabelarni Prikaz")
            {
                var s = new MiniProjekatHCI.Prikazi.TabelarniPrikaz();
                s.DataContext = this;
                s.Show();
            }
            else if (odabir_prikaza == "Grafikon Prikaz")
            {
                var s = new MiniProjekatHCI.Prikazi.Grafikon();
                s.DataContext = this;
                s.Show();

            }
            else
            {
                var s = new MiniProjekatHCI.Prikazi.LinijskiGrafikon();
                s.DataContext = this;
                s.Show();
            }
            }

            private void cmbPrikaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabir_prikaza = cmbPrikaz.SelectedValue.ToString();
        }

        
        
            private void cmbContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabir_sadrzaja = cmbContent.SelectedValue.ToString();
            if (odabir_sadrzaja == "Inflacija")
            {
               
            }
            else if (odabir_sadrzaja == "Zarada")
            {
               
            }
            else
            {
                
            }
        }
        
    }
}

