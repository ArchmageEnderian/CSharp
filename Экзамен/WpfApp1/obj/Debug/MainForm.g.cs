﻿#pragma checksum "..\..\MainForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1492753E3D5B8FE9A0FFBCF49463B3B7CD05D0F4C62BCC51CCB4E65A0872E47D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox BlueBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBut;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadBut;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainForm.xaml"
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
            
            #line 8 "..\..\MainForm.xaml"
            ((WpfApp1.MainForm)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BlueBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 14 "..\..\MainForm.xaml"
            this.BlueBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 14 "..\..\MainForm.xaml"
            this.BlueBox.Checked += new System.Windows.RoutedEventHandler(this.BlueSide);
            
            #line default
            #line hidden
            return;
            case 3:
            this.popup1 = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 4:
            this.SaveBut = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainForm.xaml"
            this.SaveBut.Click += new System.Windows.RoutedEventHandler(this.SaveFile);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoadBut = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainForm.xaml"
            this.LoadBut.Click += new System.Windows.RoutedEventHandler(this.LoadFile);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\MainForm.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutMe);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 39 "..\..\MainForm.xaml"
            ((System.Windows.Controls.ComboBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ProcLoad);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

