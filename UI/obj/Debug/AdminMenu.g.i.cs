﻿#pragma checksum "..\..\AdminMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90466A757B0A7ADB779FEC48CBDBB8A71350ADF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UI;


namespace UI {
    
    
    /// <summary>
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addProduct;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addShop;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refresh;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button generate;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridShops;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminMenu.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\AdminMenu.xaml"
            this.dataGrid.Loaded += new System.Windows.RoutedEventHandler(this.dataGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addProduct = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AdminMenu.xaml"
            this.addProduct.Click += new System.Windows.RoutedEventHandler(this.addProduct_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addShop = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AdminMenu.xaml"
            this.addShop.Click += new System.Windows.RoutedEventHandler(this.addShop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.refresh = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AdminMenu.xaml"
            this.refresh.Click += new System.Windows.RoutedEventHandler(this.refresh_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.generate = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AdminMenu.xaml"
            this.generate.Click += new System.Windows.RoutedEventHandler(this.generate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datagridShops = ((System.Windows.Controls.DataGrid)(target));
            
            #line 44 "..\..\AdminMenu.xaml"
            this.datagridShops.Loaded += new System.Windows.RoutedEventHandler(this.datagridShops_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 73 "..\..\AdminMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 74 "..\..\AdminMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.add_p_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\AdminMenu.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

