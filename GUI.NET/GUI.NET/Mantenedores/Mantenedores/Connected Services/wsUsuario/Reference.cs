﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenedores.wsUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string User_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        private int Id_tipo_usuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
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
        public string User_name {
            get {
                return this.User_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.User_nameField, value) != true)) {
                    this.User_nameField = value;
                    this.RaisePropertyChanged("User_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Id_tipo_usuario {
            get {
                return this.Id_tipo_usuarioField;
            }
            set {
                if ((this.Id_tipo_usuarioField.Equals(value) != true)) {
                    this.Id_tipo_usuarioField = value;
                    this.RaisePropertyChanged("Id_tipo_usuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsUsuario.wsUsuarioSoap")]
    public interface wsUsuarioSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento user_name del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Authenticate", ReplyAction="*")]
        Mantenedores.wsUsuario.AuthenticateResponse Authenticate(Mantenedores.wsUsuario.AuthenticateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Authenticate", ReplyAction="*")]
        System.Threading.Tasks.Task<Mantenedores.wsUsuario.AuthenticateResponse> AuthenticateAsync(Mantenedores.wsUsuario.AuthenticateRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento user_name del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        Mantenedores.wsUsuario.CreateResponse Create(Mantenedores.wsUsuario.CreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        System.Threading.Tasks.Task<Mantenedores.wsUsuario.CreateResponse> CreateAsync(Mantenedores.wsUsuario.CreateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Authenticate", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsUsuario.AuthenticateRequestBody Body;
        
        public AuthenticateRequest() {
        }
        
        public AuthenticateRequest(Mantenedores.wsUsuario.AuthenticateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public AuthenticateRequestBody() {
        }
        
        public AuthenticateRequestBody(string user_name, string password) {
            this.user_name = user_name;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsUsuario.AuthenticateResponseBody Body;
        
        public AuthenticateResponse() {
        }
        
        public AuthenticateResponse(Mantenedores.wsUsuario.AuthenticateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Mantenedores.wsUsuario.Usuario AuthenticateResult;
        
        public AuthenticateResponseBody() {
        }
        
        public AuthenticateResponseBody(Mantenedores.wsUsuario.Usuario AuthenticateResult) {
            this.AuthenticateResult = AuthenticateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Create", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsUsuario.CreateRequestBody Body;
        
        public CreateRequest() {
        }
        
        public CreateRequest(Mantenedores.wsUsuario.CreateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int id_tipo_usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string email;
        
        public CreateRequestBody() {
        }
        
        public CreateRequestBody(string user_name, string password, int id_tipo_usuario, string email) {
            this.user_name = user_name;
            this.password = password;
            this.id_tipo_usuario = id_tipo_usuario;
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mantenedores.wsUsuario.CreateResponseBody Body;
        
        public CreateResponse() {
        }
        
        public CreateResponse(Mantenedores.wsUsuario.CreateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateResult;
        
        public CreateResponseBody() {
        }
        
        public CreateResponseBody(bool CreateResult) {
            this.CreateResult = CreateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsUsuarioSoapChannel : Mantenedores.wsUsuario.wsUsuarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsUsuarioSoapClient : System.ServiceModel.ClientBase<Mantenedores.wsUsuario.wsUsuarioSoap>, Mantenedores.wsUsuario.wsUsuarioSoap {
        
        public wsUsuarioSoapClient() {
        }
        
        public wsUsuarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsUsuarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsUsuarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsUsuarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mantenedores.wsUsuario.AuthenticateResponse Mantenedores.wsUsuario.wsUsuarioSoap.Authenticate(Mantenedores.wsUsuario.AuthenticateRequest request) {
            return base.Channel.Authenticate(request);
        }
        
        public Mantenedores.wsUsuario.Usuario Authenticate(string user_name, string password) {
            Mantenedores.wsUsuario.AuthenticateRequest inValue = new Mantenedores.wsUsuario.AuthenticateRequest();
            inValue.Body = new Mantenedores.wsUsuario.AuthenticateRequestBody();
            inValue.Body.user_name = user_name;
            inValue.Body.password = password;
            Mantenedores.wsUsuario.AuthenticateResponse retVal = ((Mantenedores.wsUsuario.wsUsuarioSoap)(this)).Authenticate(inValue);
            return retVal.Body.AuthenticateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mantenedores.wsUsuario.AuthenticateResponse> Mantenedores.wsUsuario.wsUsuarioSoap.AuthenticateAsync(Mantenedores.wsUsuario.AuthenticateRequest request) {
            return base.Channel.AuthenticateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mantenedores.wsUsuario.AuthenticateResponse> AuthenticateAsync(string user_name, string password) {
            Mantenedores.wsUsuario.AuthenticateRequest inValue = new Mantenedores.wsUsuario.AuthenticateRequest();
            inValue.Body = new Mantenedores.wsUsuario.AuthenticateRequestBody();
            inValue.Body.user_name = user_name;
            inValue.Body.password = password;
            return ((Mantenedores.wsUsuario.wsUsuarioSoap)(this)).AuthenticateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mantenedores.wsUsuario.CreateResponse Mantenedores.wsUsuario.wsUsuarioSoap.Create(Mantenedores.wsUsuario.CreateRequest request) {
            return base.Channel.Create(request);
        }
        
        public bool Create(string user_name, string password, int id_tipo_usuario, string email) {
            Mantenedores.wsUsuario.CreateRequest inValue = new Mantenedores.wsUsuario.CreateRequest();
            inValue.Body = new Mantenedores.wsUsuario.CreateRequestBody();
            inValue.Body.user_name = user_name;
            inValue.Body.password = password;
            inValue.Body.id_tipo_usuario = id_tipo_usuario;
            inValue.Body.email = email;
            Mantenedores.wsUsuario.CreateResponse retVal = ((Mantenedores.wsUsuario.wsUsuarioSoap)(this)).Create(inValue);
            return retVal.Body.CreateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mantenedores.wsUsuario.CreateResponse> Mantenedores.wsUsuario.wsUsuarioSoap.CreateAsync(Mantenedores.wsUsuario.CreateRequest request) {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mantenedores.wsUsuario.CreateResponse> CreateAsync(string user_name, string password, int id_tipo_usuario, string email) {
            Mantenedores.wsUsuario.CreateRequest inValue = new Mantenedores.wsUsuario.CreateRequest();
            inValue.Body = new Mantenedores.wsUsuario.CreateRequestBody();
            inValue.Body.user_name = user_name;
            inValue.Body.password = password;
            inValue.Body.id_tipo_usuario = id_tipo_usuario;
            inValue.Body.email = email;
            return ((Mantenedores.wsUsuario.wsUsuarioSoap)(this)).CreateAsync(inValue);
        }
    }
}
