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
using Projeto_de_Desenvolvimento_de_Software.Database;

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
                    

                }
           );


            }
            

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
