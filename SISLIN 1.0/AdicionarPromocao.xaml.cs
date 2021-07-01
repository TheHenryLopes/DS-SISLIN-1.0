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
    /// Lógica interna para AdicionarPromocao.xaml
    /// </summary>
    public partial class AdicionarPromocao : Window
    {
        public AdicionarPromocao()
        {
            InitializeComponent();
            DpData.SelectedDate = DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome;
            nome = Convert.ToString(Nome.Text);


            MessageBox.Show("O sistema ainda não está com essa função disponível, pois não temos o Banco de Dados.\nMas a opção " + nome + " será anotada, obrigado.");
        }

        private void AddPromo_Click(object sender, RoutedEventArgs e)
        {
            DateTime data_selecionada = Convert.ToDateTime(DpData.SelectedDate);
            int dias = Convert.ToInt32(QtPromo.Text);
            data_selecionada.AddDays(dias);
            String aa, vencimento;
            

            VcPromo.Text = Convert.ToString(data_selecionada.AddDays(dias)).Substring(0, 10);

            double n_1, porcentagem, vp, VrProduto;

            vp = Convert.ToDouble(ValorPor.Text);
            VrProduto = Convert.ToDouble(ValorProduto.Text);
            aa = Convert.ToString(ProdutoNome.Text);
            vencimento = Convert.ToString(VcPromo.Text);


            porcentagem = vp / 100;
            

            n_1 = VrProduto - (VrProduto * porcentagem);

            MessageBox.Show("O produto " + aa + " entrou em promoção e agora está valendo: " + n_1 + " reais a promoção é válida até o dia :" + vencimento);

            



        }


        private void ClearTextBox()
        {
            ProdutoNome.Text = "";
            QtPromo.Text = "";
            ValorProduto.Text = "";
            ValorPor.Text = "";
            
        }
        private void VcPromo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VerPromo_Click(object sender, RoutedEventArgs e)
        {
            VerProdutos chamar = new VerProdutos();
            chamar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClearTextBox();
            
        }
    }
}

