﻿#pragma checksum "..\..\GaussianChart.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE35F110D0F0CF6618B44E878B919392"
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
    /// GaussianChart
    /// </summary>
    public partial class GaussianChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart chartSeries;
        
        #line default
        #line hidden
        
        /// <summary>
        /// X_Separator Name Field
        /// </summary>
        
        #line 15 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public LiveCharts.Wpf.Separator X_Separator;
        
        #line default
        #line hidden
        
        /// <summary>
        /// ColumnY_Separator Name Field
        /// </summary>
        
        #line 26 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public LiveCharts.Wpf.Separator ColumnY_Separator;
        
        #line default
        #line hidden
        
        /// <summary>
        /// CurveY_Separator Name Field
        /// </summary>
        
        #line 35 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public LiveCharts.Wpf.Separator CurveY_Separator;
        
        #line default
        #line hidden
        
        /// <summary>
        /// myColumn Name Field
        /// </summary>
        
        #line 47 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public LiveCharts.Wpf.ColumnSeries myColumn;
        
        #line default
        #line hidden
        
        /// <summary>
        /// myLine Name Field
        /// </summary>
        
        #line 55 "..\..\GaussianChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public LiveCharts.Wpf.LineSeries myLine;
        
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
            System.Uri resourceLocater = new System.Uri("/画柱状图;component/gaussianchart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GaussianChart.xaml"
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
            this.chartSeries = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 2:
            this.X_Separator = ((LiveCharts.Wpf.Separator)(target));
            return;
            case 3:
            this.ColumnY_Separator = ((LiveCharts.Wpf.Separator)(target));
            return;
            case 4:
            this.CurveY_Separator = ((LiveCharts.Wpf.Separator)(target));
            return;
            case 5:
            this.myColumn = ((LiveCharts.Wpf.ColumnSeries)(target));
            return;
            case 6:
            this.myLine = ((LiveCharts.Wpf.LineSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

