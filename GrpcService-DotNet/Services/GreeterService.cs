using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService_DotNet
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            //context: parecido com o HttpContext
            return new HelloReply
            {
                Name = "Response",
                Message = "Hello " + request.Name
            };
        }

        public override Task<Bye> SayBye(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new Bye() {Message = "Vlw Flows"});
        }
    }
}