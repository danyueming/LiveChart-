﻿#pragma checksum "..\..\使用事件.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "266DED0F52728302956B6701F0B6B940"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
using 画柱状图;


namespace 画柱状图 {
    
    
    /// <summary>
    /// 使用事件
    /// </summary>
    public partial class 使用事件 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\使用事件.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock X;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\使用事件.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Y;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\使用事件.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart Chart;
        
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
            System.Uri resourceLocater = new System.Uri("/画柱状图;component/%e4%bd%bf%e7%94%a8%e4%ba%8b%e4%bb%b6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\使用事件.xaml"
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
            this.X = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Y = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Chart = ((LiveCharts.Wpf.CartesianChart)(target));
            
            #line 23 "..\..\使用事件.xaml"
            this.Chart.MouseMove += new System.Windows.Input.MouseEventHandler(this.ChartMouseMove);
            
            #line default
            #line hidden
            
            #line 24 "..\..\使用事件.xaml"
            this.Chart.DataClick += new LiveCharts.Events.DataClickHandler(this.ChartOnDataClick);
            
            #line default
            #line hidden
            
            #line 25 "..\..\使用事件.xaml"
            this.Chart.DataHover += new LiveCharts.Events.DataHoverHandler(this.Chart_OnDataHover);
            
            #line default
            #line hidden
            
            #line 26 "..\..\使用事件.xaml"
            this.Chart.UpdaterTick += new LiveCharts.Events.UpdaterTickHandler(this.ChartOnUpdaterTick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\使用事件.xaml"
            ((LiveCharts.Wpf.Axis)(target)).RangeChanged += new LiveCharts.Events.RangeChangedHandler(this.Axis_OnRangeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

