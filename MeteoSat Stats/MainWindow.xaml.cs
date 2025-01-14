using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NetDock.Controls;

namespace MeteoSat_Stats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var consoleIcon = new BitmapImage(new Uri("pack://application:,,,/console.png", UriKind.Absolute));
            var lineChartIcon = new BitmapImage(new Uri("pack://application:,,,/line_chart.png", UriKind.Absolute));

            dockSurface.Add(new DockItem(new Console()) { TabName = "Console", TabIcon = consoleIcon });
            dockSurface.Add(new DockItem(new LineChart()) { TabName = "Chart", TabIcon = lineChartIcon }); 
        }
    }
}