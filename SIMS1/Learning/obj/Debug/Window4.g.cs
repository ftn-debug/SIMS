﻿#pragma checksum "..\..\Window4.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B1C510349167D96AA3ECEECC9CF1582CDFEC58F391C60A30E15ADB70E4F289C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Learning;
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


namespace Learning {
    
    
    /// <summary>
    /// Window4
    /// </summary>
    public partial class Window4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePic;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox vremePic;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pacijenti;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sale;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button potvrdi;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button odustani;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sifraOperacije;
        
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
            System.Uri resourceLocater = new System.Uri("/Learning;component/window4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window4.xaml"
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
            this.datePic = ((System.Windows.Controls.DatePicker)(target));
            
            #line 11 "..\..\Window4.xaml"
            this.datePic.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datePic_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.vremePic = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\Window4.xaml"
            this.vremePic.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.vremePic_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pacijenti = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\Window4.xaml"
            this.pacijenti.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pacijenti_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sale = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\Window4.xaml"
            this.sale.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sale_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.potvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Window4.xaml"
            this.potvrdi.Click += new System.Windows.RoutedEventHandler(this.potvrdi_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.odustani = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Window4.xaml"
            this.odustani.Click += new System.Windows.RoutedEventHandler(this.odustani_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sifraOperacije = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
