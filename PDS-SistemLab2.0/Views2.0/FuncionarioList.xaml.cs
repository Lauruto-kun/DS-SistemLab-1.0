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

namespace PDS_SistemLab2._0.Views2._0
{
    /// <summary>
    /// Lógica interna para FuncionarioList.xaml
    /// </summary>
    public partial class FuncionarioList : Window
    {
        public FuncionarioList()
        {
            InitializeComponent();
            Loaded += FuncionarioList_Loaded;
        }

        private void FuncionarioList_Loaded(object sender, RoutedEventArgs e)
        {
            LoadList();
           
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void DeletedRegistro()
        {
            var funcionariodelete = DataGrid.SelectedItem as Funcionario;

            var result = MessageBox.Show($"Deseja remover o funcionario '{funcionariodelete.Nome}' ?", "Confirmação de exclusão?" ,
            MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (result==MessageBoxResult.Yes)
                {
                    var dao = new FuncionarioDAO();
                    dao.Delete(funcionariodelete);
                    Load_DataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadList()
        {
            try
            {
                var dao = new FuncionarioDAO();
                DataGrid.ItemsSource = dao.List();
                        foreach (Funcionario func in dao.List())
                        {
                            MessageBox.Show(func.Nome + "CPF:" + func.Atuacao);
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Exceção",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

       private void DeletedRegistro(object sender,RoutedEventArgs e)
        {

        }


         private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window =new CadastrarFuncionario();
            window.ShowDialog();
            Load_DataGrid();
        }

        private void ViewButton(object sender,RoutedEventArgs e)
        {

            var funcionarioselected = DataGrid.SelectedItem as Funcionario;


            var window = new CadastrarFuncionario();
            window.ShowDialog();
            Load_DataGrid();

            try
            { 
                var dao = new FuncionarioDAO();
                var func = dao.GetById(funcionarioselected.Id);

                MessageBox.Show(func.Nome + "-CPF" + func.CPF);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void Load_DataGrid()
        {
            try
            {
                var dao = new FuncionarioDAO();
                DataGrid.ItemsSource = dao.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        
    }
}
