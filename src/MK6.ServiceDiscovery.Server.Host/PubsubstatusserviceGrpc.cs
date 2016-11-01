// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: pubsubstatusservice.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace MK6.ServiceDiscovery.Grpc {
  public static class PubSubStatusService
  {
    static readonly string __ServiceName = "MK6.ServiceDiscovery.Grpc.PubSubStatusService";

    static readonly Marshaller<global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest> __Marshaller_ServiceStatusRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest.Parser.ParseFrom);
    static readonly Marshaller<global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse> __Marshaller_ServiceStatusResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse.Parser.ParseFrom);

    static readonly Method<global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest, global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse> __Method_Publish = new Method<global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest, global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse>(
        MethodType.Unary,
        __ServiceName,
        "Publish",
        __Marshaller_ServiceStatusRequest,
        __Marshaller_ServiceStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MK6.ServiceDiscovery.Grpc.PubsubstatusserviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PubSubStatusService</summary>
    public abstract class PubSubStatusServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse> Publish(global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PubSubStatusService</summary>
    public class PubSubStatusServiceClient : ClientBase<PubSubStatusServiceClient>
    {
      /// <summary>Creates a new client for PubSubStatusService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PubSubStatusServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PubSubStatusService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PubSubStatusServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PubSubStatusServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PubSubStatusServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse Publish(global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Publish(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse Publish(global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Publish, null, options, request);
      }
      public virtual AsyncUnaryCall<global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse> PublishAsync(global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PublishAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::MK6.ServiceDiscovery.Grpc.ServiceStatusResponse> PublishAsync(global::MK6.ServiceDiscovery.Grpc.ServiceStatusRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Publish, null, options, request);
      }
      protected override PubSubStatusServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PubSubStatusServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(PubSubStatusServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Publish, serviceImpl.Publish).Build();
    }

  }
}
#endregion