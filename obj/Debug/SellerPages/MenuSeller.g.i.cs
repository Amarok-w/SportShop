﻿#pragma checksum "..\..\..\SellerPages\MenuSeller.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A11CB638F62854D3313FFE573E1254FC440523592A08F4A2B5FB42F5F00FD651"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportShop.SellerPages;
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


namespace SportShop.SellerPages {
    
    
    /// <summary>
    /// MenuSeller
    /// </summary>
    public partial class MenuSeller : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\SellerPages\MenuSeller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClients;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\SellerPages\MenuSeller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProducts;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\SellerPages\MenuSeller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCart;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\SellerPages\MenuSeller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\SellerPages\MenuSeller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmSeller;
        
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
            System.Uri resourceLocater = new System.Uri("/SportShop;component/sellerpages/menuseller.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SellerPages\MenuSeller.xaml"
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
            this.btnClients = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\SellerPages\MenuSeller.xaml"
            this.btnClients.Click += new System.Windows.RoutedEventHandler(this.btnClients_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnProducts = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\SellerPages\MenuSeller.xaml"
            this.btnProducts.Click += new System.Windows.RoutedEventHandler(this.btnProducts_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCart = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\SellerPages\MenuSeller.xaml"
            this.btnCart.Click += new System.Windows.RoutedEventHandler(this.btnCart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\SellerPages\MenuSeller.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frmSeller = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

