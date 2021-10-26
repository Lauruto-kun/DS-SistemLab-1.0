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
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
           
        }

        

        private void orcamento_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var orcamento = new MainWindow();
            orcamento.ShowDialog();
        }

        private void exibir_resultado_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var resultadoexa = new ExibirResultados();
            resultadoexa.ShowDialog();

        }

        private void Gerar_Convenio_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var conveniogera = new GerarConvenio();
            conveniogera.ShowDialog();

        }

         

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var login = new Login();
            login.ShowDialog();
        }

        private void Realizar_Pedidos_dos_Pacientes_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var pedidos_pacientes = new Realiza_Pedidos();
            pedidos_pacientes.ShowDialog();
 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var exa = new ExibirExame();
            exa.ShowDialog();
        }

        private void médico_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void médico__Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var med=new CadastrarFuncionario();
            med.ShowDialog();

        }
    }
}
