﻿using HambusCommonLibrary;
using System.IO.Ports;
using System.Net;

namespace VirtualKenwoodBusWin
{
  public class VirtualRigInfo 
  {
    private static VirtualRigInfo instance = null;
    public static VirtualRigInfo Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new VirtualRigInfo();
        }
        return instance;
      }
    }
    public object GetVirtualRigConfig()
    {
      var virtBusConf = new VirtualBusConf
      {
        Host = Dns.GetHostName()
      };
      var commPortConf = new CommPortConfig
      {

        // todo replace with call to db
        DisplayName = "N3FJP Logger",
        BaudRate = 57600,
        PortName = "com20",
        Parity = Parity.None.ToString(),
        DataBits = 8,
        Handshake = "none",
        StopBits = StopBits.One.ToString(),
        ReadTimeout = 5000,
        WriteTimeout = 500
      };
      //virtBusConf.CommPorts.Add(commPortConf);

      commPortConf = new CommPortConfig
      {

        // todo replace with call to db
        DisplayName = "ACLog Logger",
        BaudRate = 57600,
        PortName = "com19",
        Parity = Parity.None.ToString(),
        DataBits = 8,
        Handshake = "none",
        StopBits = StopBits.One.ToString(),
        ReadTimeout = 5000,
        WriteTimeout = 500
      };
      //virtBusConf.CommPorts.Add(commPortConf);

      commPortConf = new CommPortConfig
      {

        // todo replace with call to db
        DisplayName = "xyz Logger",
        BaudRate = 57600,
        PortName = "com18",
        Parity = Parity.None.ToString(),
        DataBits = 8,
        Handshake = "none",
        StopBits = StopBits.One.ToString(),
        ReadTimeout = 5000,
        WriteTimeout = 500
      };
      //virtBusConf.CommPorts.Add(commPortConf);

      return virtBusConf;

    }
  }
}
