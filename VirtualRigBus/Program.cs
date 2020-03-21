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
      portConf.BaudRate = 9600;
      portConf.BaudRate = 8;
      portConf.StopBits = "one";
      portConf.Parity = "none";
      portConf.ReadTimeout = 200000;
      portConf.WriteTimeout = 2000;
      portConf.PortName = "com10";
      portConf.DisplayName = "ACLogger";
      portConf.Handshake = "none";
      var kenwood = new KenwoodEmu();
      kenwood.OpenPort(portConf);
      while (true)
        Thread.Sleep(1000);
    }
  }
}
