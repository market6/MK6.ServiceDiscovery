using Grpc.Core;
using MK6.Common.Grpc.Server;
using MK6.ServiceDiscovery.Grpc;
using ServiceDescriptor = Google.Protobuf.Reflection.ServiceDescriptor;

namespace MK6.ServiceDiscovery.Server.Host
{
    public class PubSubStatusServiceBinder : IServiceBinder
    {
        private readonly PubSubStatusServiceImpl _pubSubStatusService;

        public PubSubStatusServiceBinder(ServiceDescriptor descriptor, PubSubStatusServiceImpl pubSubStatusService)
        {
            Descriptor = descriptor;
            _pubSubStatusService = pubSubStatusService;
        }

        public ServerServiceDefinition Bind()
        {
            return PubSubStatusService.BindService(_pubSubStatusService);
        }

        public ServiceDescriptor Descriptor { get; }
    }
}
