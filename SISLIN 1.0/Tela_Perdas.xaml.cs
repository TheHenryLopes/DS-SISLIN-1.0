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
    /// Lógica interna para Tela_Perdas.xaml
    /// </summary>
    public partial class Tela_Perdas : Window
    {
        public Tela_Perdas()
        {
            InitializeComponent();
        }

        private void editar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void salvar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txt_codBarrs.Text = "";
            txt_codigo.Text = "";
            txt_custo.Text = "";
            txt_data.Text = "";
            txt_motivo.Text = "";
            txt_obs.Text = "";
            txt_produto.Text = "";
            txt_quantidade.Text = "";
            txt_ref.Text = "";
            txt_unidade.Text = "";
            txt_venda.Text = "";
        }
    }
}
