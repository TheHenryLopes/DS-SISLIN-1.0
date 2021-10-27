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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();

            

            Loaded += CadastrarCliente_Loaded;
        }

        private void CadastrarCliente_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void excluir1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {
            


            try
            {
                Cliente cliente = new Cliente();
                cliente.nome_cliente = NOME.Text;
                cliente.cpf_cliente = CPF.Text;
                cliente.rg_cliente = RG.Text;
                cliente.email_cliente = EMAIL.Text;
                cliente.nome_fantasia_cliente = FANTA.Text;
                cliente.telefone_cli = CELU.Text;

                ClienteDAO clientedao = new ClienteDAO();
                clientedao.Insert(cliente);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            COD.Clear();
            NOME.Clear();
            FANTA.Clear();
            CELU.Clear();
            RG.Clear();
            CPF.Clear();
            EMAIL.Clear();
        }

        private void junior_Click_1(object sender, RoutedEventArgs e)
        {
            Localizar Chamar = new Localizar();
            Chamar.ShowDialog();
        }

        private void COD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
