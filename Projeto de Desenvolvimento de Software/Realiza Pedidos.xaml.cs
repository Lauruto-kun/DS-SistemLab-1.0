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

namespace Projeto_de_Desenvolvimento_de_Software
{
    /// <summary>
    /// Lógica interna para Realiza_Pedidos.xaml
    /// </summary>
    public partial class Realiza_Pedidos : Window
    {
       public Realiza_Pedidos()
        {
            InitializeComponent();
            Loaded += Realiza_Pedidos_Loaded;
        }

        private void Realiza_Pedidos_Loaded(object sender, RoutedEventArgs e)
        {
            List<Realiza_Pedidos> listaVendas = new List<Realiza_Pedidos>();
            for (int i = 0; i < 100; i++)
            {
                listaVendas.Add(new Realiza_Pedidos()
                {
                    medico = 1 + i,
                    Exames = "Beta" + i,
                    Descricao = "Exame de Grávidez",
                    UN = "UN",
                    quant = 02 * i,
                    Desconto = 10,
                    Preco = 15.50 * i,
                    Total= 15.59-10-(2*i)

                }
           );


            }
            Datagrid.ItemsSource = listaVendas;

        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
