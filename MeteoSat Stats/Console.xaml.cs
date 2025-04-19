using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<DataPacket> Data { get; set; }

        public Console()
        {
            InitializeComponent();
            DataContext = this;

            Data = ((MainWindow) Application.Current.MainWindow).Packets;

            Data.CollectionChanged += CollectionChanged;
        }

        private void CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            string textContent = "";
            foreach (var packet in Data)
            {
                textContent += (packet.ToString() + '\n');
            }
            ConsoleOutput.Text = textContent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data.Add(new DataPacket(1,1,1,1,1,1,1,1,1,1,1,1,1,1));
        }
    }
}
