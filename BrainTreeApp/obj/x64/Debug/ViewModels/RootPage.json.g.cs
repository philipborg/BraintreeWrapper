// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\RootPage.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
using BrainTreeApi.Models.Address;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Payment;
using BrainTreeApi.Service.TransactionService;
using BrainTreeApi.Service.CustomerServices;
using BrainTreeApi.Models.Company;
#pragma warning disable 0108
#pragma warning disable 1591

using __RErSchema__ = global::BrainTreePaymentMethod.RootPage.ErrorsElementJson.JsonByExample.Schema;
using __RoTotalPay__ = global::BrainTreePaymentMethod.RootPage.Input.TotalPayableItems;
using __RoAmount__ = global::BrainTreePaymentMethod.RootPage.Input.Amount;
using __RoHtml__ = global::BrainTreePaymentMethod.RootPage.Input.Html;
using __RootPage2__ = global::BrainTreePaymentMethod.RootPage.Input;
using __Arr__ = global::Starcounter.Arr<global::BrainTreePaymentMethod.RootPage.ErrorsElementJson>;
using __RootPage1__ = global::BrainTreePaymentMethod.RootPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::BrainTreePaymentMethod.RootPage.ErrorsElementJson>;
using __RErError__ = global::BrainTreePaymentMethod.RootPage.ErrorsElementJson.Input.Error;
using __RoErrorsEl2__ = global::BrainTreePaymentMethod.RootPage.ErrorsElementJson.Input;
using __RoErrorsEl1__ = global::BrainTreePaymentMethod.RootPage.ErrorsElementJson.JsonByExample;
using __RoSuccess__ = global::BrainTreePaymentMethod.RootPage.Input.Success;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __Json__ = global::Starcounter.Json;
using __RoErrorsEl__ = global::BrainTreePaymentMethod.RootPage.ErrorsElementJson;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TObject__ = global::Starcounter.Templates.TObject;
using __TString__ = global::Starcounter.Templates.TString;
using __RoSchema__ = global::BrainTreePaymentMethod.RootPage.JsonByExample.Schema;
using __RootPage__ = global::BrainTreePaymentMethod.RootPage;
using __RoPay__ = global::BrainTreePaymentMethod.RootPage.Input.Pay;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class RootPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Errors : s::TemplateAttribute {
    }
    #line default
}
#line default

namespace BrainTreePaymentMethod {

#line hidden
public partial class RootPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __RoSchema__ DefaultTemplate = new __RoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RootPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RootPage(__RoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __RoSchema__ Template { get { return (__RoSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new CustomerDataPage Data { get { return (CustomerDataPage)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private Starcounter.Json __bf__CurrentPage__;
    private System.Decimal __bf__Amount__;
    private System.Int64 __bf__TotalPayableItems__;
    private System.Int64 __bf__Pay__;
    private __Arr__ __bf__Errors__;
    private System.String __bf__Success__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__RootPage__);
                ClassName = "RootPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/BrainTreePaymentMethod/LauncherWrapperPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CurrentPage = Add<__TObject__>("CurrentPage");
                CurrentPage.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__CurrentPage__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__CurrentPage__ = (__Json__)_v_; }, false);
                Amount = Add<__TDecimal__>("Amount");
                Amount.DefaultValue = 0.0m;
                Amount.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__Amount__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__Amount__ = (System.Decimal)_v_; }, false);
                TotalPayableItems = Add<__TLong__>("TotalPayableItems");
                TotalPayableItems.DefaultValue = 0L;
                TotalPayableItems.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__TotalPayableItems__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__TotalPayableItems__ = (System.Int64)_v_; }, false);
                Pay = Add<__TLong__>("Pay$");
                Pay.DefaultValue = 0L;
                Pay.Editable = true;
                Pay.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__Pay__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__Pay__ = (System.Int64)_v_; }, false);
                Pay.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Pay() { App = (RootPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((RootPage)pup).Handle((Input.Pay)input); });
                Errors = Add<__TArray__>("Errors");
                Errors.SetCustomGetElementType((arr) => { return __RoErrorsEl__.DefaultTemplate;});
                Errors.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__Errors__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__Errors__ = (__Arr__)_v_; }, false);
                Success = Add<__TString__>("Success");
                Success.DefaultValue = "";
                Success.SetCustomAccessors((_p_) => { return ((__RootPage__)_p_).__bf__Success__; }, (_p_, _v_) => { ((__RootPage__)_p_).__bf__Success__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __RootPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TObject__ CurrentPage;
            public __TDecimal__ Amount;
            public __TLong__ TotalPayableItems;
            public __TLong__ Pay;
            public __TArray__ Errors;
            public __TString__ Success;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ CurrentPage {
#line 3 "ViewModels\RootPage.json"
    get {
#line hidden
        return (__Json__)Template.CurrentPage.Getter(this); }
#line 3 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.CurrentPage.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal Amount {
#line 4 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Amount.Getter(this); }
#line 4 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Amount.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalPayableItems {
#line 5 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.TotalPayableItems.Getter(this); }
#line 5 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.TotalPayableItems.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Pay {
#line 6 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Pay.Getter(this); }
#line 6 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Pay.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Errors {
#line 11 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Errors.Getter(this); }
#line 11 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Errors.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Success {
#line 13 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Success.Getter(this); }
#line 13 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Success.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ErrorsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __RErSchema__ DefaultTemplate = new __RErSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson(__RErSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __RErSchema__ Template { get { return (__RErSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Error__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__RoErrorsEl__);
                    ClassName = "ErrorsElementJson";
                    Properties.ClearExposed();
                    Error = Add<__TString__>("Error");
                    Error.DefaultValue = "";
                    Error.SetCustomAccessors((_p_) => { return ((__RoErrorsEl__)_p_).__bf__Error__; }, (_p_, _v_) => { ((__RoErrorsEl__)_p_).__bf__Error__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __RoErrorsEl__(this) { Parent = parent }; }
                public __TString__ Error;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Error {
#line 10 "ViewModels\RootPage.json"
    get {
#line hidden
        return Template.Error.Getter(this); }
#line 10 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.Error.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Error : Input<__RoErrorsEl__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__RootPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Amount : Input<__RootPage__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class TotalPayableItems : Input<__RootPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Pay : Input<__RootPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Success : Input<__RootPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108