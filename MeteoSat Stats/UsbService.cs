using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections.ObjectModel;

namespace MeteoSat_Stats
{
    class UsbService
    {
        private SerialPort port;
        private ObservableCollection<DataPacket> Data { get; set; }

        public UsbService(ObservableCollection<DataPacket> data)
        {
            port = new SerialPort();
            port.DataReceived += PortDataReceived;
            Data = new ObservableCollection<DataPacket>();
        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string content = port.ReadExisting();

            Data.Add(parseData(content));
        }

        private DataPacket parseData(string data) 
        {
            string[] array = data.Split(';');
            int id = int.Parse(array[0]);
            float pressure = float.Parse(array[1]);
            float temperatur = float.Parse(array[2]);
            float humidity = float.Parse(array[3]);
            float methane = float.Parse(array[4]);
            float carbon = float.Parse(array[5]);
            float speed = float.Parse(array[6]);
            float rotationX = float.Parse(array[7]);
            float rotationY = float.Parse(array[8]);
            float rotationZ = float.Parse(array[9]);
            double longitude = float.Parse(array[10]);
            double latitude = float.Parse(array[11]);
            float height = float.Parse(array[12]);
            long elapsed = long.Parse(array[13]);

            return new DataPacket(id, pressure, temperatur, humidity, methane, carbon, speed, rotationX, rotationY, rotationZ, longitude, latitude, height, elapsed);
        }
    }
}
