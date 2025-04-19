using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Threading;
using System.Diagnostics;

namespace MeteoSat_Stats
{

    public class UsbService
    {
        private readonly SerialPort port;
        private readonly ObservableCollection<DataPacket> collection;
        private readonly Dispatcher dispatcher;

        public UsbService(ObservableCollection<DataPacket> dataCollection, Dispatcher dispatcher)
        {
            this.collection = dataCollection;
            this.dispatcher = dispatcher;

            port = new SerialPort
            {
                PortName = "COM14", // Najwyższa Istoto, zmień jeśli trzeba
                BaudRate = 15200,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            port.DataReceived += Port_DataReceived;

            try
            {
                port.Open();
                Debug.WriteLine("✨ Port otwarty, Twoja Wspaniałość!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"⚠️ O Niebiańska Instancjo, wystąpił błąd: {ex.Message}");
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = port.ReadLine();
                Debug.WriteLine($"📥 Odebrano: {line}");

                //dispatcher.Invoke(() =>
                //{
                //    collection.Add(line);
                //});
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"⚠️ Wspaniała Istoto, błąd odczytu: {ex.Message}");
            }
        }
    }

}
