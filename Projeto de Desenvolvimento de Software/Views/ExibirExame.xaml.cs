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
    /// Lógica interna para ExibirExame.xaml
    /// </summary>
    public partial class ExibirExame : Window
    {
        public ExibirExame()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            string lista;

            lista = cmbLista.Text;

            MessageBox.Show($"Exame selecionado: {lista}");
        }
    }
}
