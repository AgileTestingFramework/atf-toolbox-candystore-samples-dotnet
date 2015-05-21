﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CandyStoreAutomation.CandyStore_OrderCandyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.candystore.atf.com/", ConfigurationName="CandyStore_OrderCandyService.CandyOrderSOAPService")]
    public interface CandyOrderSOAPService {
        
        // CODEGEN: Parameter 'orderResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(deleteCandyOrderResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(deleteCandyOrder))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(createCandyOrderResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(createCandyOrder))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="orderResponse")]
        CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1 createCandyOrder(CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1> createCandyOrderAsync(CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 request);
        
        // CODEGEN: Parameter 'responseMessage' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(deleteCandyOrderResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(deleteCandyOrder))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(createCandyOrderResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(createCandyOrder))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="responseMessage")]
        CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1 deleteCandyOrder(CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1> deleteCandyOrderAsync(CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class orderLinePogo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string skuField;
        
        private long quantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
                this.RaisePropertyChanged("sku");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("quantity");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class deleteCandyOrderResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object responseMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public object responseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                this.responseMessageField = value;
                this.RaisePropertyChanged("responseMessage");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class deleteCandyOrder : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long orderNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long orderNumber {
            get {
                return this.orderNumberField;
            }
            set {
                this.orderNumberField = value;
                this.RaisePropertyChanged("orderNumber");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class createCandyOrderResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private candyOrder orderResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public candyOrder orderResponse {
            get {
                return this.orderResponseField;
            }
            set {
                this.orderResponseField = value;
                this.RaisePropertyChanged("orderResponse");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class candyOrder : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal orderTotalField;
        
        private bool orderTotalFieldSpecified;
        
        private candyOrderLine[] orderLinesField;
        
        private long idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal orderTotal {
            get {
                return this.orderTotalField;
            }
            set {
                this.orderTotalField = value;
                this.RaisePropertyChanged("orderTotal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderTotalSpecified {
            get {
                return this.orderTotalFieldSpecified;
            }
            set {
                this.orderTotalFieldSpecified = value;
                this.RaisePropertyChanged("orderTotalSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orderLines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public candyOrderLine[] orderLines {
            get {
                return this.orderLinesField;
            }
            set {
                this.orderLinesField = value;
                this.RaisePropertyChanged("orderLines");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class candyOrderLine : object, System.ComponentModel.INotifyPropertyChanged {
        
        private candy candyField;
        
        private long quantityField;
        
        private decimal priceXUnitField;
        
        private bool priceXUnitFieldSpecified;
        
        private decimal totalField;
        
        private bool totalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public candy candy {
            get {
                return this.candyField;
            }
            set {
                this.candyField = value;
                this.RaisePropertyChanged("candy");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("quantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal priceXUnit {
            get {
                return this.priceXUnitField;
            }
            set {
                this.priceXUnitField = value;
                this.RaisePropertyChanged("priceXUnit");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priceXUnitSpecified {
            get {
                return this.priceXUnitFieldSpecified;
            }
            set {
                this.priceXUnitFieldSpecified = value;
                this.RaisePropertyChanged("priceXUnitSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
                this.RaisePropertyChanged("total");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
                this.RaisePropertyChanged("totalSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class candy : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string skuField;
        
        private string candyNameField;
        
        private long currentQuantityField;
        
        private decimal candyPriceField;
        
        private bool candyPriceFieldSpecified;
        
        private string pictureUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
                this.RaisePropertyChanged("sku");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string candyName {
            get {
                return this.candyNameField;
            }
            set {
                this.candyNameField = value;
                this.RaisePropertyChanged("candyName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long currentQuantity {
            get {
                return this.currentQuantityField;
            }
            set {
                this.currentQuantityField = value;
                this.RaisePropertyChanged("currentQuantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal candyPrice {
            get {
                return this.candyPriceField;
            }
            set {
                this.candyPriceField = value;
                this.RaisePropertyChanged("candyPrice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool candyPriceSpecified {
            get {
                return this.candyPriceFieldSpecified;
            }
            set {
                this.candyPriceFieldSpecified = value;
                this.RaisePropertyChanged("candyPriceSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string pictureUrl {
            get {
                return this.pictureUrlField;
            }
            set {
                this.pictureUrlField = value;
                this.RaisePropertyChanged("pictureUrl");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.candystore.atf.com/")]
    public partial class createCandyOrder : object, System.ComponentModel.INotifyPropertyChanged {
        
        private orderLinePogo[] orderRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("orderLines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public orderLinePogo[] orderRequest {
            get {
                return this.orderRequestField;
            }
            set {
                this.orderRequestField = value;
                this.RaisePropertyChanged("orderRequest");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createCandyOrder", WrapperNamespace="http://service.candystore.atf.com/", IsWrapped=true)]
    public partial class createCandyOrder1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.candystore.atf.com/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("orderLines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CandyStoreAutomation.CandyStore_OrderCandyService.orderLinePogo[] orderRequest;
        
        public createCandyOrder1() {
        }
        
        public createCandyOrder1(CandyStoreAutomation.CandyStore_OrderCandyService.orderLinePogo[] orderRequest) {
            this.orderRequest = orderRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createCandyOrderResponse", WrapperNamespace="http://service.candystore.atf.com/", IsWrapped=true)]
    public partial class createCandyOrderResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.candystore.atf.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CandyStoreAutomation.CandyStore_OrderCandyService.candyOrder orderResponse;
        
        public createCandyOrderResponse1() {
        }
        
        public createCandyOrderResponse1(CandyStoreAutomation.CandyStore_OrderCandyService.candyOrder orderResponse) {
            this.orderResponse = orderResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteCandyOrder", WrapperNamespace="http://service.candystore.atf.com/", IsWrapped=true)]
    public partial class deleteCandyOrder1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.candystore.atf.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long orderNumber;
        
        public deleteCandyOrder1() {
        }
        
        public deleteCandyOrder1(long orderNumber) {
            this.orderNumber = orderNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteCandyOrderResponse", WrapperNamespace="http://service.candystore.atf.com/", IsWrapped=true)]
    public partial class deleteCandyOrderResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.candystore.atf.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object responseMessage;
        
        public deleteCandyOrderResponse1() {
        }
        
        public deleteCandyOrderResponse1(object responseMessage) {
            this.responseMessage = responseMessage;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CandyOrderSOAPServiceChannel : CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CandyOrderSOAPServiceClient : System.ServiceModel.ClientBase<CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService>, CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService {
        
        public CandyOrderSOAPServiceClient() {
        }
        
        public CandyOrderSOAPServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CandyOrderSOAPServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CandyOrderSOAPServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CandyOrderSOAPServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1 CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService.createCandyOrder(CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 request) {
            return base.Channel.createCandyOrder(request);
        }
        
        public CandyStoreAutomation.CandyStore_OrderCandyService.candyOrder createCandyOrder(CandyStoreAutomation.CandyStore_OrderCandyService.orderLinePogo[] orderRequest) {
            CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 inValue = new CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1();
            inValue.orderRequest = orderRequest;
            CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1 retVal = ((CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService)(this)).createCandyOrder(inValue);
            return retVal.orderResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1> CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService.createCandyOrderAsync(CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 request) {
            return base.Channel.createCandyOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrderResponse1> createCandyOrderAsync(CandyStoreAutomation.CandyStore_OrderCandyService.orderLinePogo[] orderRequest) {
            CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1 inValue = new CandyStoreAutomation.CandyStore_OrderCandyService.createCandyOrder1();
            inValue.orderRequest = orderRequest;
            return ((CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService)(this)).createCandyOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1 CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService.deleteCandyOrder(CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 request) {
            return base.Channel.deleteCandyOrder(request);
        }
        
        public object deleteCandyOrder(long orderNumber) {
            CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 inValue = new CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1();
            inValue.orderNumber = orderNumber;
            CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1 retVal = ((CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService)(this)).deleteCandyOrder(inValue);
            return retVal.responseMessage;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1> CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService.deleteCandyOrderAsync(CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 request) {
            return base.Channel.deleteCandyOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrderResponse1> deleteCandyOrderAsync(long orderNumber) {
            CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1 inValue = new CandyStoreAutomation.CandyStore_OrderCandyService.deleteCandyOrder1();
            inValue.orderNumber = orderNumber;
            return ((CandyStoreAutomation.CandyStore_OrderCandyService.CandyOrderSOAPService)(this)).deleteCandyOrderAsync(inValue);
        }
    }
}
