﻿#pragma checksum "..\..\Kategoriak.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "547024234622D793EE8F1449FE997165563E20BDC77B794A302869D0602558F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MatricaNyilv;
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


namespace MatricaNyilv {
    
    
    /// <summary>
    /// Kategoriak
    /// </summary>
    public partial class Kategoriak : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Kategoria_tabla;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mezo1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mezo2;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mezo3;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mezo4;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button torles_gomb;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mezo5;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox szoveg1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kategoria_Rogzitese;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kategoria_Modositas;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tartalom_Torles;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Kategoriak.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vissza_gomb;
        
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
            System.Uri resourceLocater = new System.Uri("/MatricaNyilv;component/kategoriak.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Kategoriak.xaml"
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
            
            #line 8 "..\..\Kategoriak.xaml"
            ((MatricaNyilv.Kategoriak)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Kategoria_tabla = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\Kategoriak.xaml"
            this.Kategoria_tabla.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Kategoria_tabla_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mezo1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.mezo2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.mezo3 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.mezo4 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.torles_gomb = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Kategoriak.xaml"
            this.torles_gomb.Click += new System.Windows.RoutedEventHandler(this.torles_gomb_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mezo5 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.szoveg1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Kategoria_Rogzitese = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Kategoriak.xaml"
            this.Kategoria_Rogzitese.Click += new System.Windows.RoutedEventHandler(this.Kategoria_Rogzitese_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Kategoria_Modositas = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Kategoriak.xaml"
            this.Kategoria_Modositas.Click += new System.Windows.RoutedEventHandler(this.Kategoria_Modositas_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Tartalom_Torles = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Kategoriak.xaml"
            this.Tartalom_Torles.Click += new System.Windows.RoutedEventHandler(this.Tartalom_Torles_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.vissza_gomb = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\Kategoriak.xaml"
            this.vissza_gomb.Click += new System.Windows.RoutedEventHandler(this.vissza_gomb_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

