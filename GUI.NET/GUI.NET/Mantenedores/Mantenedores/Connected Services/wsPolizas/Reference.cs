﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenedores.wsPolizas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsPolizas.wsPolizasSoap")]
    public interface wsPolizasSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPolizas", ReplyAction="*")]
        int GetPolizas(int id_tipo_seguro, int cantidad_personas, int numero_dias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPolizas", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetPolizasAsync(int id_tipo_seguro, int cantidad_personas, int numero_dias);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsPolizasSoapChannel : Mantenedores.wsPolizas.wsPolizasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsPolizasSoapClient : System.ServiceModel.ClientBase<Mantenedores.wsPolizas.wsPolizasSoap>, Mantenedores.wsPolizas.wsPolizasSoap {
        
        public wsPolizasSoapClient() {
        }
        
        public wsPolizasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsPolizasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPolizasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPolizasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetPolizas(int id_tipo_seguro, int cantidad_personas, int numero_dias) {
            return base.Channel.GetPolizas(id_tipo_seguro, cantidad_personas, numero_dias);
        }
        
        public System.Threading.Tasks.Task<int> GetPolizasAsync(int id_tipo_seguro, int cantidad_personas, int numero_dias) {
            return base.Channel.GetPolizasAsync(id_tipo_seguro, cantidad_personas, numero_dias);
        }
    }
}
