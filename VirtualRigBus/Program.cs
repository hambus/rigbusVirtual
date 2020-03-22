using HambusCommonLibrary;
using System;
using System.IO.Ports;
using System.Threading;
using VirtualKenwoodBus;

namespace VirtualRigBus
{
  class Program
  {
    static void Main(string[] args)
    {
      CommPortConfig portConf = new CommPortConfig();
      portConf.BaudRate = 57600;
      portConf.BaudRate = 8;
      portConf.StopBits = "one";
      portConf.Parity = "none";
      portConf.PortName = "com10";
      portConf.DisplayName = "ACLogger";
      portConf.Handshake = "none";
      var kenwood = new KenwoodEmu();
      kenwood.OpenPort(portConf);
    }
  }
}
