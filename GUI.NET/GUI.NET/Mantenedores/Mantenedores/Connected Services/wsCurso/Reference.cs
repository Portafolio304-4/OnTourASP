﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenedores.wsCurso {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Curso", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Curso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LetraField;
        
        private int GradoField;
        
        private int Id_colegioField;
        
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
        public string Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelField, value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Letra {
            get {
                return this.LetraField;
            }
            set {
                if ((object.ReferenceEquals(this.LetraField, value) != true)) {
                    this.LetraField = value;
                    this.RaisePropertyChanged("Letra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Grado {
            get {
                return this.GradoField;
            }
            set {
                if ((this.GradoField.Equals(value) != true)) {
                    this.GradoField = value;
                    this.RaisePropertyChanged("Grado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Id_colegio {
            get {
                return this.Id_colegioField;
            }
            set {
                if ((this.Id_colegioField.Equals(value) != true)) {
                    this.Id_colegioField = value;
                    this.RaisePropertyChanged("Id_colegio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsCurso.wsCursoSoap")]
    public interface wsCursoSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ReadAllByColegioResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAllByColegio", ReplyAction="*")]
        Mantenedores.wsCurso.ReadAllByColegioResponse ReadAllByColegio(Mantenedores.wsCurso.ReadAllByColegioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAllByColegio", ReplyAction="*")]
        System.Threading.Tasks.Task<Mantenedores.wsCurso.ReadAllByColegioResponse> ReadAllByColegioAsync(Mantenedores.wsCurso.ReadAllByColegioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento rut del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VerifyApoderadoInCurso", ReplyAction="*")]
        Mantenedores.wsCurso.VerifyApoderadoInCursoResponse VerifyApoderadoInCurso(Mantenedores.wsCurso.VerifyApoderadoInCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VerifyApoderadoInCurso", ReplyAction="*")]
        System.Threading.Tasks.Task<Mantenedores.wsCurso.VerifyApoderadoInCursoResponse> VerifyApoderadoInCursoAsync(Mantenedores.wsCurso.VerifyApoderadoInCursoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllByColegioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllByColegio", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsCurso.ReadAllByColegioRequestBody Body;
        
        public ReadAllByColegioRequest() {
        }
        
        public ReadAllByColegioRequest(Mantenedores.wsCurso.ReadAllByColegioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadAllByColegioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public ReadAllByColegioRequestBody() {
        }
        
        public ReadAllByColegioRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllByColegioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllByColegioResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsCurso.ReadAllByColegioResponseBody Body;
        
        public ReadAllByColegioResponse() {
        }
        
        public ReadAllByColegioResponse(Mantenedores.wsCurso.ReadAllByColegioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadAllByColegioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Mantenedores.wsCurso.Curso[] ReadAllByColegioResult;
        
        public ReadAllByColegioResponseBody() {
        }
        
        public ReadAllByColegioResponseBody(Mantenedores.wsCurso.Curso[] ReadAllByColegioResult) {
            this.ReadAllByColegioResult = ReadAllByColegioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyApoderadoInCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyApoderadoInCurso", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsCurso.VerifyApoderadoInCursoRequestBody Body;
        
        public VerifyApoderadoInCursoRequest() {
        }
        
        public VerifyApoderadoInCursoRequest(Mantenedores.wsCurso.VerifyApoderadoInCursoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VerifyApoderadoInCursoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string rut;
        
        public VerifyApoderadoInCursoRequestBody() {
        }
        
        public VerifyApoderadoInCursoRequestBody(int id, string rut) {
            this.id = id;
            this.rut = rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyApoderadoInCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyApoderadoInCursoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsCurso.VerifyApoderadoInCursoResponseBody Body;
        
        public VerifyApoderadoInCursoResponse() {
        }
        
        public VerifyApoderadoInCursoResponse(Mantenedores.wsCurso.VerifyApoderadoInCursoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class VerifyApoderadoInCursoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool VerifyApoderadoInCursoResult;
        
        public VerifyApoderadoInCursoResponseBody() {
        }
        
        public VerifyApoderadoInCursoResponseBody(bool VerifyApoderadoInCursoResult) {
            this.VerifyApoderadoInCursoResult = VerifyApoderadoInCursoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsCursoSoapChannel : Mantenedores.wsCurso.wsCursoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsCursoSoapClient : System.ServiceModel.ClientBase<Mantenedores.wsCurso.wsCursoSoap>, Mantenedores.wsCurso.wsCursoSoap {
        
        public wsCursoSoapClient() {
        }
        
        public wsCursoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsCursoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsCursoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsCursoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mantenedores.wsCurso.ReadAllByColegioResponse Mantenedores.wsCurso.wsCursoSoap.ReadAllByColegio(Mantenedores.wsCurso.ReadAllByColegioRequest request) {
            return base.Channel.ReadAllByColegio(request);
        }
        
        public Mantenedores.wsCurso.Curso[] ReadAllByColegio(int id) {
            Mantenedores.wsCurso.ReadAllByColegioRequest inValue = new Mantenedores.wsCurso.ReadAllByColegioRequest();
            inValue.Body = new Mantenedores.wsCurso.ReadAllByColegioRequestBody();
            inValue.Body.id = id;
            Mantenedores.wsCurso.ReadAllByColegioResponse retVal = ((Mantenedores.wsCurso.wsCursoSoap)(this)).ReadAllByColegio(inValue);
            return retVal.Body.ReadAllByColegioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mantenedores.wsCurso.ReadAllByColegioResponse> Mantenedores.wsCurso.wsCursoSoap.ReadAllByColegioAsync(Mantenedores.wsCurso.ReadAllByColegioRequest request) {
            return base.Channel.ReadAllByColegioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mantenedores.wsCurso.ReadAllByColegioResponse> ReadAllByColegioAsync(int id) {
            Mantenedores.wsCurso.ReadAllByColegioRequest inValue = new Mantenedores.wsCurso.ReadAllByColegioRequest();
            inValue.Body = new Mantenedores.wsCurso.ReadAllByColegioRequestBody();
            inValue.Body.id = id;
            return ((Mantenedores.wsCurso.wsCursoSoap)(this)).ReadAllByColegioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mantenedores.wsCurso.VerifyApoderadoInCursoResponse Mantenedores.wsCurso.wsCursoSoap.VerifyApoderadoInCurso(Mantenedores.wsCurso.VerifyApoderadoInCursoRequest request) {
            return base.Channel.VerifyApoderadoInCurso(request);
        }
        
        public bool VerifyApoderadoInCurso(int id, string rut) {
            Mantenedores.wsCurso.VerifyApoderadoInCursoRequest inValue = new Mantenedores.wsCurso.VerifyApoderadoInCursoRequest();
            inValue.Body = new Mantenedores.wsCurso.VerifyApoderadoInCursoRequestBody();
            inValue.Body.id = id;
            inValue.Body.rut = rut;
            Mantenedores.wsCurso.VerifyApoderadoInCursoResponse retVal = ((Mantenedores.wsCurso.wsCursoSoap)(this)).VerifyApoderadoInCurso(inValue);
            return retVal.Body.VerifyApoderadoInCursoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mantenedores.wsCurso.VerifyApoderadoInCursoResponse> Mantenedores.wsCurso.wsCursoSoap.VerifyApoderadoInCursoAsync(Mantenedores.wsCurso.VerifyApoderadoInCursoRequest request) {
            return base.Channel.VerifyApoderadoInCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mantenedores.wsCurso.VerifyApoderadoInCursoResponse> VerifyApoderadoInCursoAsync(int id, string rut) {
            Mantenedores.wsCurso.VerifyApoderadoInCursoRequest inValue = new Mantenedores.wsCurso.VerifyApoderadoInCursoRequest();
            inValue.Body = new Mantenedores.wsCurso.VerifyApoderadoInCursoRequestBody();
            inValue.Body.id = id;
            inValue.Body.rut = rut;
            return ((Mantenedores.wsCurso.wsCursoSoap)(this)).VerifyApoderadoInCursoAsync(inValue);
        }
    }
}