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
    /// Lógica interna para Tabela_de_Preco.xaml
    /// </summary>
    public partial class Tabela_de_Preco : Window
    {
        List<Dados_preco> preco = new List<Dados_preco>();
        public Tabela_de_Preco()
        {
            InitializeComponent();



            Loaded += Tabela_de_Preco_Loaded;
        }

        private void Tabela_de_Preco_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                preco.Add(new Dados_preco()
                {
                    Cod = i + 1,
                    Val = 50 + i,
                    Type = "Calcinha"
                    
                });
            }
            tabela.ItemsSource = preco;
        }

        private void cadas_prod_Click(object sender, RoutedEventArgs e)
        {
            PRODUTOS_CADASTRO chama = new PRODUTOS_CADASTRO();
            chama.ShowDialog();
        }

        private void edit_preco_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Função Ainda Não Disponível!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
