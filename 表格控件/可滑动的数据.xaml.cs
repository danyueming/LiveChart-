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
using LiveCharts.Events;

namespace 表格控件
{
    /// <summary>
    /// 可滑动的数据.xaml 的交互逻辑
    /// </summary>
    public partial class 可滑动的数据 : UserControl, IDisposable
    {
        public 可滑动的数据()
        {
            InitializeComponent();
            this.DataContext = new ScrollableViewModel();
        }

        private void Axis_OnRangeChanged(RangeChangedEventArgs eventargs)
        {
            var vm = (ScrollableViewModel)DataContext;

            var currentRange = eventargs.Range;

            if (currentRange < TimeSpan.TicksPerDay * 2)
            {
                vm.Formatter = x => new DateTime((long)x).ToString("t");
                return;
            }

            if (currentRange < TimeSpan.TicksPerDay * 60)
            {
                vm.Formatter = x => new DateTime((long)x).ToString("dd MMM yy");
                return;
            }

            if (currentRange < TimeSpan.TicksPerDay * 540)
            {
                vm.Formatter = x => new DateTime((long)x).ToString("MMM yy");
                return;
            }

            vm.Formatter = x => new DateTime((long)x).ToString("yyyy");
        }

        public void Dispose()
        {
            var vm = (ScrollableViewModel)DataContext;
            vm.Values.Dispose();
        }
    }
}
