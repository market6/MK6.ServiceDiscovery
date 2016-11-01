using System.Threading.Tasks;
using Grpc.Core;
using MK6.ServiceDiscovery.Grpc;

namespace MK6.ServiceDiscovery.Server.Host
{
    public class PubSubStatusServiceImpl : PubSubStatusService.PubSubStatusServiceBase
    {

        public override Task<ServiceStatusResponse> Publish(ServiceStatusRequest request, ServerCallContext context)
        {
            ServiceStatusContainer.Statuses.AddOrUpdate(request.ServiceDescriptor.Id, request, (s, statusRequest) => request);
            ServiceStatusContainer.Queue.Enqueue(request);
            return Task.FromResult(new ServiceStatusResponse());
        }
    }
}
