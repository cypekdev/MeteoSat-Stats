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
                ReadTimeout = 100,
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
            Debug.WriteLine("xd");
            try
            {
                if (port.BytesToRead > 0)
                {
                    string line = port.ReadLine();
                    Debug.WriteLine($"📥 Odebrano: {line}");

                    String[] data = line.Split(';');

                    DataPacket packet = new DataPacket(
                        int.Parse(data[0]),
                        float.Parse(data[1]),
                        float.Parse(data[2]),
                        float.Parse(data[3]),
                        float.Parse(data[4]),
                        float.Parse(data[5]),
                        float.Parse(data[6]),
                        float.Parse(data[7]),
                        float.Parse(data[8]),
                        float.Parse(data[9]),
                        double.Parse(data[10]),
                        double.Parse(data[11]),
                        float.Parse(data[12]),
                        long.Parse(data[13])
                    );

                    dispatcher.Invoke(() =>
                    {
                        collection.Add(packet);
                    });
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"⚠️ Wspaniała Istoto, błąd odczytu: {ex.Message}");
            }
        }
    }

}
