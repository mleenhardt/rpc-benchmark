using System;
using Benchmark.Grpc.Common;
using Grpc.Core;

namespace Benchmark.Grpc.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 1337;
            var rpcServer = new global::Grpc.Core.Server
            {
                Services = { BenchmarkService.BindService(new BenchmarkServiceServer()) },
                Ports = { new ServerPort("localhost", port, ServerCredentials.Insecure) }
            };
            rpcServer.Start();

            Console.WriteLine("BenchmarkService server listening on port " + port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();
            rpcServer.ShutdownAsync().Wait();
        }
    }
}
