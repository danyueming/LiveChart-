using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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

namespace 画柱状图
{
    /// <summary>
    /// ColumnControl.xaml 的交互逻辑
    /// </summary>
    public partial class ColumnControl : UserControl
    {

        /// <summary>
        /// 线段集合
        /// </summary>
        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public ColumnControl()
        {
            InitializeComponent();
            this.Loaded += InitialData;
        }

        /// <summary>
        /// 横坐标：年份，纵坐标：值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitialData(object sender, RoutedEventArgs e)
        {
            SeriesCollection = new SeriesCollection()
            {
                //new ColumnSeries{
                //    Title="2015",
                //    Values = new ChartValues<double> { 10, 50, 39, 50 }
                //}

            };
            //SeriesCollection.Add(new ColumnSeries
            //{
            //    Title = "2016",
            //    Values = new ChartValues<double> { 11, 56, 42 }
            //});
            //SeriesCollection[1].Values.Add(48d);
            //Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
       
            SeriesCollection.Add(new ColumnSeries()
            {
                Values = new ChartValues<ObservablePoint>()
                {
                    new ObservablePoint(3,8),
                    new ObservablePoint(12,19),
                    new ObservablePoint(30,7),
                }
            });
            Formatter = value => value.ToString("N");
            DataContext = this;
        }

    }
}
