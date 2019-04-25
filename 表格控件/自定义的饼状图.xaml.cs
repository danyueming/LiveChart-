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

namespace 表格控件
{
    /// <summary>
    /// 自定义的饼状图.xaml 的交互逻辑
    /// </summary>
    public partial class 自定义的饼状图 : UserControl
    {
        public SeriesCollection SeriesCollec { get; set; }
        public 自定义的饼状图()
        {
            InitializeComponent();
            LoadData();
            this.myPie.Series = SeriesCollec;
        }

        private void LoadData()
        {
            SeriesCollec = new SeriesCollection
            {
                new PieSeries
                {
                    Title ="Maria",
                    Values=new ChartValues<ObservableValue>()
                    {new ObservableValue(4),
                    },
                    DataLabels=true,
                    LabelPoint =  chartPoint => string.Format("{0} ({1:P1})" , chartPoint.Y , chartPoint.Participation)

                },

                 new PieSeries
                {
                    Title ="Jim",
                    Values=new ChartValues<ObservableValue>()
                    {new ObservableValue(4),
                    },
                    DataLabels=true,
                    LabelPoint =  chartPoint => string.Format("{0} ({1:P1})" , chartPoint.Y , chartPoint.Participation)

                }
            };

        }
    }
}
