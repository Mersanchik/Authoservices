﻿#pragma checksum "..\..\..\Pages\WindowAddService.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A9D67FE51D3197F88D75C231232F09461A523B2A7FEB43C2A4E1C53F0B32F43C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Authoservices.Pages;
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


namespace Authoservices.Pages {
    
    
    /// <summary>
    /// WindowAddService
    /// </summary>
    public partial class WindowAddService : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameService;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountService;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeService;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiscountService;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PhotoService;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditPhoto;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddForBaseService;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\WindowAddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/Authoservices;component/pages/windowaddservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\WindowAddService.xaml"
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
            this.NameService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CountService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TimeService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DiscountService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PhotoService = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.EditPhoto = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.AddForBaseService = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\WindowAddService.xaml"
            this.AddForBaseService.Click += new System.Windows.RoutedEventHandler(this.AddForBaseServiceClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pages\WindowAddService.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
