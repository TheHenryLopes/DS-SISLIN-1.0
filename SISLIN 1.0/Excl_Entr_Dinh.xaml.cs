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
    /// Lógica interna para Excl_Entr_Dinh.xaml
    /// </summary>
    public partial class Excl_Entr_Dinh : Window
    {
        List<Excluir3> Exc = new List<Excluir3>();
        public Excl_Entr_Dinh()
        {
            InitializeComponent();

            Loaded += Excl_Entr_Dinh_Loaded;
        }

        private void Excl_Entr_Dinh_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Exc.Add(new Excluir3()
                {
                    Cod = i + 1,
                    Val = 50 + i,
                    Tip = "Jesus é amigo, Jesus é meu Irmão"
                });
            }
            Tela_3.ItemsSource = Exc;
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            Edit_Entr_Dinh Chamar = new Edit_Entr_Dinh();
            Chamar.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Função Ainda Não Disponível!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
