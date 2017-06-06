using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfMathService;

namespace WcfMathService
{
    public class MathService : IMathService
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
