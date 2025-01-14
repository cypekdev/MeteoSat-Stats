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

namespace MeteoSat_Stats
{
    /// <summary>
    /// Interaction logic for Console.xaml
    /// </summary>
    public partial class Console : UserControl
    {
        public string ConsoleOutput { get; set; }
        public Console()
        {
            InitializeComponent();
            DataContext = this;

            ConsoleOutput = "19:14:30 nowe dane są odebrane \n19:14:30 nowe dane są odebran";

        }
    }
}
