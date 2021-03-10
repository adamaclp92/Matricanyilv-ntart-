﻿#pragma checksum "..\..\Registration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F58699E8E3575E4C0676E7BB998B1F87CFCBBAA3409B47F134518736F554879"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 168 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack1;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernametextbox;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordtextbox;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordconfirmtextbox;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmbtn;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbutton;
        
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
            System.Uri resourceLocater = new System.Uri("/MatricaNyilv;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registration.xaml"
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
            
            #line 153 "..\..\Registration.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stack1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.usernametextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 170 "..\..\Registration.xaml"
            this.usernametextbox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.usernametextbox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passwordtextbox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 174 "..\..\Registration.xaml"
            this.passwordtextbox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.passwordtextbox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwordconfirmtextbox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 178 "..\..\Registration.xaml"
            this.passwordconfirmtextbox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.passwordconfirmtextbox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.confirmbtn = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\Registration.xaml"
            this.confirmbtn.Click += new System.Windows.RoutedEventHandler(this.confirmbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exitbutton = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\Registration.xaml"
            this.exitbutton.Click += new System.Windows.RoutedEventHandler(this.exitbutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
