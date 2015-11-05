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
#pragma warning disable 0108
#pragma warning disable 1591

using __RootPage__ = global::BrainTreePaymentMethod.RootPage;
using __RoSchema__ = global::BrainTreePaymentMethod.RootPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TObject__ = global::Starcounter.Templates.TObject;
using __RootPage1__ = global::BrainTreePaymentMethod.RootPage.JsonByExample;
using __Json__ = global::Starcounter.Json;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __RootPage2__ = global::BrainTreePaymentMethod.RootPage.Input;
using __RoHtml__ = global::BrainTreePaymentMethod.RootPage.Input.Html;

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
            }
            public override object CreateInstance(s.Json parent) { return new __RootPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TObject__ CurrentPage;
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
#line 4 "ViewModels\RootPage.json"
    get {
#line hidden
        return (__Json__)Template.CurrentPage.Getter(this); }
#line 4 "ViewModels\RootPage.json"
    set {
#line hidden
        Template.CurrentPage.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__RootPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class RootPage_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108