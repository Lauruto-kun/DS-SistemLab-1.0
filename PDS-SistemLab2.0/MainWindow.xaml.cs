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
using PDS_SistemLab2._0;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Views2._0;

namespace PDS_SistemLab2._0
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

        private void desconto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {


            var conexao = new Conexao2();

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
          //  Insert_Teste();
            Button button = sender as Button;
            var window = new Views2._0.Login();
            window.ShowDialog();
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


      
        



    }
}
