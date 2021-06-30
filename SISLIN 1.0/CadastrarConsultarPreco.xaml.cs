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
    /// Lógica interna para CadastrarConsultarPreco.xaml
    /// </summary>
    public partial class CadastrarConsultarPreco : Window
    {
        public CadastrarConsultarPreco()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome;
            nome = Convert.ToString(Nome.Text);


            MessageBox.Show("O sistema ainda não está com essa função disponível, pois não temos o Banco de Dados.\nMas a opção " + nome + " será anotada, obrigado.");
        }
    }
}
