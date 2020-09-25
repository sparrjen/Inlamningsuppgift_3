using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {

        private static readonly string _conn = "HostName=ecwin20-iothub.azure-devices.net;DeviceId=consoleApp;SharedAccessKey=aGikBmVhuL6KxoeQB+nBgG3pj22ON2vNPYM8i2jiLPY=";
        
        private static readonly DeviceClient deviceClient = 
            DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt); 
        
        
        static async Task Main(string[] args)
        {

           await DeviceService.SendMessageAsync(deviceClient);
            
            Console.ReadKey();
         
        }
    }
}
