using MiniProjekatHCI.Podaci;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MiniProjekatHCI.Prikazi
{
    /// <summary>
    /// Interaction logic for Grafikon.xaml
    /// </summary>
    public partial class Grafikon : Window
    {
        public Grafikon()
        {
            InitializeComponent();
            this.DataContext = MainWindow.data_prozora;
            IEnumerable<Value1> lista_vrednosti = MainWindow.data_prozora;
   
            LoadColumnChartData1(lista_vrednosti);
        }

        private void LoadColumnChartData1(IEnumerable<Value1> lista_vrednosti)
        {
            int i = 0;
            int t = 0;
            foreach (Value1 v in lista_vrednosti)
            {
                t++;
            }
            KeyValuePair<string, double>[] cp = new KeyValuePair<string, double>[t];
            foreach (Value1 v in lista_vrednosti)
            {
                double x = Convert.ToDouble(v.value);
                cp[i] = new KeyValuePair<string, double>(v.date, x);
                i++;
                if (i == 14) { break; }
            }

            ((ColumnSeries)mcChart.Series[0]).ItemsSource = cp;
        }
       




    }
}

