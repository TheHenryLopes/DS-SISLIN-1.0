﻿using System;
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
    /// Lógica interna para Cadastrar_Promocao.xaml
    /// </summary>
    public partial class Cadastrar_Promocao : Window
    {
        public Cadastrar_Promocao()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdicionarPromocao chamar = new AdicionarPromocao();
            chamar.ShowDialog();
           
        }

        private void Adicionar_Produto_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProcurarProdutosNaPromocao chamar = new ProcurarProdutosNaPromocao();
            chamar.ShowDialog();
        }
    }
}
