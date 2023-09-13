using HidApi;

namespace LogiSwitch
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            TestBed tb = new TestBed();
            tb.ShowDialog();

            Thread thread = new Thread(start);
            thread.Start();
        }

        private void start()
        {
            LogitechDeviceInterface ldi = new LogitechDeviceInterface();
            while (true)
            {
                String input = ldi.Listen();
                Console.WriteLine("Input:" + input);
                Console.WriteLine("Source: " + input.Substring(2, 2));
                Console.WriteLine("Pressed: " + ldi.DecodeInput(input));

                String action = ldi.DecodeInput(input);

                if (action.StartsWith("Keyboard"))
                {
                    String output = "Mouse" + action.Replace("Keyboard", "");

                    if (output != "Unknown")
                    {
                        Console.WriteLine("Setting: " + output);
                        Console.WriteLine("Sending: " + ldi.EncodeAction(output));
                        //ldi.SendToDevice(ldi.EncodeAction(output));
                    }
                }
                Console.WriteLine("-----");
            };
        }
    }
}
