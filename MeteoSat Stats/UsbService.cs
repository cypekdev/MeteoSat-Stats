using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MeteoSat_Stats
{
    class UsbService
    {
        private SerialPort port;

        public void StartListening()
        {
            
        }

        public UsbService()
        {
            port = new SerialPort();
        }
    }
}
