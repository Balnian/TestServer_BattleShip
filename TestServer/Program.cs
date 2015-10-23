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
                //for (int i = 0; i < 100; i++)
                //{
                    TcpClient sdf = new TcpClient("p104-14", 8080);
                    //sdf.Connect("127.0.0.1", 8080);
                    String str = "Client " /*+ i.ToString()*/;
                    //sdf.GetStream().Write((byte[])str.,0,str.Length);
                    Console.WriteLine("Connecté: "/*+i*/);

                    TcpClient sdf2 = new TcpClient("p104-14", 8080);
                //}
                
                while (true)
                {
                    Console.WriteLine("1: " + (String)ConnUtility.ReadAndDeserialize(sdf.GetStream()));
                    Console.WriteLine("2: " + (String)ConnUtility.ReadAndDeserialize(sdf2.GetStream()));
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
