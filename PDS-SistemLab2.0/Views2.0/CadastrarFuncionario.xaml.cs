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
using PDS_SistemLab2._0.Database2;
namespace PDS_SistemLab2._0.Views2._0
{
    /// <summary>
    /// Lógica interna para CadastrarFuncionario.xaml
    /// </summary>
    public partial class CadastrarFuncionario : Window
    {
        public int _id;
        private Funcionario _funcionario; 
        public CadastrarFuncionario()
        {
            InitializeComponent();
            Loaded += CadastrarFuncionario_Loaded;
        }

        public CadastrarFuncionario(int id)
        {
            _id = id;
            InitializeComponent();
            Loaded += CadastrarFuncionario_Loaded;
        }
        private void CadastrarFuncionario_Loaded(object sender, RoutedEventArgs e)
        {
            _funcionario = new Funcionario();
            if (_id > 0)
           
            Fillform();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
 
                _funcionario.Logradouro = logradouro.Text ;
                _funcionario.Nome = nome.Text;
                _funcionario.Numero = (int)Convert.ToInt64(RG.Text);
                _funcionario.Atuacao = atuacao.Text;
                _funcionario.CPF =CPF.Text;
                _funcionario.Telefone= (int)Convert.ToInt64(celular.Text);
                _funcionario.Datanas = (DateTime)datanas.SelectedDate;
                _funcionario.CEP = (int)Convert.ToInt64(CEP.Text);
                _funcionario.Cidade = Cidade.Text;
                Salvar();


        }

        private void ClearInputs()
        {
             logradouro.Text="";
             nome.Text="";
             RG.Text="";
            atuacao.Text="";
             CPF.Text="";
            celular.Text="";
            datanas.SelectedDate=null;
            CEP.Text ="";
            Cidade.Text = "";
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

        private void Fillform()
        {
            try
            {
                var dao = new FuncionarioDAO();
                _funcionario = dao.GetById(_id);

                ID.Text = _funcionario.Id.ToString();
                logradouro.Text = _funcionario.Logradouro;
                nome.Text = _funcionario.Nome;
                RG.Text = _funcionario.Numero.ToString();
                atuacao.Text = _funcionario.Atuacao;
                CPF.Text = _funcionario.CPF;
                celular.Text = _funcionario.Telefone.ToString();
                datanas.SelectedDate = _funcionario.Datanas;
                CEP.Text = _funcionario.CEP.ToString();
                Cidade.Text = _funcionario.Cidade;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Salvar()
        {
            try
            {
                var dao = new FuncionarioDAO();
                var text = "atualizado";
                if (_funcionario.Id == 0)
                {
                    dao.Insert(_funcionario);
                    text = "adcionado";
                }
                   
                else
                    dao.Update(_funcionario);

                MessageBox.Show($"O funcionário foi {text} com sucesso!","Sucesso",MessageBoxButton.OK,MessageBoxImage.Information);

                Closeee();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void Closeee()
        {
            var result = MessageBox.Show("Deseja continuar adcionando funcionários?" ,"Continuar?",MessageBoxButton.YesNo,MessageBoxImage.Error);

            if (result == MessageBoxResult.No)
                this.Close();
            else
                ClearInputs();
        }
       
        private void VisualizarFuncionario(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var func1 = new FuncionarioList();
            func1.ShowDialog();
            
        }

        private void Exlcuirfunc(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
