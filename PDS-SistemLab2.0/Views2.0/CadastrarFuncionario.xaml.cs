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
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Views2._0;

namespace PDS_SistemLab2._0.Views2._0
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
            try
            {
               Funcionario funcionario = new Funcionario();

                funcionario.Logradouro = logradouro.Text ;
                funcionario.Nome = nome.Text;
                funcionario.Numero = (int)Convert.ToInt64(RG.Text);
                funcionario.Atuacao = atuacao.Text;
                funcionario.CPF =CPF.Text;
                funcionario.Telefone= (int)Convert.ToInt64(celular.Text);
               



                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Insert(funcionario);

                MessageBox.Show("O pedido do paciente foi realizado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
            MessageBox.Show("Cadastro Realizado com Sucesso!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void atuacao_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RG_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
