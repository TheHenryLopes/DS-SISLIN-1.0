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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SISLIN_1._0.Models;


namespace SISLIN_1._0
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        string senha;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded1(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            InsertTest();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            senha = (PassSenha.Password);

            if (senha == "12345")
            {
                MenuPrin Chamar = new MenuPrin();
                Chamar.ShowDialog();

                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Senha Incorreta!");
            }

            
        }

        private void SENHA_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void InsertTest()
        {

            Cliente cliente = new Cliente();
            cliente.nome_cliente = "Gustavo";
            cliente.cpf_cliente = "454444545";
          cliente.email_cliente = "gustavo.saam@gmail.com";




        }

        private void InsertVenda()
        {
            EntrDinheiro entrDinheiro = new EntrDinheiro();
            entrDinheiro.Id_Dinheiro = 1;
            entrDinheiro.Valor_Dinheiro = 55;
            entrDinheiro.Tipo_Dinheiro = "Dinheiro";

            EntrDinheiroDAO entrDinheiroDAO = new EntrDinheiroDAO();
            entrDinheiroDAO.Insert(entrDinheiro);
        }
    }
}
