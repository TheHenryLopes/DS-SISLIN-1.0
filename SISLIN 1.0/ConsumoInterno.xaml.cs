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
<<<<<<< HEAD
        public ConsumoInterno()
        {
            InitializeComponent();
=======
        List<MesInterno> m_i = new List<MesInterno>();
        public ConsumoInterno()
        {
            
            InitializeComponent();
            Loaded += ConsumoInterno_Loaded;

            
        }

        private void ConsumoInterno_Loaded(object sender, RoutedEventArgs e)
        {
        
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                m_i.Add(new MesInterno()
                {
                    
                    Valor_em_compra = 14500,
                    Valor_em_salario = 8921,
                    Valor_em_demais = 6590,
                    Custo_da_loja = 3452,

                });
            }
            datagrid_i.ItemsSource = m_i;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InternoEntreOsMeses chamar = new InternoEntreOsMeses();
            chamar.ShowDialog();

        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InternoEntreOsAnos chamar = new InternoEntreOsAnos();
            chamar.ShowDialog();
>>>>>>> main
        }
    }
}
