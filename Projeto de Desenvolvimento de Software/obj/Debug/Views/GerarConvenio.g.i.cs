﻿#pragma checksum "..\..\..\Views\GerarConvenio.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74087916D323499A3BE162BDAD15723BD57AF4DBF95C9F8228FC43A859F54A93"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Projeto_de_Desenvolvimento_de_Software.Views;
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


namespace Projeto_de_Desenvolvimento_de_Software.Views {
    
    
    /// <summary>
    /// GerarConvenio
    /// </summary>
    public partial class GerarConvenio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Convênio;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Ordem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Vencimento;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label A;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Data;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cobrança;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sair;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Recebimento;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Ficha;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\GerarConvenio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Valor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projeto de Desenvolvimento de Software;component/views/gerarconvenio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\GerarConvenio.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Convênio = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Ordem = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.Vencimento = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.A = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Data = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Cobrança = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\GerarConvenio.xaml"
            this.Cobrança.Click += new System.Windows.RoutedEventHandler(this.Cobrança_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sair = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\GerarConvenio.xaml"
            this.Sair.Click += new System.Windows.RoutedEventHandler(this.Sair_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Recebimento = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Ficha = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Valor = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

