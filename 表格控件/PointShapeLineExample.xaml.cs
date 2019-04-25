using LiveCharts;
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

namespace 表格控件
{
    public partial class PointShapeLineExample : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public PointShapeLineExample()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                     LineSmoothness = 0,//设置为折线
                    Values = new ChartValues<double> { 4,2,7,2,7 },//这里只有Y值，X值为数组的索引
                    PointGeometry = DefaultGeometries.Square,//设置点的图案，这里设置为方形
                    PointGeometrySize = 15//设置图案的额大小
                },
                 new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                },
            };
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

           
            SeriesCollection[2].Values.Add(5d); //modifying any series values will also animate and update the chart
            DataContext = this;
        }

       
    }
}


