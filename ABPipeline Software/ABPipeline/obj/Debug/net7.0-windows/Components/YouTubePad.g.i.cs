﻿#pragma checksum "..\..\..\..\Components\YouTubePad.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7F14240642A272D45A7783F22A63E96887D987C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ABPipeline.Components {
    
    
    /// <summary>
    /// YouTubePad
    /// </summary>
    public partial class YouTubePad : ABPipeline.Controls.PipelineControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Components\YouTubePad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.AvalonEdit.TextEditor notesTextEditor;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Components\YouTubePad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox descriptionWriterBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Components\YouTubePad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox tagsWriterBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Components\YouTubePad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albert.Win32.Controls.WriterBox commentWriterBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ABPipeline;component/components/youtubepad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Components\YouTubePad.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.notesTextEditor = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            return;
            case 2:
            this.descriptionWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            case 3:
            this.tagsWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            case 4:
            this.commentWriterBox = ((Albert.Win32.Controls.WriterBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

