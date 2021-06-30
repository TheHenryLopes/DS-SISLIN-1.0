using SISLIN_1._0;
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
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Promocao Chamar = new Cadastrar_Promocao();
            Chamar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Emitir_RRM1 Chamar = new Emitir_RRM1();
            Chamar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cadastrar_PerdasSimples Chamar = new Cadastrar_PerdasSimples();
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
    }
}
