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
    /// Lógica interna para CadastrarFuncionario.xaml
    /// </summary>
    public partial class CadastrarFuncionario : Window
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cadastro Realizado com Sucesso!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
