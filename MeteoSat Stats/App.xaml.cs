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
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            UsbService usbService = new UsbService();
            usbService.StartListening();
        }
    }

}
