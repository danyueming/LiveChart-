using LiveCharts;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// 合并柱状图与折线图.xaml 的交互逻辑
    /// </summary>
    public partial class 合并柱状图与折线图 : UserControl
    {
        public 合并柱状图与折线图()
        {
            InitializeComponent();
            this.Loaded += InitialData;
        }

        /// <summary>
        /// 直方图的点集合
        /// </summary>
        private IChartValues columnValues1 = new ChartValues<ObservablePoint>();
        public IChartValues ColumnValues1
        {
            get
            {
                return columnValues1;
            }
            set
            {
                if (columnValues1 != value)
                {
                    columnValues1 = value;
                    this.RaisePropertyChanged("ColumnValues1");
                }
            }
        }

        /// <summary>
        /// 曲线的点集合
        /// </summary>
        private IChartValues lineValues2 = new ChartValues<ObservablePoint>();
        public IChartValues LineValues2
        {
            get
            {
                return lineValues2;
            }
            set
            {
                if (lineValues2 != value)
                {
                    lineValues2 = value;
                    this.RaisePropertyChanged("LineValues2");
                }
            }
        }
        /// <summary>
        /// 横坐标：年份，纵坐标：值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitialData(object sender, RoutedEventArgs e)
        {

            ColumnValues1 = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(0.51, 34),
                 new ObservablePoint(0.56, 14),
                  new ObservablePoint(0.61, 14),
                  new ObservablePoint(0.66, 24),
                  new ObservablePoint(0.71, 24),
            };

            lineValues2 = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(24,0.003),
                 new ObservablePoint(123,0.005),
                  new ObservablePoint(225,0.006),
                  new ObservablePoint(342,0.008),
                  new ObservablePoint(461,0.009),
            };

            DataContext = this;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
