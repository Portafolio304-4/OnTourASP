﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenedores.wsColegio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Colegio", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Colegio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        private int TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((this.TelefonoField.Equals(value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsColegio.wsColegioSoap")]
    public interface wsColegioSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ReadAllNamesAndIdsResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAllNamesAndIds", ReplyAction="*")]
        Mantenedores.wsColegio.ReadAllNamesAndIdsResponse ReadAllNamesAndIds(Mantenedores.wsColegio.ReadAllNamesAndIdsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAllNamesAndIds", ReplyAction="*")]
        System.Threading.Tasks.Task<Mantenedores.wsColegio.ReadAllNamesAndIdsResponse> ReadAllNamesAndIdsAsync(Mantenedores.wsColegio.ReadAllNamesAndIdsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllNamesAndIdsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllNamesAndIds", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsColegio.ReadAllNamesAndIdsRequestBody Body;
        
        public ReadAllNamesAndIdsRequest() {
        }
        
        public ReadAllNamesAndIdsRequest(Mantenedores.wsColegio.ReadAllNamesAndIdsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReadAllNamesAndIdsRequestBody {
        
        public ReadAllNamesAndIdsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllNamesAndIdsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllNamesAndIdsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsColegio.ReadAllNamesAndIdsResponseBody Body;
        
        public ReadAllNamesAndIdsResponse() {
        }
        
        public ReadAllNamesAndIdsResponse(Mantenedores.wsColegio.ReadAllNamesAndIdsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadAllNamesAndIdsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Mantenedores.wsColegio.Colegio[] ReadAllNamesAndIdsResult;
        
        public ReadAllNamesAndIdsResponseBody() {
        }
        
        public ReadAllNamesAndIdsResponseBody(Mantenedores.wsColegio.Colegio[] ReadAllNamesAndIdsResult) {
            this.ReadAllNamesAndIdsResult = ReadAllNamesAndIdsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsColegioSoapChannel : Mantenedores.wsColegio.wsColegioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsColegioSoapClient : System.ServiceModel.ClientBase<Mantenedores.wsColegio.wsColegioSoap>, Mantenedores.wsColegio.wsColegioSoap {
        
        public wsColegioSoapClient() {
        }
        
        public wsColegioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsColegioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsColegioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsColegioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mantenedores.wsColegio.ReadAllNamesAndIdsResponse Mantenedores.wsColegio.wsColegioSoap.ReadAllNamesAndIds(Mantenedores.wsColegio.ReadAllNamesAndIdsRequest request) {
            return base.Channel.ReadAllNamesAndIds(request);
        }
        
        public Mantenedores.wsColegio.Colegio[] ReadAllNamesAndIds() {
            Mantenedores.wsColegio.ReadAllNamesAndIdsRequest inValue = new Mantenedores.wsColegio.ReadAllNamesAndIdsRequest();
            inValue.Body = new Mantenedores.wsColegio.ReadAllNamesAndIdsRequestBody();
            Mantenedores.wsColegio.ReadAllNamesAndIdsResponse retVal = ((Mantenedores.wsColegio.wsColegioSoap)(this)).ReadAllNamesAndIds(inValue);
            return retVal.Body.ReadAllNamesAndIdsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mantenedores.wsColegio.ReadAllNamesAndIdsResponse> Mantenedores.wsColegio.wsColegioSoap.ReadAllNamesAndIdsAsync(Mantenedores.wsColegio.ReadAllNamesAndIdsRequest request) {
            return base.Channel.ReadAllNamesAndIdsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mantenedores.wsColegio.ReadAllNamesAndIdsResponse> ReadAllNamesAndIdsAsync() {
            Mantenedores.wsColegio.ReadAllNamesAndIdsRequest inValue = new Mantenedores.wsColegio.ReadAllNamesAndIdsRequest();
            inValue.Body = new Mantenedores.wsColegio.ReadAllNamesAndIdsRequestBody();
            return ((Mantenedores.wsColegio.wsColegioSoap)(this)).ReadAllNamesAndIdsAsync(inValue);
        }
    }
}
