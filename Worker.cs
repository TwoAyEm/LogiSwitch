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

           // while (true)
           // {
                //String input = ldi.Listen();
                //Console.WriteLine(input);

                //Console.WriteLine("Source: " + input.Substring(2, 2));
                //Console.WriteLine("Pressed: " + ldi.DecodeInput(input));

                //String output = ldi.EncodeAction(ldi.DecodeInput(input));
                String output = ldi.EncodeAction("Keyboard2");

                if (output != "Unknown")
                {
                    Console.WriteLine("Setting: " + output);
                    ldi.SendToDevice(output);
                }

            //};
            
        }

    }
}
