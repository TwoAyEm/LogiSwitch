using HidApi;
using System.Text;

namespace LogiSwitch
{
    internal class LogitechDeviceInterface
    {
        private static Device? receiver;


        public LogitechDeviceInterface()
        {
            receiver = SetDevice();
        }

        public String Listen()
        {
            try
            {
                if (receiver != null)
                {
                    byte[] byteArray = receiver.Read(7).ToArray();
                    StringBuilder sb = new StringBuilder(byteArray.Length * 2);
                    foreach (byte b in byteArray)
                    {
                        sb.Append(b.ToString("X2"));
                    }
                    return sb.ToString();
                }
                return "";
            }
            catch (HidException ex)
            {
                Console.WriteLine(ex.ToString());
                return "Error";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Error";
            }
        }

        public void SendToDevice(String command)
        {
            if (receiver != null)
            {
                int byteCount = command.Length / 2;
                var byteArray = new byte[byteCount];
                for (int i = 0; i < byteCount; i++)
                {
                    byteArray[i] = Convert.ToByte(command.Substring(i * 2, 2), 16);
                }
                receiver.Write(byteArray);
            }
        }

        private Device? SetDevice()
        {
            var deviceList = new List<KeyValuePair<String, String>>();
            foreach (var deviceInfo in Hid.Enumerate())
            {
                if (deviceInfo.Path.Replace("&", "").StartsWith("\\\\?\\HID#VID_046DPID_C52BMI_02Col01"))
                {
                    Hid.Exit();
                    return deviceInfo.ConnectToDevice();
                }
            }
            Hid.Exit();
            return null;
        }



        public String DecodeInput(String input)
        {
            switch (input.Substring(8, 4))
            {
                case "B18A":
                    return "Keyboard1";
                case "718A":
                    return "Keyboard2";
                case "1109":
                    return "Keyboard3";
                case "B269":
                    return "Mouse1";
                case "7269":
                    return "Mouse2";
                case "1E09":
                    return "Mouse3";
                default:
                    Console.WriteLine("Unknown device Id: " + input.Substring(8, 4));
                    return "Unknown";
            }
        }

        public String EncodeAction(String input)
        {
            switch (input)
            {
                case "Mouse1":
                    return "10030911000000";
                case "Mouse2":
                    return "1003091E010000";
                case "Mouse3":
                    return "10030911020000";
                case "Keyboard1":
                    return "10010911000000";
                case "Keyboard2":
                    return "1001091E010000";
                case "Keyboard3":
                    return "10010911020000";
                default:
                    return "Unknown";
            }
        }

    };

};

