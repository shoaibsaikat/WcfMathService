using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfMathServiceLibrary;

namespace WcfMathServiceConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(MathService));

            //Start the Service
            host.Open();
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press  key to stop");
            Console.ReadLine();
        }
    }
}
