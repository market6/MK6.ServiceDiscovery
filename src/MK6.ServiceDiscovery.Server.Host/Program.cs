using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MK6.Common.Grpc.Server;
using MK6.Common.Serilog.Extensions.Configuration;
using MK6.ServiceDiscovery.Grpc;
using Serilog.Events;

namespace MK6.ServiceDiscovery.Server.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SerilogConfiguration.Configure(new SerilogConfigOptions {Level = new LogLevel(LogEventLevel.Verbose), Console = new ColoredConsoleOptions {Level = new LogLevel(LogEventLevel.Verbose)} });
            var server = GrpcServerBuilder.Create()
                            .UseSerilog()
                            .AddBinder(new PubSubStatusServiceBinder(PubSubStatusService.Descriptor, new PubSubStatusServiceImpl()))
                            .Build();

            server.Start();

            Console.ReadLine();

            server.Shutdown();
        }
    }
}
