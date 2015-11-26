// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\CreditCard\CreditCardPage.json"
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
using BrainTreeApi;
using BrainTreeApi.Models.CreditCard;
using BrainTreeApi.Models.Customer;
using BrainTreeApi.Models.Payment;
#pragma warning disable 0108
#pragma warning disable 1591

using __CErSchema__ = global::BrainTreeApp.CreditCardPage.ErrorsElementJson.JsonByExample.Schema;
using __CrErrorsEl2__ = global::BrainTreeApp.CreditCardPage.ErrorsElementJson.Input;
using __CErError__ = global::BrainTreeApp.CreditCardPage.ErrorsElementJson.Input.Error;
using __TArray2__ = global::Starcounter.Templates.TArray<global::BrainTreeApp.CreditCardPage.ErrorsElementJson>;
using __CreditCa1__ = global::BrainTreeApp.CreditCardPage.JsonByExample;
using __CrCreditCa__ = global::BrainTreeApp.CreditCardPage.CreditCardJson;
using __CrCreditCa1__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.JsonByExample;
using __CrCreditCa2__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.Input;
using __CCrCardNumb__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.Input.CardNumber;
using __CCrExpiryMo__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.Input.ExpiryMonth;
using __CCrExpiryYe__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.Input.ExpiryYear;
using __CCrSecurity__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.Input.SecurityNumber;
using __CrCreditCa3__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson;
using __CrCreditCa4__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.JsonByExample;
using __CrCreditCa5__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.Input;
using __CCrCardNumb1__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.Input.CardNumber;
using __CCrExpiryMo1__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.Input.ExpiryMonth;
using __CCrExpiryYe1__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.Input.ExpiryYear;
using __CCrSecurity1__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.Input.SecurityNumber;
using __Arr__ = global::Starcounter.Arr<global::BrainTreeApp.CreditCardPage.MonthsElementJson>;
using __Arr1__ = global::Starcounter.Arr<global::BrainTreeApp.CreditCardPage.YearsElementJson>;
using __Arr2__ = global::Starcounter.Arr<global::BrainTreeApp.CreditCardPage.ErrorsElementJson>;
using __CreditCa2__ = global::BrainTreeApp.CreditCardPage.Input;
using __CrHtml__ = global::BrainTreeApp.CreditCardPage.Input.Html;
using __CrErrorsEl1__ = global::BrainTreeApp.CreditCardPage.ErrorsElementJson.JsonByExample;
using __CrPay__ = global::BrainTreeApp.CreditCardPage.Input.Pay;
using __CrRedirect__ = global::BrainTreeApp.CreditCardPage.Input.RedirectUrl;
using __TArray1__ = global::Starcounter.Templates.TArray<global::BrainTreeApp.CreditCardPage.YearsElementJson>;
using __CreditCa__ = global::BrainTreeApp.CreditCardPage;
using __CrSchema__ = global::BrainTreeApp.CreditCardPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CCrSchema__ = global::BrainTreeApp.CreditCardPage.CreditCardJson.JsonByExample.Schema;
using __TObject__ = global::Starcounter.Templates.TObject;
using __CCrSchema1__ = global::BrainTreeApp.CreditCardPage.CreditCardErrorJson.JsonByExample.Schema;
using __CrMonthsEl__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson;
using __Json__ = global::Starcounter.Json;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CrErrorsEl__ = global::BrainTreeApp.CreditCardPage.ErrorsElementJson;
using __CMoSchema__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson.JsonByExample.Schema;
using __CrMonthsEl2__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson.Input;
using __CMoText__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson.Input.Text;
using __CMoValue__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson.Input.Value;
using __TArray__ = global::Starcounter.Templates.TArray<global::BrainTreeApp.CreditCardPage.MonthsElementJson>;
using __CrYearsEle__ = global::BrainTreeApp.CreditCardPage.YearsElementJson;
using __CYeSchema__ = global::BrainTreeApp.CreditCardPage.YearsElementJson.JsonByExample.Schema;
using __CrYearsEle1__ = global::BrainTreeApp.CreditCardPage.YearsElementJson.JsonByExample;
using __CrYearsEle2__ = global::BrainTreeApp.CreditCardPage.YearsElementJson.Input;
using __CYeText__ = global::BrainTreeApp.CreditCardPage.YearsElementJson.Input.Text;
using __CYeValue__ = global::BrainTreeApp.CreditCardPage.YearsElementJson.Input.Value;
using __CrMonthsEl1__ = global::BrainTreeApp.CreditCardPage.MonthsElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CreditCardPage_json : s::TemplateAttribute {
    
    #line hidden
    public class CreditCard : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class CreditCardError : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Months : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Years : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Errors : s::TemplateAttribute {
    }
    #line default
}
#line default

namespace BrainTreeApp {

#line hidden
public partial class CreditCardPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CrSchema__ DefaultTemplate = new __CrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditCardPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditCardPage(__CrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CrSchema__ Template { get { return (__CrSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Payable Data { get { return (Payable)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private System.Int64 __bf__Pay__;
    private __CrCreditCa__ __bf__CreditCard__;
    private __CrCreditCa3__ __bf__CreditCardError__;
    private __Arr__ __bf__Months__;
    private __Arr1__ __bf__Years__;
    private __Arr2__ __bf__Errors__;
    private System.String __bf__RedirectUrl__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__CreditCa__);
                ClassName = "CreditCardPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/CreditCard/CreditCardPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Pay = Add<__TLong__>("Pay$");
                Pay.DefaultValue = 0L;
                Pay.Editable = true;
                Pay.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__Pay__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__Pay__ = (System.Int64)_v_; }, false);
                Pay.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Pay() { App = (CreditCardPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CreditCardPage)pup).Handle((Input.Pay)input); });
                CreditCard = Add<__CCrSchema__>("CreditCard");
                CreditCard.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__CreditCard__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__CreditCard__ = (__CrCreditCa__)_v_; }, false);
                CreditCardError = Add<__CCrSchema1__>("CreditCardError");
                CreditCardError.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__CreditCardError__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__CreditCardError__ = (__CrCreditCa3__)_v_; }, false);
                Months = Add<__TArray__>("Months");
                Months.SetCustomGetElementType((arr) => { return __CrMonthsEl__.DefaultTemplate;});
                Months.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__Months__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__Months__ = (__Arr__)_v_; }, false);
                Years = Add<__TArray1__>("Years");
                Years.SetCustomGetElementType((arr) => { return __CrYearsEle__.DefaultTemplate;});
                Years.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__Years__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__Years__ = (__Arr1__)_v_; }, false);
                Errors = Add<__TArray2__>("Errors");
                Errors.SetCustomGetElementType((arr) => { return __CrErrorsEl__.DefaultTemplate;});
                Errors.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__Errors__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__Errors__ = (__Arr2__)_v_; }, false);
                RedirectUrl = Add<__TString__>("RedirectUrl$");
                RedirectUrl.DefaultValue = "";
                RedirectUrl.Editable = true;
                RedirectUrl.SetCustomAccessors((_p_) => { return ((__CreditCa__)_p_).__bf__RedirectUrl__; }, (_p_, _v_) => { ((__CreditCa__)_p_).__bf__RedirectUrl__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __CreditCa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Pay;
            public __CCrSchema__ CreditCard;
            public __CCrSchema1__ CreditCardError;
            public __TArray__ Months;
            public __TArray1__ Years;
            public __TArray2__ Errors;
            public __TString__ RedirectUrl;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Pay {
#line 3 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Pay.Getter(this); }
#line 3 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Pay.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CrCreditCa__ CreditCard {
#line 9 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return (__CrCreditCa__)Template.CreditCard.Getter(this); }
#line 9 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.CreditCard.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __CrCreditCa3__ CreditCardError {
#line 15 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return (__CrCreditCa3__)Template.CreditCardError.Getter(this); }
#line 15 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.CreditCardError.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Months {
#line 21 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Months.Getter(this); }
#line 21 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Months.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Years {
#line 27 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Years.Getter(this); }
#line 27 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Years.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr2__ Errors {
#line 32 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Errors.Getter(this); }
#line 32 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Errors.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String RedirectUrl {
#line 34 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.RedirectUrl.Getter(this); }
#line 34 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.RedirectUrl.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CreditCardJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCrSchema__ DefaultTemplate = new __CCrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardJson(__CCrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCrSchema__ Template { get { return (__CCrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__CardNumber__;
        private System.String __bf__ExpiryMonth__;
        private System.String __bf__ExpiryYear__;
        private System.String __bf__SecurityNumber__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrCreditCa__);
                    ClassName = "CreditCardJson";
                    Properties.ClearExposed();
                    CardNumber = Add<__TString__>("CardNumber$");
                    CardNumber.DefaultValue = "";
                    CardNumber.Editable = true;
                    CardNumber.SetCustomAccessors((_p_) => { return ((__CrCreditCa__)_p_).__bf__CardNumber__; }, (_p_, _v_) => { ((__CrCreditCa__)_p_).__bf__CardNumber__ = (System.String)_v_; }, false);
                    ExpiryMonth = Add<__TString__>("ExpiryMonth$");
                    ExpiryMonth.DefaultValue = "0";
                    ExpiryMonth.Editable = true;
                    ExpiryMonth.SetCustomAccessors((_p_) => { return ((__CrCreditCa__)_p_).__bf__ExpiryMonth__; }, (_p_, _v_) => { ((__CrCreditCa__)_p_).__bf__ExpiryMonth__ = (System.String)_v_; }, false);
                    ExpiryYear = Add<__TString__>("ExpiryYear$");
                    ExpiryYear.DefaultValue = "0";
                    ExpiryYear.Editable = true;
                    ExpiryYear.SetCustomAccessors((_p_) => { return ((__CrCreditCa__)_p_).__bf__ExpiryYear__; }, (_p_, _v_) => { ((__CrCreditCa__)_p_).__bf__ExpiryYear__ = (System.String)_v_; }, false);
                    SecurityNumber = Add<__TString__>("SecurityNumber$");
                    SecurityNumber.DefaultValue = "";
                    SecurityNumber.Editable = true;
                    SecurityNumber.SetCustomAccessors((_p_) => { return ((__CrCreditCa__)_p_).__bf__SecurityNumber__; }, (_p_, _v_) => { ((__CrCreditCa__)_p_).__bf__SecurityNumber__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrCreditCa__(this) { Parent = parent }; }
                public __TString__ CardNumber;
                public __TString__ ExpiryMonth;
                public __TString__ ExpiryYear;
                public __TString__ SecurityNumber;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CardNumber {
#line 5 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.CardNumber.Getter(this); }
#line 5 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.CardNumber.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryMonth {
#line 6 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.ExpiryMonth.Getter(this); }
#line 6 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.ExpiryMonth.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryYear {
#line 7 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.ExpiryYear.Getter(this); }
#line 7 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.ExpiryYear.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SecurityNumber {
#line 9 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.SecurityNumber.Getter(this); }
#line 9 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.SecurityNumber.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CardNumber : Input<__CrCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryMonth : Input<__CrCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryYear : Input<__CrCreditCa__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class SecurityNumber : Input<__CrCreditCa__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CreditCardErrorJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCrSchema1__ DefaultTemplate = new __CCrSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardErrorJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CreditCardErrorJson(__CCrSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCrSchema1__ Template { get { return (__CCrSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__CardNumber__;
        private System.String __bf__ExpiryMonth__;
        private System.String __bf__ExpiryYear__;
        private System.String __bf__SecurityNumber__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrCreditCa3__);
                    ClassName = "CreditCardErrorJson";
                    Properties.ClearExposed();
                    CardNumber = Add<__TString__>("CardNumber");
                    CardNumber.DefaultValue = "";
                    CardNumber.SetCustomAccessors((_p_) => { return ((__CrCreditCa3__)_p_).__bf__CardNumber__; }, (_p_, _v_) => { ((__CrCreditCa3__)_p_).__bf__CardNumber__ = (System.String)_v_; }, false);
                    ExpiryMonth = Add<__TString__>("ExpiryMonth");
                    ExpiryMonth.DefaultValue = "";
                    ExpiryMonth.SetCustomAccessors((_p_) => { return ((__CrCreditCa3__)_p_).__bf__ExpiryMonth__; }, (_p_, _v_) => { ((__CrCreditCa3__)_p_).__bf__ExpiryMonth__ = (System.String)_v_; }, false);
                    ExpiryYear = Add<__TString__>("ExpiryYear");
                    ExpiryYear.DefaultValue = "";
                    ExpiryYear.SetCustomAccessors((_p_) => { return ((__CrCreditCa3__)_p_).__bf__ExpiryYear__; }, (_p_, _v_) => { ((__CrCreditCa3__)_p_).__bf__ExpiryYear__ = (System.String)_v_; }, false);
                    SecurityNumber = Add<__TString__>("SecurityNumber");
                    SecurityNumber.DefaultValue = "";
                    SecurityNumber.SetCustomAccessors((_p_) => { return ((__CrCreditCa3__)_p_).__bf__SecurityNumber__; }, (_p_, _v_) => { ((__CrCreditCa3__)_p_).__bf__SecurityNumber__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrCreditCa3__(this) { Parent = parent }; }
                public __TString__ CardNumber;
                public __TString__ ExpiryMonth;
                public __TString__ ExpiryYear;
                public __TString__ SecurityNumber;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CardNumber {
#line 11 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.CardNumber.Getter(this); }
#line 11 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.CardNumber.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryMonth {
#line 12 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.ExpiryMonth.Getter(this); }
#line 12 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.ExpiryMonth.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ExpiryYear {
#line 13 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.ExpiryYear.Getter(this); }
#line 13 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.ExpiryYear.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SecurityNumber {
#line 15 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.SecurityNumber.Getter(this); }
#line 15 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.SecurityNumber.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CardNumber : Input<__CrCreditCa3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryMonth : Input<__CrCreditCa3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ExpiryYear : Input<__CrCreditCa3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class SecurityNumber : Input<__CrCreditCa3__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class MonthsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CMoSchema__ DefaultTemplate = new __CMoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public MonthsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public MonthsElementJson(__CMoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CMoSchema__ Template { get { return (__CMoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Text__;
        private System.String __bf__Value__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrMonthsEl__);
                    ClassName = "MonthsElementJson";
                    Properties.ClearExposed();
                    Text = Add<__TString__>("Text");
                    Text.DefaultValue = "";
                    Text.SetCustomAccessors((_p_) => { return ((__CrMonthsEl__)_p_).__bf__Text__; }, (_p_, _v_) => { ((__CrMonthsEl__)_p_).__bf__Text__ = (System.String)_v_; }, false);
                    Value = Add<__TString__>("Value");
                    Value.DefaultValue = "";
                    Value.SetCustomAccessors((_p_) => { return ((__CrMonthsEl__)_p_).__bf__Value__; }, (_p_, _v_) => { ((__CrMonthsEl__)_p_).__bf__Value__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrMonthsEl__(this) { Parent = parent }; }
                public __TString__ Text;
                public __TString__ Value;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Text {
#line 18 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Text.Getter(this); }
#line 18 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Text.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Value {
#line 20 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Value.Getter(this); }
#line 20 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Value.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Text : Input<__CrMonthsEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Value : Input<__CrMonthsEl__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class YearsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CYeSchema__ DefaultTemplate = new __CYeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public YearsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public YearsElementJson(__CYeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CYeSchema__ Template { get { return (__CYeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Text__;
        private System.String __bf__Value__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrYearsEle__);
                    ClassName = "YearsElementJson";
                    Properties.ClearExposed();
                    Text = Add<__TString__>("Text");
                    Text.DefaultValue = "";
                    Text.SetCustomAccessors((_p_) => { return ((__CrYearsEle__)_p_).__bf__Text__; }, (_p_, _v_) => { ((__CrYearsEle__)_p_).__bf__Text__ = (System.String)_v_; }, false);
                    Value = Add<__TString__>("Value");
                    Value.DefaultValue = "";
                    Value.SetCustomAccessors((_p_) => { return ((__CrYearsEle__)_p_).__bf__Value__; }, (_p_, _v_) => { ((__CrYearsEle__)_p_).__bf__Value__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrYearsEle__(this) { Parent = parent }; }
                public __TString__ Text;
                public __TString__ Value;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Text {
#line 24 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Text.Getter(this); }
#line 24 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Text.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Value {
#line 26 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Value.Getter(this); }
#line 26 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Value.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Text : Input<__CrYearsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Value : Input<__CrYearsEle__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ErrorsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CErSchema__ DefaultTemplate = new __CErSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson(__CErSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CErSchema__ Template { get { return (__CErSchema__)base.Template; } set { base.Template = value; } }
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
                    InstanceType = typeof(__CrErrorsEl__);
                    ClassName = "ErrorsElementJson";
                    Properties.ClearExposed();
                    Error = Add<__TString__>("Error");
                    Error.DefaultValue = "";
                    Error.SetCustomAccessors((_p_) => { return ((__CrErrorsEl__)_p_).__bf__Error__; }, (_p_, _v_) => { ((__CrErrorsEl__)_p_).__bf__Error__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrErrorsEl__(this) { Parent = parent }; }
                public __TString__ Error;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Error {
#line 31 "ViewModels\CreditCard\CreditCardPage.json"
    get {
#line hidden
        return Template.Error.Getter(this); }
#line 31 "ViewModels\CreditCard\CreditCardPage.json"
    set {
#line hidden
        Template.Error.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Error : Input<__CrErrorsEl__, __TString__, string> {
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
        public class Html : Input<__CreditCa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Pay : Input<__CreditCa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RedirectUrl : Input<__CreditCa__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108