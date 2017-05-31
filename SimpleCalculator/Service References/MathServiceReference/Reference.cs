﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleCalculator.MathServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfMathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsFirstBiggerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsFirstBigger {
            get {
                return this.IsFirstBiggerField;
            }
            set {
                if ((this.IsFirstBiggerField.Equals(value) != true)) {
                    this.IsFirstBiggerField = value;
                    this.RaisePropertyChanged("IsFirstBigger");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        SimpleCalculator.MathServiceReference.CompositeType Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<SimpleCalculator.MathServiceReference.CompositeType> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Substract", ReplyAction="http://tempuri.org/IMathService/SubstractResponse")]
        SimpleCalculator.MathServiceReference.CompositeType Substract(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Substract", ReplyAction="http://tempuri.org/IMathService/SubstractResponse")]
        System.Threading.Tasks.Task<SimpleCalculator.MathServiceReference.CompositeType> SubstractAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : SimpleCalculator.MathServiceReference.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<SimpleCalculator.MathServiceReference.IMathService>, SimpleCalculator.MathServiceReference.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SimpleCalculator.MathServiceReference.CompositeType Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<SimpleCalculator.MathServiceReference.CompositeType> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public SimpleCalculator.MathServiceReference.CompositeType Substract(int a, int b) {
            return base.Channel.Substract(a, b);
        }
        
        public System.Threading.Tasks.Task<SimpleCalculator.MathServiceReference.CompositeType> SubstractAsync(int a, int b) {
            return base.Channel.SubstractAsync(a, b);
        }
    }
}
