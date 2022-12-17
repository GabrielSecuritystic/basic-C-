using System;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

 private static string IP = "";

    static void Main(string[] args)
    {
        UserInput();
        PortScan();
        Console.ReadKey();
    }

    private static void UserInput()
    {
        Console.WriteLine("IP Address:", Color.Lime);
        IP = Console.ReadLine();
    }

    private static void PortScan()
    {
        Console.Clear();
        TcpClient Scan = new TcpClient();
       foreach(int s in Ports)
{
    using (TcpClient Scan = new TcpClient())
    {
        try
        {
            Scan.Connect(IP, s);
            Console.WriteLine($"[{s}] | OPEN", Color.Green);
        }
        catch
        {
            Console.WriteLine($"[{s}] | CLOSED", Color.Red);
        }
    }
}
}

    private static int[] Ports = new int[]
    {
        8080,
        51372,
        31146,
        4145
    };