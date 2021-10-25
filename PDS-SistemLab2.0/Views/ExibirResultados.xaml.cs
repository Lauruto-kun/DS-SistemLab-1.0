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
    /// Lógica interna para ExibirResultados.xaml
    /// </summary>
    public partial class ExibirResultados : Window
    {
        public ExibirResultados()
        {
            InitializeComponent();
        }

        private void cmbLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Não Atribuído", "Imprimir Resultados",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
