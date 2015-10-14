using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient sdf = new TcpClient("p104-14", 8080);
                //sdf.Connect("127.0.0.1", 8080);
                Console.WriteLine("Connecté?");
                while (true)
                {
                    Thread.Sleep(250);
                };
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

        }
    }
}
