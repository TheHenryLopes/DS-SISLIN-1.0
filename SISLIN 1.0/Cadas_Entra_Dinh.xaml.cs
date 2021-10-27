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
using SISLIN_1._0.Models;

namespace SISLIN_1._0
{
    /// <summary>
    /// Lógica interna para Cadas_Entra_Dinh.xaml
    /// </summary>
    public partial class Cadas_Entra_Dinh : Window
    {
        List<Cadastro1> Cadas = new List<Cadastro1>();
        public Cadas_Entra_Dinh()
        {
            InitializeComponent();

            Loaded += Cadas_Entra_Dinh_LoadedCadas_Entra_Dinh_Loaded;
        }

        private void Cadas_Entra_Dinh_LoadedCadas_Entra_Dinh_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Cadas.Add(new Cadastro1()
                {
                    Cod = i + 1,
                    Val = 50 + i,
                    Tip = "Jesus é amigo, Jesus é meu Irmão"
                });
            }
            Tela1.ItemsSource = Cadas;
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            Edit_Entr_Dinh Chamar = new Edit_Entr_Dinh();
            Chamar.ShowDialog();
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Excl_Entr_Dinh Chamar = new Excl_Entr_Dinh();
            Chamar.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EntrDinheiro entrDinheiro = new EntrDinheiro();
                entrDinheiro.Id_Dinheiro = ;
                entrDinheiro.Valor_Dinheiro = 55;
                entrDinheiro.Tipo_Dinheiro = "Dinheiro";

                EntrDinheiroDAO entrDinheiroDAO = new EntrDinheiroDAO();
                entrDinheiroDAO.Insert(entrDinheiro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Tela1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
