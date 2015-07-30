﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frmSerialPorts
{
    /// <summary>
    /// 串口数据位列表(5,6,7,8)
    /// </summary>
    public enum SerialPortDatabits : int
    {
        FiveBits = 5,
        SixBits = 6,
        SeventBits = 7,
        EightBits = 8
    }
    public enum SerialPortBaudRates : int
    {
        BaudRate_75 = 75,
        BaudRate_110 = 110,
        BaudRate_150= 150,
        BaudRate_300= 300,
        BaudRate_600= 600,
        BaudRate_1200= 1200,
        BaudRate_2400= 2400,
        BaudRate_4800= 4800,
        BaudRate_9600= 9600,
        BaudRate_14400= 14400,
        BaudRate_19200= 19200,
        BaudRate_28800= 28800,
        BaudRate_38400= 38400,
        BaudRate_56000 = 56000,
        BaudRate_57600= 57600,
        BaudRate_115200= 115200,
        BaudRate_128000= 128000,
        BaudRate_230400= 230400,
        BaudRate_256000= 256000
    }
    public class api
    {

    }
}
