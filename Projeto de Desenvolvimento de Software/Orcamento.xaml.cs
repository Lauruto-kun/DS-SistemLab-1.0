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
using Projeto_de_Desenvolvimento_de_Software.Interface;
using Projeto_de_Desenvolvimento_de_Software.Models;


namespace Projeto_de_Desenvolvimento_de_Software.Views
{
    /// <summary>
    /// Lógica interna para Orcamento.xaml
    /// </summary>
    public partial class Orcamento : Window
    {
        public Orcamento()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {


            var conexao = new Conexao();


            List<Venda> listaVendas = new List<Venda>();
            for (int i = 0; i < 100; i++)
            {
                listaVendas.Add(new Venda()
                {
                    ID = 1 + i,
                    Exames = "Beta" + i,
                    Descricao = "Exame de Grávidez",
                    UN = "UN",
                    quant = 02 * i,
                    Desconto = 10,
                    Preco = 15.50 * i,
                    Total = 15.59 - 10 - (2 * i)

                }
           );


            }
            Datagrid.ItemsSource = listaVendas;

        }
        private void Datagrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Salvar_Copy_Click(object sender, RoutedEventArgs e)
        {
            imposto.Clear();
            valor_bruto.Clear();
            acrescimo.Clear();
            id.Clear();
            aten.Clear();

            pac.Clear();
            desconto.Clear();
            opera.Clear();
            subtotal.Clear();
            desconto.Clear();
            total.Clear();

        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        }

        private void Novo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Salvar_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Insert_Teste();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void valor_bruto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void subtotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void desconto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void dataini_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void id_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void opera_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pac_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Insert_Teste()
        {
            try
            {
                Pedidos_Pacientes pedidos_pacientes = new Pedidos_Pacientes();

                pedidos_pacientes.Descricao_ped = "Qualquer coisa";
                pedidos_pacientes.Id_pa_fk = 1;
                pedidos_pacientes.Tipo_ped = "O+";

                Pedidos_PacientesDAO pedidos_pacientesDAO = new Pedidos_PacientesDAO();
                pedidos_pacientesDAO.Insert(pedidos_pacientes);

                MessageBox.Show("O pedido do paciente foi realizado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
        }

    }
}
