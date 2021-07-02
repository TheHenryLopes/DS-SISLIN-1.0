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
    /// Lógica interna para PRODUTOS_CADASTRO.xaml
    /// </summary>
    public partial class PRODUTOS_CADASTRO : Window
    {
        public PRODUTOS_CADASTRO()
        {
            InitializeComponent();
        }

        private void oi_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Editado com Sucesso!", "Notificação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBox();
            MessageBoxResult result = MessageBox.Show("Excluído com Sucesso!", "Notificação", MessageBoxButton.OK, MessageBoxImage.Information);
            if(result == MessageBoxResult.OK)
            this.Close();
        }

        private void ClearTextBox()
        {
            codigo1.Text = "";
            nome1.Text = "";
        }
    }
}
