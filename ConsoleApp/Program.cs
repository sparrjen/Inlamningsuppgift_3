using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {

        private static readonly string _conn = "";
        
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt); 
        
        
        static async Task Main(string[] args)
        {

           await DeviceService.SendMessageAsync(deviceClient); 
         
        }
    }
}
