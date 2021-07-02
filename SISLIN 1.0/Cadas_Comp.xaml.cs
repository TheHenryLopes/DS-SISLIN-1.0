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
    /// Lógica interna para Cadas_Comp.xaml
    /// </summary>
    public partial class Cadas_Comp : Window
    {
        public Cadas_Comp()
        {
            InitializeComponent();

            dataTrem.SelectedDate = DateTime.Now;
        }

        private void codigo1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Salvo com sucesso!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
