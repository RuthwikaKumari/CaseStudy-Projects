﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssnWCFWebClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/AssnDAL_Lib")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AssnWCFWebClient.ServiceReference1.Category CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Category_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Product_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_NameField;
        
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
        public AssnWCFWebClient.ServiceReference1.Category Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category_ID {
            get {
                return this.Category_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.Category_IDField, value) != true)) {
                    this.Category_IDField = value;
                    this.RaisePropertyChanged("Category_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Product_ID {
            get {
                return this.Product_IDField;
            }
            set {
                if ((this.Product_IDField.Equals(value) != true)) {
                    this.Product_IDField = value;
                    this.RaisePropertyChanged("Product_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Product_Name {
            get {
                return this.Product_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_NameField, value) != true)) {
                    this.Product_NameField = value;
                    this.RaisePropertyChanged("Product_Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/AssnDAL_Lib")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Category_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Category_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AssnWCFWebClient.ServiceReference1.Product[] ProductsField;
        
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
        public string Category_ID {
            get {
                return this.Category_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.Category_IDField, value) != true)) {
                    this.Category_IDField = value;
                    this.RaisePropertyChanged("Category_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category_Name {
            get {
                return this.Category_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Category_NameField, value) != true)) {
                    this.Category_NameField = value;
                    this.RaisePropertyChanged("Category_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AssnWCFWebClient.ServiceReference1.Product[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAssnService")]
    public interface IAssnService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssnService/GetProductsonId", ReplyAction="http://tempuri.org/IAssnService/GetProductsonIdResponse")]
        AssnWCFWebClient.ServiceReference1.Product[] GetProductsonId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssnService/GetProductsonId", ReplyAction="http://tempuri.org/IAssnService/GetProductsonIdResponse")]
        System.Threading.Tasks.Task<AssnWCFWebClient.ServiceReference1.Product[]> GetProductsonIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssnService/GetCategoryIds", ReplyAction="http://tempuri.org/IAssnService/GetCategoryIdsResponse")]
        string[] GetCategoryIds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssnService/GetCategoryIds", ReplyAction="http://tempuri.org/IAssnService/GetCategoryIdsResponse")]
        System.Threading.Tasks.Task<string[]> GetCategoryIdsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAssnServiceChannel : AssnWCFWebClient.ServiceReference1.IAssnService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AssnServiceClient : System.ServiceModel.ClientBase<AssnWCFWebClient.ServiceReference1.IAssnService>, AssnWCFWebClient.ServiceReference1.IAssnService {
        
        public AssnServiceClient() {
        }
        
        public AssnServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AssnServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AssnServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AssnServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AssnWCFWebClient.ServiceReference1.Product[] GetProductsonId(string id) {
            return base.Channel.GetProductsonId(id);
        }
        
        public System.Threading.Tasks.Task<AssnWCFWebClient.ServiceReference1.Product[]> GetProductsonIdAsync(string id) {
            return base.Channel.GetProductsonIdAsync(id);
        }
        
        public string[] GetCategoryIds() {
            return base.Channel.GetCategoryIds();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCategoryIdsAsync() {
            return base.Channel.GetCategoryIdsAsync();
        }
    }
}
