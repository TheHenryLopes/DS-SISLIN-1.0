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

namespace SISLIN_1._0
{
    /// <summary>
    /// Lógica interna para ConsumoInterno.xaml
    /// </summary>
    public partial class ConsumoInterno : Window

    {
        List<TabelaOrca> c_i = new List<TabelaOrca>(); 
        public ConsumoInterno()
        {

            InitializeComponent();
            Loaded += ConsumoInterno_Loaded;
        }

        private void ConsumoInterno_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                c_i.Add(new TabelaOrca()
                {
                    
                    Valor_em_produtos_gastos = 15000,
                    v_interno = 1000,
                    d_f = 5732,
                    v_d_d_s = 3000

                });
            }
            d_t_a.ItemsSource = c_i;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
