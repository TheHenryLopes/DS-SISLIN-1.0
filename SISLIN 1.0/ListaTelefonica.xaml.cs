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
    /// Lógica interna para ListaTelefonica.xaml
    /// </summary>
    public partial class ListaTelefonica : Window
    {
        List<agenda> agendactt = new List<agenda>();
        public ListaTelefonica()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                agendactt.Add(new agenda()
                {
                    Telefone = 444444,
                    Nome = "Vinicius"

                });
            }
            info.ItemsSource = agendactt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 chamar = new MainWindow1();
            chamar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
