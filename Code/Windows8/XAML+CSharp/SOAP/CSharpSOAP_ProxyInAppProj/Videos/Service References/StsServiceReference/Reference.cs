﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 11.0.50727.1
// 
namespace Videos.StsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.sapo.pt/definitions", ConfigurationName="StsServiceReference.STSSoapSecure")]
    public interface STSSoapSecure {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetPrimaryId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetPrimaryIdDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdDetailsAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetTokenAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, bool JSON);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.sapo.pt/definitions")]
    public partial class ESBCredentials : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eSBUsernameField;
        
        private string eSBPasswordField;
        
        private string eSBTokenField;
        
        private string[] eSBRolesField;
        
        private string eSBTokenTimeToLiveField;
        
        private string eSBTokenExtraInfoField;
        
        private string eSBPrimaryIdField;
        
        private string eSBUserTypeField;
        
        private string eSBCredentialsStoreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ESBUsername {
            get {
                return this.eSBUsernameField;
            }
            set {
                this.eSBUsernameField = value;
                this.RaisePropertyChanged("ESBUsername");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ESBPassword {
            get {
                return this.eSBPasswordField;
            }
            set {
                this.eSBPasswordField = value;
                this.RaisePropertyChanged("ESBPassword");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ESBToken {
            get {
                return this.eSBTokenField;
            }
            set {
                this.eSBTokenField = value;
                this.RaisePropertyChanged("ESBToken");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ESBRole", IsNullable=false)]
        public string[] ESBRoles {
            get {
                return this.eSBRolesField;
            }
            set {
                this.eSBRolesField = value;
                this.RaisePropertyChanged("ESBRoles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ESBTokenTimeToLive {
            get {
                return this.eSBTokenTimeToLiveField;
            }
            set {
                this.eSBTokenTimeToLiveField = value;
                this.RaisePropertyChanged("ESBTokenTimeToLive");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ESBTokenExtraInfo {
            get {
                return this.eSBTokenExtraInfoField;
            }
            set {
                this.eSBTokenExtraInfoField = value;
                this.RaisePropertyChanged("ESBTokenExtraInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string ESBPrimaryId {
            get {
                return this.eSBPrimaryIdField;
            }
            set {
                this.eSBPrimaryIdField = value;
                this.RaisePropertyChanged("ESBPrimaryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ESBUserType {
            get {
                return this.eSBUserTypeField;
            }
            set {
                this.eSBUserTypeField = value;
                this.RaisePropertyChanged("ESBUserType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ESBCredentialsStore {
            get {
                return this.eSBCredentialsStoreField;
            }
            set {
                this.eSBCredentialsStoreField = value;
                this.RaisePropertyChanged("ESBCredentialsStore");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.sapo.pt/definitions")]
    public partial class Attribute : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.sapo.pt/definitions")]
    public partial class UserInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string primaryIdField;
        
        private string[] eSBRolesField;
        
        private string eSBTokenField;
        
        private string groupField;
        
        private string eSBCredentialsStoreField;
        
        private string[] accountNumbersField;
        
        private Attribute[] attributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string PrimaryId {
            get {
                return this.primaryIdField;
            }
            set {
                this.primaryIdField = value;
                this.RaisePropertyChanged("PrimaryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ESBRole", IsNullable=false)]
        public string[] ESBRoles {
            get {
                return this.eSBRolesField;
            }
            set {
                this.eSBRolesField = value;
                this.RaisePropertyChanged("ESBRoles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ESBToken {
            get {
                return this.eSBTokenField;
            }
            set {
                this.eSBTokenField = value;
                this.RaisePropertyChanged("ESBToken");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
                this.RaisePropertyChanged("Group");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ESBCredentialsStore {
            get {
                return this.eSBCredentialsStoreField;
            }
            set {
                this.eSBCredentialsStoreField = value;
                this.RaisePropertyChanged("ESBCredentialsStore");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AccountNumber", IsNullable=false)]
        public string[] AccountNumbers {
            get {
                return this.accountNumbersField;
            }
            set {
                this.accountNumbersField = value;
                this.RaisePropertyChanged("AccountNumbers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Attribute[] Attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
                this.RaisePropertyChanged("Attributes");
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
    public interface STSSoapSecureChannel : Videos.StsServiceReference.STSSoapSecure, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class STSSoapSecureClient : System.ServiceModel.ClientBase<Videos.StsServiceReference.STSSoapSecure>, Videos.StsServiceReference.STSSoapSecure {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public STSSoapSecureClient() : 
                base(STSSoapSecureClient.GetDefaultBinding(), STSSoapSecureClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.STSSoapSecure.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public STSSoapSecureClient(EndpointConfiguration endpointConfiguration) : 
                base(STSSoapSecureClient.GetBindingForEndpoint(endpointConfiguration), STSSoapSecureClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public STSSoapSecureClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(STSSoapSecureClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public STSSoapSecureClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(STSSoapSecureClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public STSSoapSecureClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore) {
            return base.Channel.GetPrimaryIdAsync(ESBCredentials, UserLogin, JSON, UserType, UserLoginCredentialsStore);
        }
        
        public System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdDetailsAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore) {
            return base.Channel.GetPrimaryIdDetailsAsync(ESBCredentials, UserLogin, JSON, UserType, UserLoginCredentialsStore);
        }
        
        public System.Threading.Tasks.Task<string> GetTokenAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, bool JSON) {
            return base.Channel.GetTokenAsync(ESBCredentials, JSON);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.STSSoapSecure)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.STSSoapSecure)) {
                return new System.ServiceModel.EndpointAddress("https://services.sapo.pt/STS");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return STSSoapSecureClient.GetBindingForEndpoint(EndpointConfiguration.STSSoapSecure);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return STSSoapSecureClient.GetEndpointAddress(EndpointConfiguration.STSSoapSecure);
        }
        
        public enum EndpointConfiguration {
            
            STSSoapSecure,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.sapo.pt/definitions", ConfigurationName="StsServiceReference.STSSoap12Secure")]
    public interface STSSoap12Secure {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetPrimaryId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetPrimaryIdDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdDetailsAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sapo.pt/definitions/GetToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetTokenAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, bool JSON);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface STSSoap12SecureChannel : Videos.StsServiceReference.STSSoap12Secure, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class STSSoap12SecureClient : System.ServiceModel.ClientBase<Videos.StsServiceReference.STSSoap12Secure>, Videos.StsServiceReference.STSSoap12Secure {
        
        public STSSoap12SecureClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore) {
            return base.Channel.GetPrimaryIdAsync(ESBCredentials, UserLogin, JSON, UserType, UserLoginCredentialsStore);
        }
        
        public System.Threading.Tasks.Task<Videos.StsServiceReference.UserInfo> GetPrimaryIdDetailsAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, string UserLogin, bool JSON, string UserType, string UserLoginCredentialsStore) {
            return base.Channel.GetPrimaryIdDetailsAsync(ESBCredentials, UserLogin, JSON, UserType, UserLoginCredentialsStore);
        }
        
        public System.Threading.Tasks.Task<string> GetTokenAsync(Videos.StsServiceReference.ESBCredentials ESBCredentials, bool JSON) {
            return base.Channel.GetTokenAsync(ESBCredentials, JSON);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}