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
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace 表格控件
{


    /// <summary>
    /// DataChart.xaml 的交互逻辑
    /// </summary>
    public partial class DataChart : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public int AxisStep { get; set; }

        public DataChart()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values=new ChartValues< ObservablePoint>{new  ObservablePoint(6,9),
                    new  ObservablePoint(9,6),
                new  ObservablePoint(7,20),
            new  ObservablePoint(16,25)},
            Stroke = System.Windows.Media.Brushes.Yellow,
                    StrokeDashArray= new DoubleCollection{ 2}
        },
       
            };

            Labels = new[] { "-10", "0", "10", "20", "30", "40" };
            // YFormatter = value => value.ToString("C");


           


            DataContext = this;
        }




    }
}
