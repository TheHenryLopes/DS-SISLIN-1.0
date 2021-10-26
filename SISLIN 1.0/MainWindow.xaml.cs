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
using SISLIN_1._0.Database;




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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
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
            senha = (SENHA.Text);

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

            Inset_Teste();
        }

        private void SENHA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Inset_Teste()
        {
            try
            {
                Perdas perdas = new Perdas();

                perdas.ID = 1;
                perdas.Nome = "Jennifer";
                perdas.Valor = 5000;

                PerdasDAO perdasDAO = new PerdasDAO();
                perdasDAO.Insert(perdas);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}