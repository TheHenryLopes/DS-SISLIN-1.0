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
    /// Lógica interna para Cadastrar_Orçamentos1.xaml
    /// </summary>
    public partial class Cadastrar_Orçamentos1 : Window
    {
        List<Dados_Orcamento> Informacao = new List<Dados_Orcamento>();

        public Cadastrar_Orçamentos1()
        {
            InitializeComponent();

            Loaded += Cadastrar_Orçamentos1_Loaded;
        }

        private void Cadastrar_Orçamentos1_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 2; i++)
            {
                Informacao.Add(new Dados_Orcamento()
                {
                    Cod = i + 1
                });
            }
            info_orca.ItemsSource = Informacao;
        }
    }
}
