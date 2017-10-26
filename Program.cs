using Ductus.FluentDocker.Services;
using System;

namespace fluent_docker_win32exception
{
    class Program
    {
        static void Main(string[] args)
        {
            var hosts = new Hosts().Discover();
            Console.WriteLine("Number of hosts:" + hosts.Count);
            Console.ReadKey();
        }
    }
}
