using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfMathServiceLibrary
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        CompositeType Add(int a, int b);

        [OperationContract]
        CompositeType Substract(int a, int b);
    }

    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public int Result { get; set; }

        [DataMember]
        public bool IsFirstBigger { get; set; }
    }
}
