using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Microsoft.VisualBasic.Logging;

namespace MeteoSat_Stats
{
    public class DataPacket
    {
        public int ID { get; set; }
        public long PacketDateTime { get; set; }
        public float Pressure { get; set; }
        public float Temperatur { get; set; }
        public float Humidity { get; set; }
        public float Methane { get; set; }
        public float Carbon { get; set; }
        public float Speed { get; set; }
        public float RotationX { get; set; }
        public float RotationY { get; set; }
        public float RotationZ { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public float Height { get; set; }

        public DataPacket(int iD, float pressure, float temperatur, float humidity, float methane, float carbon, float speed, float rotationX, float rotationY, float rotationZ, double longitude, double latitude, float height, long packetDateTime)
        {
            ID = iD;
            PacketDateTime = packetDateTime;
            Pressure = pressure;
            Temperatur = temperatur;
            Humidity = humidity;
            Methane = methane;
            Carbon = carbon;
            Speed = speed;
            RotationX = rotationX;
            RotationY = rotationY;
            RotationZ = rotationZ;
            Longitude = longitude;
            Latitude = latitude;
            Height = height;
        }

        public override string? ToString()
        {
            return $"{ID}. P{Pressure}, T{Temperatur}, Hu{Humidity}, M{Methane}, C{Carbon}, V{Speed}, Rx{RotationX}, Ry{RotationY}, Rz{RotationZ}, Lo{Longitude}, La{Latitude}, He{Height}";
        }
    }
}
