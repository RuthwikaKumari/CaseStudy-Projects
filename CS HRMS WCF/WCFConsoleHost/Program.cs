using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEmpServiceLib; //For WCF interface and class
using System.ServiceModel; //For ServiceHost Class

namespace WCFConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFEmpServiceLib.EmpService));
            host.Open();
            Console.WriteLine("Service has started");
            Console.ReadLine();
            Console.WriteLine("Service has stopped");
        }
    }
}
