using HidApi;

namespace LogiSwitch
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Thread thread = new Thread(start);
            thread.Start();
        }

        private void start()
        {
            LogitechDeviceInterface ldi = new LogitechDeviceInterface();
            while (true)
            {
                String input = ldi.Listen();
                Console.WriteLine(input);

                Console.WriteLine("Source: " + input.Substring(2, 2));
                Console.WriteLine("Pressed: " + ldi.DecodeInput(input));

                String action = ldi.DecodeInput(input);

                if (action.StartsWith("Keyboard"))
                {
                    String output = ldi.EncodeAction("Mouse" + action.Replace("Keyboard", ""));

                    if (output != "Unknown")
                    {
                        Console.WriteLine("Setting: " + output);
                        ldi.SendToDevice(output);
                    }
                }
            };
        }
    }
}
