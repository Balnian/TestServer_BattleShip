using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient sdf = new TcpClient("p104-14", 1521);
                sdf.Connect("127.0.0.1", 4242);
                Console.WriteLine("Connecté?");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

        }
    }
}
