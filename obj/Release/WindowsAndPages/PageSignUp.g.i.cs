﻿#pragma checksum "..\..\..\WindowsAndPages\PageSignUp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "14D715500E0755DFA138056B835C8F83A5964E699774F49C8366DFA429D45E0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using F6MADRecipes.WindowsAndPages;
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


namespace F6MADRecipes.WindowsAndPages {
    
    
    /// <summary>
    /// PageSignUp
    /// </summary>
    public partial class PageSignUp : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_Name;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_NewEmail;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Txb_NewPassword;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Txb_NewRePassword;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_SignUp;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\WindowsAndPages\PageSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;
        
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
            System.Uri resourceLocater = new System.Uri("/F6MADRecipes;component/windowsandpages/pagesignup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowsAndPages\PageSignUp.xaml"
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
            this.Txb_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Txb_NewEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Txb_NewPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.Txb_NewRePassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.Btn_SignUp = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\WindowsAndPages\PageSignUp.xaml"
            this.Btn_SignUp.Click += new System.Windows.RoutedEventHandler(this.Btn_SignUp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\WindowsAndPages\PageSignUp.xaml"
            this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

