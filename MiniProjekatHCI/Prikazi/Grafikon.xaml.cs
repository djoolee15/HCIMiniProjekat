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
            LoadColumnChartData();
        }

        private void LoadColumnChartData() {
            ((ColumnSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<string, int>[]{
        new KeyValuePair<string, int>("Project Manager", 12),
        new KeyValuePair<string, int>("CEO", 25),
        new KeyValuePair<string, int>("Software Engg.", 5),
        new KeyValuePair<string, int>("Team Leader", 6),
        new KeyValuePair<string, int>("Project Leader", 10),
        new KeyValuePair<string, int>("Developer", 4) };
        }
    }
}

