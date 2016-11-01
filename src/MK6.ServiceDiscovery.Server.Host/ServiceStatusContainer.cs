using System.Collections.Concurrent;
using MK6.ServiceDiscovery.Grpc;

namespace MK6.ServiceDiscovery.Server.Host
{
    public static class ServiceStatusContainer
    {
        public static ConcurrentDictionary<string, ServiceStatusRequest> Statuses { get; } = new ConcurrentDictionary<string, ServiceStatusRequest>();
        public static ConcurrentQueue<ServiceStatusRequest> Queue { get; } = new ConcurrentQueue<ServiceStatusRequest>();
    }
}
