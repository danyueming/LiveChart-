using System;
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
using LiveCharts.Wpf;

namespace 表格控件
{
    /// <summary>
    /// 饼状图PieChart.xaml 的交互逻辑
    /// </summary>
    public partial class 饼状图PieChart : UserControl
    {
        public Func<ChartPoint, string> PointLabel { get; set; }
        public 饼状图PieChart()
        {
            InitializeComponent();
            PointLabel = chartPoint =>
            string.Format("{0} ({1:P1})", chartPoint.Y, chartPoint.Participation);//格式化百分比
            DataContext = this;
        }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (PieChart)chartpoint.ChartView;
            foreach (PieSeries series in chart.Series)
            {
                series.PushOut = 0;//clear selected slice.
            }
            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 5;//设置该slice距中心点的位置
        }
    }
}
