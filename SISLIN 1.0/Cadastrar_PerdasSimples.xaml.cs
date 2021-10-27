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
                perdas.Data = (DateTime)data_info.SelectedDate;
                perdas.Motivo = Convert.ToString(txt_motivo.Text);
                perdas.Valor = Convert.ToDouble(txt_valorEstimulado.Text);
                perdas.Quantidade = Convert.ToInt32(txt_quantidade.Text);

                PerdasDAO perdasDAO = new PerdasDAO();
                perdasDAO.Insert(perdas);

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar adicionando?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                    ClearInputs();
                else
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro inesperado!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            
        }

        private void ClearInputs()
        {
            txt_motivo.Text = "";
            txt_quantidade.Text = "";
            txt_valorEstimulado.Text = "";
            data_info.SelectedDate = null;
        }

        private void sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
