﻿#pragma checksum "..\..\..\..\View\WebPipeline.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86A6DEB553E92CC880D9FE47F7E79A0174ACE60D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ABPipeline.Components;
using ABPipeline.Controls;
using Albert.Win32.Controls;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Search;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ABPipeline.View {
    
    
    /// <summary>
    /// WebPipeline
    /// </summary>
    public partial class WebPipeline : ABPipeline.Controls.PipelinePage, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl webTabControl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider fontSizeSlider;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox descriptionWriterBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox tagsWriterBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\WebPipeline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox commentWriterBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ABPipeline;component/view/webpipeline.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WebPipeline.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.webTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.fontComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.fontSizeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.descriptionWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            case 5:
            this.tagsWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            case 6:
            this.commentWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
