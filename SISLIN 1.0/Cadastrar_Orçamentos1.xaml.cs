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
    /// Lógica interna para Cadastrar_Orçamentos1.xaml
    /// </summary>
    public partial class Cadastrar_Orçamentos1 : Window
    {
        List<Dados_Orcamento> Informacao = new List<Dados_Orcamento>();

        public Cadastrar_Orçamentos1()
        {
            InitializeComponent();

            datinha.SelectedDate = DateTime.Now;

            Loaded += Cadastrar_Orçamentos1_Loaded;
        }

        private void Cadastrar_Orçamentos1_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                var dao = new OrcamentoDAO();

                info_orca.ItemsSource = dao.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void salv_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Orcamento orcamento = new Orcamento();
                orcamento.Data = (DateTime)datinha.SelectedDate;
                orcamento.Descrisao = Convert.ToString(txt_descrisao.Text);
                orcamento.Desconto = Convert.ToInt32(txt_desconto.Text);
                orcamento.Unidade = Convert.ToInt32(txt_unidade.Text);
                orcamento.Quantdd = Convert.ToInt32(txt_quantdd.Text);
                orcamento.Valor = Convert.ToDouble(txt_valor.Text);

                OrcamentoDAO OrcamentoDAO = new OrcamentoDAO();
                OrcamentoDAO.Insert(orcamento);

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

                LoadDataGrid();

                var result = MessageBox.Show("Deseja continuar adicionando?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                    LoadDataGrid();
                else
                    ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            datinha.SelectedDate = null;
            txt_descrisao.Text = "";
            txt_desconto.Text = "";
            txt_unidade.Text = "";
            txt_quantdd.Text = "";
            txt_valor.Text = "";

        }
    }
}
