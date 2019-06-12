using System;
using System.IO;


namespace DoorOpener.Static
{
    public class DataKeeper
    {
       

        
        public DataKeeper()
        {               
        }

        public bool SaveDevice(string ip, string port)
        {
            if (File.Exists("./ip.dat"))
                RemoveDevice();

            TextWriter txt = new StreamWriter("./ip.dat");
            txt.Write(ip);
            txt.Close();

            txt = new StreamWriter("./port.dat");
            txt.Write(port);
            txt.Close();

            if (File.Exists("./ip.dat") && File.Exists("./ip.dat"))
                return true;
            else
                return false;
            
        }

        public bool RemoveDevice()
        {
            if (File.Exists("./ip.dat"))
            {
                File.WriteAllText("./ip.dat", String.Empty);
                File.WriteAllText("./port.dat", String.Empty);
                return true;
            }
            else
            {
                return false;
            }


        }

        public Devices device()
        {
            if (!File.Exists("./ip.dat"))
                return null;

            Devices devices = new Devices();
            StreamReader sr = new StreamReader("./ip.dat");
            string ip = sr.ReadLine();
            sr.Close();

            sr = new StreamReader("./port.dat");
            string port = sr.ReadLine();
            sr.Close();

            if (string.IsNullOrEmpty(port) && string.IsNullOrEmpty(ip))
                return null;

            devices = new Devices()
            {
                DeviceIp = ip,
                DevicePort = port
            };

            return devices;
        }
    }
}
