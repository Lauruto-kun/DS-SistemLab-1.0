// Updated by XamlIntelliSenseFileGenerator 08/10/2021 20:17:07
#pragma checksum "..\..\Realiza Pedidos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74D92B0959842D0A2E102AEE040E51DC52169F8C1AA73C3B5BB1BEE8304F7FC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Projeto_de_Desenvolvimento_de_Software;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Projeto_de_Desenvolvimento_de_Software
{


    /// <summary>
    /// Realiza_Pedidos
    /// </summary>
    public partial class Realiza_Pedidos : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 9 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid realizar_pedidos;

#line default
#line hidden


#line 20 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu;

#line default
#line hidden


#line 21 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pesquisar;

#line default
#line hidden


#line 22 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sair;

#line default
#line hidden


#line 24 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu_Copy;

#line default
#line hidden


#line 25 "..\..\Realiza Pedidos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu_Copy1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projeto de Desenvolvimento de Software;component/realiza%20pedidos.xaml", System.UriKind.Relative);

#line 1 "..\..\Realiza Pedidos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Realizapedidos = ((Projeto_de_Desenvolvimento_de_Software.Realiza_Pedidos)(target));
                    return;
                case 2:
                    this.realizar_pedidos = ((System.Windows.Controls.Grid)(target));
                    return;
                case 3:
                    this.Menu = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\Realiza Pedidos.xaml"
                    this.Menu.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.Pesquisar = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.Sair = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\Realiza Pedidos.xaml"
                    this.Sair.Click += new System.Windows.RoutedEventHandler(this.Sair_Click);

#line default
#line hidden
                    return;
                case 6:

#line 23 "..\..\Realiza Pedidos.xaml"
                    ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.Menu_Copy = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\Realiza Pedidos.xaml"
                    this.Menu_Copy.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.Menu_Copy1 = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\Realiza Pedidos.xaml"
                    this.Menu_Copy1.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window Realizapedidos;
    }
}

