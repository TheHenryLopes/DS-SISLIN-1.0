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
                MenuPrincipal Chamar = new MenuPrincipal();
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
    }
}
