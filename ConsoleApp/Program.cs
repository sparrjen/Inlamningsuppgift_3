using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {

        private static readonly string _conn = "HostName=ecwin20-iothub.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=8087yP5qbfLrLRgl7bl7Fn12pLiIGzcO9b8TY62TQCo=";
        
        private static readonly DeviceClient deviceClient = 
            DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt); 
        
        
        static async Task Main(string[] args)
        {

           await DeviceService.SendMessageAsync(deviceClient);
            
            Console.ReadKey();
         
        }
    }
}
