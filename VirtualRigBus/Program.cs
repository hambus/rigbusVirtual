using System;
using System.IO.Ports;

namespace VirtualRigBus
{
  class Program
  {
    static void Main(string[] args)
    {
       bool _continue;
       SerialPort _serialPort;


      SerialPort portClass = new SerialPort();
      var ports = SerialPort.GetPortNames();
      foreach( var port in ports)
      {
        Console.WriteLine($"{port}");
      }
      Console.WriteLine("Hello World!");
    }
  }
}
