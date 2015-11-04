// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\AppName.json"
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

using __AppName__ = global::BrainTreePaymentMethod.AppName;
using __ApSchema__ = global::BrainTreePaymentMethod.AppName.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __AppName1__ = global::BrainTreePaymentMethod.AppName.JsonByExample;
using __AppName2__ = global::BrainTreePaymentMethod.AppName.Input;
using __Apname__ = global::BrainTreePaymentMethod.AppName.Input.name;
using __Apdescript__ = global::BrainTreePaymentMethod.AppName.Input.description;

namespace BrainTreePaymentMethod {

#line hidden
public partial class AppName : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ApSchema__ DefaultTemplate = new __ApSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AppName() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AppName(__ApSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ApSchema__ Template { get { return (__ApSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__name__;
    private System.String __bf__description__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__AppName__);
                ClassName = "AppName";
                Properties.ClearExposed();
                name = Add<__TString__>("name");
                name.DefaultValue = "Payment brainTree";
                name.SetCustomAccessors((_p_) => { return ((__AppName__)_p_).__bf__name__; }, (_p_, _v_) => { ((__AppName__)_p_).__bf__name__ = (System.String)_v_; }, false);
                description = Add<__TString__>("description");
                description.DefaultValue = "";
                description.SetCustomAccessors((_p_) => { return ((__AppName__)_p_).__bf__description__; }, (_p_, _v_) => { ((__AppName__)_p_).__bf__description__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __AppName__(this) { Parent = parent }; }
            public __TString__ name;
            public __TString__ description;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String name {
#line 2 "ViewModels\AppName.json"
    get {
#line hidden
        return Template.name.Getter(this); }
#line 2 "ViewModels\AppName.json"
    set {
#line hidden
        Template.name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String description {
#line 4 "ViewModels\AppName.json"
    get {
#line hidden
        return Template.description.Getter(this); }
#line 4 "ViewModels\AppName.json"
    set {
#line hidden
        Template.description.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class name : Input<__AppName__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class description : Input<__AppName__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AppName_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108