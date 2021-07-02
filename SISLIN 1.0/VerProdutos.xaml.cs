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
    /// Lógica interna para VerProdutos.xaml
    /// </summary>
    public partial class VerProdutos : Window
    {
        List<ProdutosPromocao> codigopromo = new List<ProdutosPromocao>();

        public VerProdutos()
        {
            InitializeComponent();
            Loaded += VerProdutos_Loaded;
<<<<<<< HEAD
=======
        }

        private void VerProdutos_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                codigopromo.Add(new ProdutosPromocao()
                {
                    Id = i + 1,
                    Produto = "Langerie",
                    Valor_atual = 100,
                    Valor_promo = 90,
                    Porcent = 10,
                    
                });
            }
            datagrid.ItemsSource = codigopromo;
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

>>>>>>> main
        }

        private void VerProdutos_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                codigopromo.Add(new ProdutosPromocao()
                {
                    Id = i + 1,
                    Produto = "Langerie",
                    Valor_atual = 100,
                    Valor_promo = 90,
                    Porcent = 10,
                    
                });
            }
            datagrid.ItemsSource = codigopromo;
        }

       
    }
}
