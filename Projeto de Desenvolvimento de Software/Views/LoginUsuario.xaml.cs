using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Func_Cadastro
{
    /// <summary>
    /// Lógica interna para LoginUsuario.xaml
    /// </summary>
    public partial class LoginUsuario : Window
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login Realizado com sucesso!");
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login Cancelado");
        }

        private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
