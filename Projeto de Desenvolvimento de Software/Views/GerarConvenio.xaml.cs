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

namespace Projeto_de_Desenvolvimento_de_Software.Views
{
    /// <summary>
    /// Lógica interna para GerarConvenio.xaml
    /// </summary>
    public partial class GerarConvenio : Window
    {
        public GerarConvenio()
        {
            InitializeComponent();
        }

        private void Cobrança_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Convênio enviado para cobrança!");
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Finalizar Convênio");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
