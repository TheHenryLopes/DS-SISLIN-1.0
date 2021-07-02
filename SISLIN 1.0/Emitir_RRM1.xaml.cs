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
    /// Lógica interna para Emitir_RRM1.xaml
    /// </summary>
    public partial class Emitir_RRM1 : Window
    {
        List<Relatorio_Mov> relal = new List<Relatorio_Mov>();
        public Emitir_RRM1()
        {
            InitializeComponent();
            Loaded += Emitir_RRM1_Loaded;
        }

        private void Emitir_RRM1_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                relal.Add(new Relatorio_Mov()
                {
                    Vend = i + 1,
                    Cancel = 20 + i,
                    Estoq = 250 + i,
                    Marc = "Bella Ciao",
                    cod_Barras = 856448555586,
                    Prec = 80,
                    Quantdd = 76,
                    Luc = 200,
                    Impos = 50,
                    Desp =   500
                });
            }
            relatorio.ItemsSource = relal;
        }

        private void Gerar_Relal_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Relatório gerar com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Impresão efetuada com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void pdf_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("PDF gerado com sucesso!", "Confirmação", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
