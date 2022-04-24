using MiniProjekatHCI.Podaci;
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
using System.Windows.Shapes;

namespace MiniProjekatHCI.Prikazi
{
    /// <summary>
    /// Interaction logic for TabelarniPrikaz.xaml
    /// </summary>
    public partial class TabelarniPrikaz : Window
    {
        private readonly ViewModel _viewModel;

        public TabelarniPrikaz()
        {
            InitializeComponent();
            this._viewModel = new ViewModel
            {
                Data = new List<MockData>()
                {
                    new MockData
                    {
                        Name = "dragan",
                        isAwesome = true
                    },
                    new MockData
                    {
                        Name = "milan",
                        isAwesome = true
                    }
                }
            };
            this.DataContext = this._viewModel;
        }
       
    }
}
