﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank.WebApplication.ServiceBank {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BankBE", Namespace="http://schemas.datacontract.org/2004/07/Bank.Entities")]
    [System.SerializableAttribute()]
    public partial class BankBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBanco {
            get {
                return this.IdBancoField;
            }
            set {
                if ((this.IdBancoField.Equals(value) != true)) {
                    this.IdBancoField = value;
                    this.RaisePropertyChanged("IdBanco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BranchBE", Namespace="http://schemas.datacontract.org/2004/07/Bank.Entities")]
    [System.SerializableAttribute()]
    public partial class BranchBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSucursalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBanco {
            get {
                return this.IdBancoField;
            }
            set {
                if ((this.IdBancoField.Equals(value) != true)) {
                    this.IdBancoField = value;
                    this.RaisePropertyChanged("IdBanco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSucursal {
            get {
                return this.IdSucursalField;
            }
            set {
                if ((this.IdSucursalField.Equals(value) != true)) {
                    this.IdSucursalField = value;
                    this.RaisePropertyChanged("IdSucursal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderBE", Namespace="http://schemas.datacontract.org/2004/07/Bank.Entities")]
    [System.SerializableAttribute()]
    public partial class OrderBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaPagoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdOrdenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSucursalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MonedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MontoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TxtSucursalField;
        
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
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaPago {
            get {
                return this.FechaPagoField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaPagoField, value) != true)) {
                    this.FechaPagoField = value;
                    this.RaisePropertyChanged("FechaPago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBanco {
            get {
                return this.IdBancoField;
            }
            set {
                if ((this.IdBancoField.Equals(value) != true)) {
                    this.IdBancoField = value;
                    this.RaisePropertyChanged("IdBanco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdOrden {
            get {
                return this.IdOrdenField;
            }
            set {
                if ((this.IdOrdenField.Equals(value) != true)) {
                    this.IdOrdenField = value;
                    this.RaisePropertyChanged("IdOrden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSucursal {
            get {
                return this.IdSucursalField;
            }
            set {
                if ((this.IdSucursalField.Equals(value) != true)) {
                    this.IdSucursalField = value;
                    this.RaisePropertyChanged("IdSucursal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Moneda {
            get {
                return this.MonedaField;
            }
            set {
                if ((this.MonedaField.Equals(value) != true)) {
                    this.MonedaField = value;
                    this.RaisePropertyChanged("Moneda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Monto {
            get {
                return this.MontoField;
            }
            set {
                if ((this.MontoField.Equals(value) != true)) {
                    this.MontoField = value;
                    this.RaisePropertyChanged("Monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TxtSucursal {
            get {
                return this.TxtSucursalField;
            }
            set {
                if ((object.ReferenceEquals(this.TxtSucursalField, value) != true)) {
                    this.TxtSucursalField = value;
                    this.RaisePropertyChanged("TxtSucursal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBank.IBankServiceSoap")]
    public interface IBankServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllBanks", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllBanksResponse")]
        System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BankBE> GetAllBanks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllBanks", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllBanksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BankBE>> GetAllBanksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/InsertBank", ReplyAction="http://tempuri.org/IBankServiceSoap/InsertBankResponse")]
        int InsertBank(Bank.WebApplication.ServiceBank.BankBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/InsertBank", ReplyAction="http://tempuri.org/IBankServiceSoap/InsertBankResponse")]
        System.Threading.Tasks.Task<int> InsertBankAsync(Bank.WebApplication.ServiceBank.BankBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/UpdateBank", ReplyAction="http://tempuri.org/IBankServiceSoap/UpdateBankResponse")]
        int UpdateBank(Bank.WebApplication.ServiceBank.BankBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/UpdateBank", ReplyAction="http://tempuri.org/IBankServiceSoap/UpdateBankResponse")]
        System.Threading.Tasks.Task<int> UpdateBankAsync(Bank.WebApplication.ServiceBank.BankBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/DeleteBank", ReplyAction="http://tempuri.org/IBankServiceSoap/DeleteBankResponse")]
        int DeleteBank(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/DeleteBank", ReplyAction="http://tempuri.org/IBankServiceSoap/DeleteBankResponse")]
        System.Threading.Tasks.Task<int> DeleteBankAsync(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllBranchs", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllBranchsResponse")]
        System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BranchBE> GetAllBranchs(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllBranchs", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllBranchsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BranchBE>> GetAllBranchsAsync(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetBank", ReplyAction="http://tempuri.org/IBankServiceSoap/GetBankResponse")]
        Bank.WebApplication.ServiceBank.BankBE GetBank(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetBank", ReplyAction="http://tempuri.org/IBankServiceSoap/GetBankResponse")]
        System.Threading.Tasks.Task<Bank.WebApplication.ServiceBank.BankBE> GetBankAsync(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/InsertBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/InsertBranchResponse")]
        int InsertBranch(Bank.WebApplication.ServiceBank.BranchBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/InsertBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/InsertBranchResponse")]
        System.Threading.Tasks.Task<int> InsertBranchAsync(Bank.WebApplication.ServiceBank.BranchBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/UpdateBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/UpdateBranchResponse")]
        int UpdateBranch(Bank.WebApplication.ServiceBank.BranchBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/UpdateBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/UpdateBranchResponse")]
        System.Threading.Tasks.Task<int> UpdateBranchAsync(Bank.WebApplication.ServiceBank.BranchBE modelBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/DeleteBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/DeleteBranchResponse")]
        int DeleteBranch(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/DeleteBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/DeleteBranchResponse")]
        System.Threading.Tasks.Task<int> DeleteBranchAsync(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/GetBranchResponse")]
        Bank.WebApplication.ServiceBank.BranchBE GetBranch(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetBranch", ReplyAction="http://tempuri.org/IBankServiceSoap/GetBranchResponse")]
        System.Threading.Tasks.Task<Bank.WebApplication.ServiceBank.BranchBE> GetBranchAsync(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllOrdersByBank", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllOrdersByBankResponse")]
        System.Collections.Generic.List<Bank.WebApplication.ServiceBank.OrderBE> GetAllOrdersByBank(int idBanco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankServiceSoap/GetAllOrdersByBank", ReplyAction="http://tempuri.org/IBankServiceSoap/GetAllOrdersByBankResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.OrderBE>> GetAllOrdersByBankAsync(int idBanco);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankServiceSoapChannel : Bank.WebApplication.ServiceBank.IBankServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankServiceSoapClient : System.ServiceModel.ClientBase<Bank.WebApplication.ServiceBank.IBankServiceSoap>, Bank.WebApplication.ServiceBank.IBankServiceSoap {
        
        public BankServiceSoapClient() {
        }
        
        public BankServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BankBE> GetAllBanks() {
            return base.Channel.GetAllBanks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BankBE>> GetAllBanksAsync() {
            return base.Channel.GetAllBanksAsync();
        }
        
        public int InsertBank(Bank.WebApplication.ServiceBank.BankBE modelBE) {
            return base.Channel.InsertBank(modelBE);
        }
        
        public System.Threading.Tasks.Task<int> InsertBankAsync(Bank.WebApplication.ServiceBank.BankBE modelBE) {
            return base.Channel.InsertBankAsync(modelBE);
        }
        
        public int UpdateBank(Bank.WebApplication.ServiceBank.BankBE modelBE) {
            return base.Channel.UpdateBank(modelBE);
        }
        
        public System.Threading.Tasks.Task<int> UpdateBankAsync(Bank.WebApplication.ServiceBank.BankBE modelBE) {
            return base.Channel.UpdateBankAsync(modelBE);
        }
        
        public int DeleteBank(int idBanco) {
            return base.Channel.DeleteBank(idBanco);
        }
        
        public System.Threading.Tasks.Task<int> DeleteBankAsync(int idBanco) {
            return base.Channel.DeleteBankAsync(idBanco);
        }
        
        public System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BranchBE> GetAllBranchs(int idBanco) {
            return base.Channel.GetAllBranchs(idBanco);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.BranchBE>> GetAllBranchsAsync(int idBanco) {
            return base.Channel.GetAllBranchsAsync(idBanco);
        }
        
        public Bank.WebApplication.ServiceBank.BankBE GetBank(int idBanco) {
            return base.Channel.GetBank(idBanco);
        }
        
        public System.Threading.Tasks.Task<Bank.WebApplication.ServiceBank.BankBE> GetBankAsync(int idBanco) {
            return base.Channel.GetBankAsync(idBanco);
        }
        
        public int InsertBranch(Bank.WebApplication.ServiceBank.BranchBE modelBE) {
            return base.Channel.InsertBranch(modelBE);
        }
        
        public System.Threading.Tasks.Task<int> InsertBranchAsync(Bank.WebApplication.ServiceBank.BranchBE modelBE) {
            return base.Channel.InsertBranchAsync(modelBE);
        }
        
        public int UpdateBranch(Bank.WebApplication.ServiceBank.BranchBE modelBE) {
            return base.Channel.UpdateBranch(modelBE);
        }
        
        public System.Threading.Tasks.Task<int> UpdateBranchAsync(Bank.WebApplication.ServiceBank.BranchBE modelBE) {
            return base.Channel.UpdateBranchAsync(modelBE);
        }
        
        public int DeleteBranch(int idBanco) {
            return base.Channel.DeleteBranch(idBanco);
        }
        
        public System.Threading.Tasks.Task<int> DeleteBranchAsync(int idBanco) {
            return base.Channel.DeleteBranchAsync(idBanco);
        }
        
        public Bank.WebApplication.ServiceBank.BranchBE GetBranch(int idBanco) {
            return base.Channel.GetBranch(idBanco);
        }
        
        public System.Threading.Tasks.Task<Bank.WebApplication.ServiceBank.BranchBE> GetBranchAsync(int idBanco) {
            return base.Channel.GetBranchAsync(idBanco);
        }
        
        public System.Collections.Generic.List<Bank.WebApplication.ServiceBank.OrderBE> GetAllOrdersByBank(int idBanco) {
            return base.Channel.GetAllOrdersByBank(idBanco);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Bank.WebApplication.ServiceBank.OrderBE>> GetAllOrdersByBankAsync(int idBanco) {
            return base.Channel.GetAllOrdersByBankAsync(idBanco);
        }
    }
}
