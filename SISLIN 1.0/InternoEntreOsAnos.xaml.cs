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
    /// Lógica interna para InternoEntreOsAnos.xaml
    /// </summary>
    public partial class InternoEntreOsAnos : Window
    {
        

        List<InternoAno> e_me = new List<InternoAno>();
        public InternoEntreOsAnos()
        {
            InitializeComponent();
            Loaded += InternoEntreOsAnos_Loaded;
        }

        private void InternoEntreOsAnos_Loaded(object sender, RoutedEventArgs e)
        {
         
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                e_me.Add(new InternoAno()
                {
                    Mes1 = i + 1,
                    Valor_1 = 9000,
                    Mes2 = i + 1,
                    Valor_2 = 4568

                });
            }
            datagrid_an.ItemsSource = e_me;
        }
    }
}
