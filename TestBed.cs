using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiSwitch
{
    public partial class TestBed : Form
    {
        public TestBed()
        {
            InitializeComponent();
        }

        LogitechDeviceInterface ldi = null;

        private void TestBed_Load(object sender, EventArgs e)
        {
            ldi = new LogitechDeviceInterface();
        }

        private void ButtonPush(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Access the Text property of the clicked button
                ldi.SendToDevice(ldi.EncodeAction(clickedButton.Text.Replace(" ", "")));
            }
        }
    }
}
