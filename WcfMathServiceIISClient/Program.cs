using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfMathServiceInterface;

namespace WcfMathServiceIISClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1, a, b;
            ChannelFactory<IMathService> mathChannel = new ChannelFactory<IMathService>("WcfMathServiceEndpoint");
            IMathService proxy = mathChannel.CreateChannel();
            while (true)
            {
                Console.WriteLine("Enter Choice:\n1. Add\n2.Substract");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Inputs");
                //Read line, and split it by whitespace into an array of strings
                string[] tokens = Console.ReadLine().Split();

                //Parse element 0
                a = int.Parse(tokens[0]);

                //Parse element 1
                b = int.Parse(tokens[1]);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result : " + proxy.Add(a, b).Result);
                        break;
                    case 2:
                        Console.WriteLine("Result : " + proxy.Substract(a, b).Result);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
