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
    /// Lógica interna para Localizar.xaml
    /// </summary>
    public partial class Localizar : Window
    {
        List<VarLoc> vars = new List<VarLoc>();
        public Localizar()
        {
            InitializeComponent();

            Loaded += Localizar_Loaded;
        }

        private void Localizar_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                vars.Add(new VarLoc()
                {
                    Cod = i + 1,
                    Name = "Jesus é amigo, Jesus é meu Irmão"
                });
            }
            Deus_e_mais.ItemsSource = vars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja cancelar a Operação?", "Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBoxResult result1 = MessageBox.Show("Operação cancelada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result1 == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Função ainda não disponível", "Alerta", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Função ainda não disponível", "Alerta", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string pesquisa;
            pesquisa = Convert.ToString(certo.Text);


            MessageBox.Show("O sistema ainda não está com essa função disponível, pois não temos o Banco de Dados.\nMas a opção " + pesquisa + " será anotada, obrigado!");
        }
    }
}
