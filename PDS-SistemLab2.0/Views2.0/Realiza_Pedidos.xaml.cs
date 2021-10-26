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
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Models2._0;


namespace PDS_SistemLab2._0.Views2._0
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
            try
            {
                Pedidos_Pacientes pedidos_pacientes = new Pedidos_Pacientes();

                pedidos_pacientes.Descricaopedido = descricao_ped.Text;               
                pedidos_pacientes.Tipopedido = tipo_ped.Text;
               

                Pedidos_PacientesDAO pedidos_pacientesDAO = new Pedidos_PacientesDAO();
                pedidos_pacientesDAO.Insert(pedidos_pacientes);

                MessageBox.Show("O pedido do paciente foi realizado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
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

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
