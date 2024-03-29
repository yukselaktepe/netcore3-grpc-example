// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/category.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class CategoryGreeter
  {
    static readonly string __ServiceName = "categories.CategoryGreeter";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.CategoryList> __Marshaller_categories_CategoryList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.CategoryList.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Category> __Marshaller_categories_Category = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Category.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.CategoryId> __Marshaller_categories_CategoryId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.CategoryId.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.CategoryList> __Method_List = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.CategoryList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_categories_CategoryList);

    static readonly grpc::Method<global::GrpcService.Category, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Insert = new grpc::Method<global::GrpcService.Category, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_categories_Category,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::GrpcService.CategoryId, global::GrpcService.Category> __Method_Get = new grpc::Method<global::GrpcService.CategoryId, global::GrpcService.Category>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_categories_CategoryId,
        __Marshaller_categories_Category);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CategoryGreeter</summary>
    [grpc::BindServiceMethod(typeof(CategoryGreeter), "BindService")]
    public abstract partial class CategoryGreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.CategoryList> List(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Insert(global::GrpcService.Category request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Category> Get(global::GrpcService.CategoryId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CategoryGreeter</summary>
    public partial class CategoryGreeterClient : grpc::ClientBase<CategoryGreeterClient>
    {
      /// <summary>Creates a new client for CategoryGreeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CategoryGreeterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CategoryGreeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CategoryGreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CategoryGreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CategoryGreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.CategoryList List(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.CategoryList List(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.CategoryList> ListAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.CategoryList> ListAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Insert(global::GrpcService.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Insert(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Insert(global::GrpcService.Category request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Insert, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> InsertAsync(global::GrpcService.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> InsertAsync(global::GrpcService.Category request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Insert, null, options, request);
      }
      public virtual global::GrpcService.Category Get(global::GrpcService.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Category Get(global::GrpcService.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Category> GetAsync(global::GrpcService.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Category> GetAsync(global::GrpcService.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CategoryGreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CategoryGreeterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CategoryGreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_List, serviceImpl.List)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_Get, serviceImpl.Get).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CategoryGreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_List, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.CategoryList>(serviceImpl.List));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Category, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CategoryId, global::GrpcService.Category>(serviceImpl.Get));
    }

  }
}
#endregion
