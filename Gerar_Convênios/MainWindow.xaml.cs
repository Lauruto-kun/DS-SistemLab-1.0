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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gerar_Convênios
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
    }
}
