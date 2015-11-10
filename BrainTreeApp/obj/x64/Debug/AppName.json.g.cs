// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AppName.json"
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

using __AppName__ = global::AppName;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __ApSchema__ = global::AppName.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __AppName1__ = global::AppName.JsonByExample;
using __AppName2__ = global::AppName.Input;
using __Apname__ = global::AppName.Input.name;
using __Apdescript__ = global::AppName.Input.description;
using __Aphtml__ = global::AppName.Input.html;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AppName : __Json__ {
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
    private System.String __bf__html__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__AppName__);
                ClassName = "AppName";
                Properties.ClearExposed();
                name = Add<__TString__>("name");
                name.DefaultValue = "";
                name.SetCustomAccessors((_p_) => { return ((__AppName__)_p_).__bf__name__; }, (_p_, _v_) => { ((__AppName__)_p_).__bf__name__ = (System.String)_v_; }, false);
                description = Add<__TString__>("description");
                description.DefaultValue = "";
                description.SetCustomAccessors((_p_) => { return ((__AppName__)_p_).__bf__description__; }, (_p_, _v_) => { ((__AppName__)_p_).__bf__description__ = (System.String)_v_; }, false);
                html = Add<__TString__>("html");
                html.DefaultValue = "/AppIconPage.html";
                html.SetCustomAccessors((_p_) => { return ((__AppName__)_p_).__bf__html__; }, (_p_, _v_) => { ((__AppName__)_p_).__bf__html__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __AppName__(this) { Parent = parent }; }
            public __TString__ name;
            public __TString__ description;
            public __TString__ html;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String name {
#line 2 "AppName.json"
    get {
#line hidden
        return Template.name.Getter(this); }
#line 2 "AppName.json"
    set {
#line hidden
        Template.name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String description {
#line 3 "AppName.json"
    get {
#line hidden
        return Template.description.Getter(this); }
#line 3 "AppName.json"
    set {
#line hidden
        Template.description.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String html {
#line 5 "AppName.json"
    get {
#line hidden
        return Template.html.Getter(this); }
#line 5 "AppName.json"
    set {
#line hidden
        Template.html.Setter(this, value); } }
#line default

    
    #line hidden
    public static class Input {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class name : Input<__AppName__, __TString__, string> {
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class description : Input<__AppName__, __TString__, string> {
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class html : Input<__AppName__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108