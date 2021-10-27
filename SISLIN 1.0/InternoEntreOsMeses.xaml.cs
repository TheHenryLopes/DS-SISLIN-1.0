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
    /// Lógica interna para InternoEntreOsMeses.xaml
    /// </summary>
    public partial class InternoEntreOsMeses : Window
    {
        List<EntreOsMeses> e_me = new List<EntreOsMeses>();
        public InternoEntreOsMeses()
        {
            InitializeComponent();
            Loaded += InternoEntreOsMeses_Loaded;
        }
        
        private void InternoEntreOsMeses_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                e_me.Add(new EntreOsMeses()
                {
                    Mes1= i + 1,
                    Valor_1 = 9000,
                    Mes2 = i + 1,
                    Valor_2 = 4568
                    
                });
            }
            datagride_me.ItemsSource = e_me;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
