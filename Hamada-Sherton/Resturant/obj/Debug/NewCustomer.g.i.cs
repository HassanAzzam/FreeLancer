﻿#pragma checksum "..\..\NewCustomer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC92F18DEC9C5BA3AF05579416B24369"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace Resturant {
    
    
    /// <summary>
    /// NewCustomer
    /// </summary>
    public partial class NewCustomer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gr;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PhoneLbl;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle PlusBtn1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle PlusBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gr2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\NewCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle NewCustBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Resturant;component/newcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewCustomer.xaml"
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
            this.Gr = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.PhoneLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.PhoneTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PlusBtn1 = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 19 "..\..\NewCustomer.xaml"
            this.PlusBtn1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlusBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PlusBtn = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 20 "..\..\NewCustomer.xaml"
            this.PlusBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlusBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Gr2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.NewCustBtn = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 38 "..\..\NewCustomer.xaml"
            this.NewCustBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_MouseEnter);
            
            #line default
            #line hidden
            
            #line 38 "..\..\NewCustomer.xaml"
            this.NewCustBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Rectangle_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\NewCustomer.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Rectangle_MouseEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

