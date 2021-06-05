using System;
using System.Threading.Tasks;
using Grpc.Core;


namespace GrpcClient_DotNet
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
            var client = new GrpcHost.Greeter.GreeterClient(channel);
            var response = client.SayHello(new GrpcHost.HelloRequest() { Name = "Cristiano" });
            Console.WriteLine(response.Message);
            await channel.ShutdownAsync();
        }
    }
}