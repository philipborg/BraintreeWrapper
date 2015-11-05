// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\Shared\TopPage.json"
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
#pragma warning disable 0108
#pragma warning disable 1591

using __TErSchema__ = global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson.JsonByExample.Schema;
using __ToAmount__ = global::BrainTreeApp.ViewModels.Shared.TopPage.Input.Amount;
using __TopPage2__ = global::BrainTreeApp.ViewModels.Shared.TopPage.Input;
using __Arr__ = global::Starcounter.Arr<global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson>;
using __TopPage1__ = global::BrainTreeApp.ViewModels.Shared.TopPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson>;
using __TErError__ = global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson.Input.Error;
using __ToErrorsEl2__ = global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson.Input;
using __ToErrorsEl1__ = global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __ToSuccess__ = global::BrainTreeApp.ViewModels.Shared.TopPage.Input.Success;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ToErrorsEl__ = global::BrainTreeApp.ViewModels.Shared.TopPage.ErrorsElementJson;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __ToSchema__ = global::BrainTreeApp.ViewModels.Shared.TopPage.JsonByExample.Schema;
using __TopPage__ = global::BrainTreeApp.ViewModels.Shared.TopPage;
using __ToTotalPay__ = global::BrainTreeApp.ViewModels.Shared.TopPage.Input.TotalPayableItems;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TopPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Errors : s::TemplateAttribute {
    }
    #line default
}
#line default

namespace BrainTreeApp.ViewModels.Shared {

#line hidden
public partial class TopPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ToSchema__ DefaultTemplate = new __ToSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TopPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TopPage(__ToSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ToSchema__ Template { get { return (__ToSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.Decimal __bf__Amount__;
    private System.Int64 __bf__TotalPayableItems__;
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
                InstanceType = typeof(__TopPage__);
                ClassName = "TopPage";
                Properties.ClearExposed();
                Amount = Add<__TDecimal__>("Amount$");
                Amount.DefaultValue = 0.0m;
                Amount.Editable = true;
                Amount.SetCustomAccessors((_p_) => { return ((__TopPage__)_p_).__bf__Amount__; }, (_p_, _v_) => { ((__TopPage__)_p_).__bf__Amount__ = (System.Decimal)_v_; }, false);
                TotalPayableItems = Add<__TLong__>("TotalPayableItems$");
                TotalPayableItems.DefaultValue = 0L;
                TotalPayableItems.Editable = true;
                TotalPayableItems.SetCustomAccessors((_p_) => { return ((__TopPage__)_p_).__bf__TotalPayableItems__; }, (_p_, _v_) => { ((__TopPage__)_p_).__bf__TotalPayableItems__ = (System.Int64)_v_; }, false);
                Errors = Add<__TArray__>("Errors");
                Errors.SetCustomGetElementType((arr) => { return __ToErrorsEl__.DefaultTemplate;});
                Errors.SetCustomAccessors((_p_) => { return ((__TopPage__)_p_).__bf__Errors__; }, (_p_, _v_) => { ((__TopPage__)_p_).__bf__Errors__ = (__Arr__)_v_; }, false);
                Success = Add<__TString__>("Success");
                Success.DefaultValue = "";
                Success.SetCustomAccessors((_p_) => { return ((__TopPage__)_p_).__bf__Success__; }, (_p_, _v_) => { ((__TopPage__)_p_).__bf__Success__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __TopPage__(this) { Parent = parent }; }
            public __TDecimal__ Amount;
            public __TLong__ TotalPayableItems;
            public __TArray__ Errors;
            public __TString__ Success;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal Amount {
#line 2 "ViewModels\Shared\TopPage.json"
    get {
#line hidden
        return Template.Amount.Getter(this); }
#line 2 "ViewModels\Shared\TopPage.json"
    set {
#line hidden
        Template.Amount.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalPayableItems {
#line 3 "ViewModels\Shared\TopPage.json"
    get {
#line hidden
        return Template.TotalPayableItems.Getter(this); }
#line 3 "ViewModels\Shared\TopPage.json"
    set {
#line hidden
        Template.TotalPayableItems.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Errors {
#line 8 "ViewModels\Shared\TopPage.json"
    get {
#line hidden
        return Template.Errors.Getter(this); }
#line 8 "ViewModels\Shared\TopPage.json"
    set {
#line hidden
        Template.Errors.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Success {
#line 10 "ViewModels\Shared\TopPage.json"
    get {
#line hidden
        return Template.Success.Getter(this); }
#line 10 "ViewModels\Shared\TopPage.json"
    set {
#line hidden
        Template.Success.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ErrorsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __TErSchema__ DefaultTemplate = new __TErSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ErrorsElementJson(__TErSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __TErSchema__ Template { get { return (__TErSchema__)base.Template; } set { base.Template = value; } }
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
                    InstanceType = typeof(__ToErrorsEl__);
                    ClassName = "ErrorsElementJson";
                    Properties.ClearExposed();
                    Error = Add<__TString__>("Error");
                    Error.DefaultValue = "";
                    Error.SetCustomAccessors((_p_) => { return ((__ToErrorsEl__)_p_).__bf__Error__; }, (_p_, _v_) => { ((__ToErrorsEl__)_p_).__bf__Error__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ToErrorsEl__(this) { Parent = parent }; }
                public __TString__ Error;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Error {
#line 7 "ViewModels\Shared\TopPage.json"
    get {
#line hidden
        return Template.Error.Getter(this); }
#line 7 "ViewModels\Shared\TopPage.json"
    set {
#line hidden
        Template.Error.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Error : Input<__ToErrorsEl__, __TString__, string> {
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
        public class Amount : Input<__TopPage__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class TotalPayableItems : Input<__TopPage__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Success : Input<__TopPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108