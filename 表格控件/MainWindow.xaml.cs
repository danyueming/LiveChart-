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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }


        private void Load()
        {
            Values1 = new ChartValues<double> { 3, 4, 6, 3, 2, 6 };
            Values2 = new ChartValues<double> { 5, 3, 5, 7, 3, 9 };
            DataContext = this;
        }

        public ChartValues<double> Values1 { get; set; }
        public ChartValues<double> Values2 { get; set; }



    }
}
