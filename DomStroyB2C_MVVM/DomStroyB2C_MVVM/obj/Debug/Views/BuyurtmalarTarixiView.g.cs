﻿#pragma checksum "..\..\..\Views\BuyurtmalarTarixiView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5DC09EE1D2F9E3D537F3C2F4C45C3F9F8F3498EBBF2A8E93B0690806FE015264"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DomStroyB2C_MVVM.Views;
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


namespace DomStroyB2C_MVVM.Views {
    
    
    /// <summary>
    /// BuyurtmalarTarixiView
    /// </summary>
    public partial class BuyurtmalarTarixiView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border GridMenu;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tab1;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCalendar;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseCalendar;
        
        #line default
        #line hidden
        
        
        #line 280 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenCalendar;
        
        #line default
        #line hidden
        
        
        #line 341 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/DomStroyB2C_MVVM;component/views/buyurtmalartarixiview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
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
            this.GridMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.tab1 = ((System.Windows.Controls.TabControl)(target));
            
            #line 68 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
            this.tab1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tab1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GridCalendar = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ButtonCloseCalendar = ((System.Windows.Controls.Button)(target));
            
            #line 257 "..\..\..\Views\BuyurtmalarTarixiView.xaml"
            this.ButtonCloseCalendar.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseCalendar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonOpenCalendar = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 7:
            this.dataGridOrders = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
