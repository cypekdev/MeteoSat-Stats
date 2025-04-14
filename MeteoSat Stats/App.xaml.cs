using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MeteoSat_Stats
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ObservableCollection<DataPacket> Packets { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Packets = new ObservableCollection<DataPacket>();

            UsbService usbService = new UsbService(Packets);
            
        }
    }

}
