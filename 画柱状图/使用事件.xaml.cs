﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Events;
using LiveCharts.Wpf;

namespace 画柱状图
{
    /// <summary>
    /// 使用事件.xaml 的交互逻辑
    /// </summary>
    public partial class 使用事件 : UserControl
    {
        public 使用事件()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void ChartOnDataClick(object sender, ChartPoint p)
        {
            var asPixels = Chart.ConvertToPixels(p.AsPoint());
            Console.WriteLine("[EVENT] You clicked (" + p.X + ", " + p.Y + ") in pixels (" +
                            asPixels.X + ", " + asPixels.Y + ")");
        }

        private void Chart_OnDataHover(object sender, ChartPoint p)
        {
            Console.WriteLine("[EVENT] you hovered over " + p.X + ", " + p.Y);
        }

        private void ChartOnUpdaterTick(object sender)
        {
            Console.WriteLine("[EVENT] chart was updated");
        }

        private void Axis_OnRangeChanged(RangeChangedEventArgs eventargs)
        {
            Console.WriteLine("[EVENT] axis range changed");
        }

        private void ChartMouseMove(object sender, MouseEventArgs e)
        {
            var point = Chart.ConvertToChartValues(e.GetPosition(Chart));

            X.Text = point.X.ToString("N");
            Y.Text = point.Y.ToString("N");
        }

    }
}
