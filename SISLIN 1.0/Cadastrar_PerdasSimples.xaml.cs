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
    /// Lógica interna para Cadastrar_PerdasSimples.xaml
    /// </summary>
    public partial class Cadastrar_PerdasSimples : Window
    {
        public Cadastrar_PerdasSimples()
        {
            InitializeComponent();

            data_info.SelectedDate = DateTime.Now;
        }

        private void editar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Informação editada com sucesso!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }


        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Tem certeza que deseja inserir/modificar alguma inforção?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            try
                {
                    Perdas perdas = new Perdas();
                    
                    perdas.Nome = "Nina";
                    perdas.Valor = 50000;

                    PerdasDAO perdasDAO = new PerdasDAO();
                    perdasDAO.Insert(perdas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Não executado", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            

            /*
            MessageBoxResult result = MessageBox.Show("Salvo com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            if(result == MessageBoxResult.OK)
            {
                MessageBoxResult result2 = MessageBox.Show("Deseja sair da tela?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if(result2 == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            }
            */
        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação" , MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txt_motivo.Text = "";
            txt_quantidade.Text = "";
            txt_venda.Text = "";
        }
    }
}
