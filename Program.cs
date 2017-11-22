using Ductus.FluentDocker.Extensions.Utils;
using Ductus.FluentDocker.Services;
using System;

namespace fluent_docker_win32exception
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var r = new DockerBinariesResolver();
            Console.WriteLine("docker        : " + (r.MainDockerClient.FqPath ?? "not found"));
            Console.WriteLine("docker-compose: " + (r.MainDockerCompose.FqPath ?? "not found"));
            // Console.WriteLine("docker-machine: " + (r.MainDockerMachine.FqPath ?? "not found"));

            var hosts = new Hosts().Discover();
            Console.WriteLine("Number of hosts:" + hosts.Count);
            Console.ReadKey();
        }
    }
}
