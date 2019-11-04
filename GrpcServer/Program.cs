using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace GrpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new CategoryGreeter.CategoryGreeterClient(channel);
            var list = client.List(new Empty());

            var category = client.Get(new CategoryId { Id = 2 });

            var insert = client.Insert(new Category { Id = 55, Name = "test" });


            //var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(
            //                  new HelloRequest { Name = "selam" });

            //Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }
}
