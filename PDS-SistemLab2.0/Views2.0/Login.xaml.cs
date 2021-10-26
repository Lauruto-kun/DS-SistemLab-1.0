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

namespace PDS_SistemLab2._0.Views2._0
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        
            public Login()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, RoutedEventArgs e)
            { 
             Button button = sender as Button;
            var telainicial = new TelaInicial();
            telainicial.ShowDialog();
            }

        private void btnSair_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Login Cancelado");
            Close();
            }

            private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
            {

            }
        
    }
}
