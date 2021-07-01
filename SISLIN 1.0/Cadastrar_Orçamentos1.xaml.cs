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
    /// Lógica interna para Cadastrar_Orçamentos1.xaml
    /// </summary>
    public partial class Cadastrar_Orçamentos1 : Window
    {
        List<Dados_Orcamento> Informacao = new List<Dados_Orcamento>();

        public Cadastrar_Orçamentos1()
        {
            InitializeComponent();

            datinha.SelectedDate = DateTime.Now;

            Loaded += Cadastrar_Orçamentos1_Loaded;
        }

        private void Cadastrar_Orçamentos1_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 50; i++)
            {
                Informacao.Add(new Dados_Orcamento()
                {
                    Cod = i + 1,
                    Desc = "Lingeries",
                    Desconto = 15,
                    Unidd = 50 + i,
                    Quantdd = 200 + i,
                    Preco_Venda = 80 +i,
                    Total = 76 + i
                }) ;
            }
            info_orca.ItemsSource = Informacao;
        }

        private void atual_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Atualizado com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void loc_Click(object sender, RoutedEventArgs e)
        {
            Localizar chamar = new Localizar();
            chamar.ShowDialog();
            MessageBoxResult result = MessageBox.Show("Localizado com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ord_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Ordenado com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Certeza que deseja cancelar?", "Alerta", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                MessageBoxResult result1 = MessageBox.Show("Cancelado! (ㆆ_ㆆ)", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                if(result1 == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void salv_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Salvo com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void inse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Tem certeza que deseja inserir/modificar alguma inforção?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void exc_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                ClearTextBox();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Informação editada com sucesso!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void ClearTextBox()
        {
            txt_bairro.Text = "";
            txt_cliente.Text = "";
            txt_cod.Text = "";
            txt_compl.Text = "";
            txt_cpf.Text = "";
            txt_local.Text = "";
            txt_logra.Text = "";
            txt_nick.Text = "";
            txt_num.Text = "";
            txt_tell.Text = "";
        }
    }
}
