using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCfAssnLibrary;

namespace AssnWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCfAssnLibrary.AssnService));
            host.Open();
            Console.WriteLine("Service has started");
            Console.ReadLine();
        }
    }
}
