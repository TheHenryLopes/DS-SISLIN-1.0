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
    /// Lógica interna para PAGAM_1.xaml
    /// </summary>
    public partial class PAGAM_1 : Window
    {
        public PAGAM_1()
        {
            InitializeComponent();
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Salvo com Sucesso!", "Notificação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Excluído com Sucesso!", "Notificação", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
