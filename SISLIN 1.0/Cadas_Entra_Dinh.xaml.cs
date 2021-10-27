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
                entrDinheiro.Id_Dinheiro = 1;
                entrDinheiro.Valor_Dinheiro = 55;
                entrDinheiro.formapaga_Dinheiro = "Dinheiro";

                

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

                var result = MessageBox.Show("Deseja continuar adicionando?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                    ClearInputs();
                else
                    ClearInputs();

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
        private void ClearInputs()
        {
            data.SelectedDate = null;
            text02.Text = "";
            tipo.Text = "";
        }
    }
}
