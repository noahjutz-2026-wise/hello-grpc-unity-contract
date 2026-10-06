using Grpc.Core;
using GrpcUnity;

namespace HelloGrpcUnityContract;

public class MyGreeter : GreeterService.GreeterServiceBase
{
    public override Task<SayHelloResponse> SayHello(SayHelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new SayHelloResponse { Message = "Hello " + request.Name });
    }
}