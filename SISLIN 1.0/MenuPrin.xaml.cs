using SISLIN_1._0;
using SISLIN_1._0.Database;
using SISLIN_1._0.Models;
//using SISLIN_1._0.Views;
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
    /// Lógica interna para MenuPrin.xaml
    /// </summary>
    public partial class MenuPrin
    {
        public MenuPrin()
        {
            InitializeComponent();
            Loaded += MenuPrin_Loaded;
        }

        private void MenuPrin_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var conexao = new Conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Emitir_RRM1 Chamar = new Emitir_RRM1();
            Chamar.ShowDialog();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Cadastrar_Orçamentos1 Chamar = new Cadastrar_Orçamentos1();
            Chamar.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            botaofeedback Chamar = new botaofeedback();
            Chamar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            Cadastrar_PerdasSimples Chamar = new Cadastrar_PerdasSimples();
            Chamar.ShowDialog();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Promocao Chamar = new Cadastrar_Promocao();
            Chamar.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CadastrarCliente Chamar = new CadastrarCliente();
            Chamar.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CadastrarConsultarPreco Chamar = new CadastrarConsultarPreco();
            Chamar.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Cadas_Comp Chama = new Cadas_Comp();
            Chama.ShowDialog();
        }

        private void Tabel_preco_Click(object sender, RoutedEventArgs e)
        {
            Tabela_de_Preco Chamar = new Tabela_de_Preco();
            Chamar.ShowDialog();
        }

        private void Cadas_Entr_Aluno_Click(object sender, RoutedEventArgs e)
        {
            Cadas_Entra_Dinh Chamar = new Cadas_Entra_Dinh();
            Chamar.ShowDialog();
        }

        private void Cadas_Prod_Click(object sender, RoutedEventArgs e)
        {
            PRODUTOS_CADASTRO Chamar = new PRODUTOS_CADASTRO();
            Chamar.ShowDialog();
        }

        private void pagamento_Click(object sender, RoutedEventArgs e)
        {
            PAGAM_1 Chamar = new PAGAM_1();
            Chamar.ShowDialog();
        }

        private void Tell_Click(object sender, RoutedEventArgs e)
        {
            ListaTelefonica Chama = new ListaTelefonica();
            Chama.ShowDialog();
        }

        
    }
}
