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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();

            Niver.SelectedDate = DateTime.Now;
        }
        private void excluir1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja salvar Operação?", "Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBoxResult result1 = MessageBox.Show("Salvo com sucesso!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result1 == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            COD.Clear();
            NOME.Clear();
            TELE.Clear();
            CELU.Clear();
            RG.Clear();
            CPF.Clear();
            ENDERE.Clear();
        }

        private void junior_Click_1(object sender, RoutedEventArgs e)
        {
            Localizar Chamar = new Localizar();
            Chamar.ShowDialog();
        }

        private void COD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
