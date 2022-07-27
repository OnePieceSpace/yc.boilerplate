using System;

namespace YC.Tools.DockerMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string host = "59.110.238.45";
            int port = 22022;
            string userName = "root";
            string pwd = "ahvei}G3ohd6Hoi";
            var service = new DockerService(new SshConfig() { Host = host, Port = port, UserName = userName, Password = pwd });
            Console.WriteLine($"连接主机{host}:{port}成功.");
            service.DockerConatainsStatsMonitor();
         
            Console.ReadKey();
        }
    }
}
