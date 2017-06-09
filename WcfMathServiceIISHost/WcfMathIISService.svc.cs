using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfMathServiceInterface;

namespace WcfMathServiceIISHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfMathIISService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfMathIISService.svc or WcfMathIISService.svc.cs at the Solution Explorer and start debugging.
    public class WcfMathIISService : IMathService
    {
        public CompositeType Add(int a, int b)
        {
            return new CompositeType
            {
                Result = a + b,
                IsFirstBigger = a > b ? true : false
            };
        }

        public CompositeType Substract(int a, int b)
        {
            return new CompositeType
            {
                Result = Math.Abs(a - b),
                IsFirstBigger = a > b ? true : false
            };
        }
    }
}
