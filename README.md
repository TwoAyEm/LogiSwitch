# LogiSwitch
Service to switch Logitech keyboards and mice in sync

Very basic POC. You will need your dongle IDs (different on each machine), and it is currently only tested on an MX Keys with MX Master 2s.

The service needs to be run on each machine that the devices connect to (and will need the device ID's set on each machine). It detects the keyboard change button press and will fire off a change to the mouse also.
The device ID's and numbering seem inconsistent and if you have linked the devices in a different order then the commands seem to change which device you are talking to.
Not worked out a way of interrogating the dongle to see what devices are connected.

Most info gleaned from https://github.com/Logitech/logi_craft_sdk/issues/28
